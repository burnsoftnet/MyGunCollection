Imports System.IO
Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
' ReSharper disable once InconsistentNaming
Public Class frmFirearmImagePicker
    Dim PicArray As ArrayList
    Dim FirearmIDArray As ArrayList
    Dim FirearmNameArray As ArrayList
    Dim LeftbuttonIndex As Long
    Dim RightButtonIndex As Long
    Dim CurrentIndex As Long
    Dim MaxItems As Long
    'Calculate the Proportional Size of an Image by passing the image size and the MaxSize or Height of the image
    'to return the new size.  The Max Width and Height is the parameters of the container
    Public Function ProportionalSize(ByVal imageSize As Size, ByVal MaxW_MaxH As Size) As Size
        Dim multBy As Double = 1.01
        Dim w As Double = imageSize.Width
        Dim h As Double = imageSize.Height

        While (w < MaxW_MaxH.Width And h < MaxW_MaxH.Height)
            w = imageSize.Width * multBy
            h = imageSize.Height * multBy
            multBy = multBy + 0.001
        End While

        While (w > MaxW_MaxH.Width Or h > MaxW_MaxH.Height)
            multBy = multBy - 0.001
            w = imageSize.Width * multBy
            h = imageSize.Height * multBy
        End While

        If (imageSize.Width < 1) Then
            imageSize = New Size(imageSize.Width - imageSize.Width + 1, imageSize.Height - imageSize.Width - 1)
        ElseIf (imageSize.Height < 1) Then
            imageSize = New Size(imageSize.Width - imageSize.Height - 1, imageSize.Height - imageSize.Height + 1)
        End If
        imageSize = New Size(Convert.ToInt32(w), Convert.ToInt32(h))
        Return imageSize
    End Function
    'Get the image from the database based on the Picture ID
    Sub GetPicture(PICIT As Long)
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT PICTURE from Gun_Collection_Pictures where ID=" & PICIT
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim b() As Byte = CMD.ExecuteScalar
            If (b.Length > 0) Then
                Dim stream As New MemoryStream(b, True)
                stream.Write(b, 0, b.Length)
                Dim bmp As Image = New Bitmap(stream)
                Dim ImgSize As New Size
                ImgSize = ProportionalSize(bmp.Size, PictureBox1.Size)
                Dim newimg As New Bitmap(ImgSize.Width, ImgSize.Height)
                Dim g As Graphics
                g = Graphics.FromImage(newimg)
                g.DrawImage(bmp, 0, 0, ImgSize.Width, ImgSize.Height)
                PictureBox1.Image = newimg
                PictureBox1.Refresh()
                Me.Refresh()
                stream.Close()
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "GetPicture"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Initialize the arrays and load them with information from the database
    ' Load the Picture ID's in one Array, the Firearm ID in another array
    ' and the Full Name in the last array
    Sub LoadArrays()
        Try
            PicArray = New ArrayList
            FirearmIDArray = New ArrayList
            FirearmNameArray = New ArrayList

            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT p.id,p.cid,c.FullName, p.Picture from Gun_Collection_Pictures p inner join Gun_Collection c on c.id=p.cid where p.ISMAIN=1 order by c.FullName asc;"
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim rs As OdbcDataReader
            rs = CMD.ExecuteReader
            While rs.Read
                PicArray.Add(rs("id"))
                FirearmIDArray.Add(rs("cid"))
                FirearmNameArray.Add(rs("FullName"))
                MaxItems += 1
            End While
            rs.Close()
            rs = Nothing
            CMD = Nothing
            Obj.CloseDB()
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "LoadArrays"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Update the indexes for what to display now, and load the button for what was last and what is next
    Sub UpdateIndexes(IndexClicked As Long)
        If IndexClicked = 0 Then
            CurrentIndex = 0
            LeftbuttonIndex = 0
            btnLeft.Enabled = False
            RightButtonIndex = 1
        ElseIf IndexClicked >= (MaxItems - 1) Then
            btnRight.Enabled = False
            CurrentIndex = IndexClicked
            LeftbuttonIndex = CurrentIndex - 1
        Else
            CurrentIndex = IndexClicked
            RightButtonIndex = CurrentIndex + 1
            LeftbuttonIndex = CurrentIndex - 1
            btnLeft.Enabled = True
            btnRight.Enabled = True
        End If
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Call GetPicture(PicArray(CurrentIndex))
        txtName.Text = FirearmNameArray(CurrentIndex)
    End Sub
    'When form is closed
    Private Sub frmFirearmImagePicker_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim ObjVS As New ViewSizeSettings
        ObjVS.SaveViewPicture(Me.Height, Me.Width, Me.Location.X, Me.Location.Y)
        ObjVS = Nothing
    End Sub

    Private Sub frmFirearmImagePicker_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                Call UpdateIndexes(RightButtonIndex)
            Case Keys.Left
                Call UpdateIndexes(LeftbuttonIndex)
            Case Keys.Up
                Call UpdateIndexes(RightButtonIndex)
            Case Keys.Down
                Call UpdateIndexes(LeftbuttonIndex)
        End Select
    End Sub

    Private Sub frmFirearmImagePicker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.Handled
            Case Keys.Right
                Call UpdateIndexes(RightButtonIndex)
            Case Keys.Left
                Call UpdateIndexes(LeftbuttonIndex)
            Case Keys.Up
                Call UpdateIndexes(RightButtonIndex)
            Case Keys.Down
                Call UpdateIndexes(LeftbuttonIndex)
        End Select
    End Sub
    'When form Loads
    Private Sub frmFirearmImagePicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.KeyPreview = True
            MaxItems = 0
            Dim objVS As New ViewSizeSettings
            objVS.LoadViewViewPicture(Me.Height, Me.Width, Me.Location)
            objVS = Nothing
            Call LoadArrays()
            Call UpdateIndexes(0)
            Call GetPicture(PicArray(CurrentIndex))
            Call sizeForm()
        Catch ex As Exception
            Dim sSubFunc As String = "frmFirearmImagePicker_Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'when the right button ( > ) is clicked
    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        Call UpdateIndexes(RightButtonIndex)
    End Sub
    'when the left button ( < ) is clicked
    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        Call UpdateIndexes(LeftbuttonIndex)
    End Sub
    'Show the firearm details when the user click on the picture
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frmNew As New frmViewCollectionDetails
        frmNew.ItemId = FirearmIDArray(CurrentIndex)
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
    End Sub
    'Resize the form and the components to fill the work space of the mdi parent.
    Sub sizeForm()
        Dim WorkspaceWidth As Double = Me.MdiParent.Size.Width - MDIParent1.Panel1.Size.Width - 30
        Dim WorkspaceHeight As Double = Me.MdiParent.Size.Height - 145
        Me.Width = WorkspaceWidth
        Me.Height = WorkspaceHeight
        txtName.Width = WorkspaceWidth - 120
        btnLeft.Height = WorkspaceHeight
        btnRight.Height = WorkspaceHeight
        PictureBox1.Height = WorkspaceHeight - 70
        PictureBox1.Width = WorkspaceWidth - 40
        btnRight.Location = New Point(WorkspaceWidth - 40, btnLeft.Location.Y)
    End Sub
End Class