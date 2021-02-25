Imports System.Data
Imports ADODB
Imports System.io
Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
Public Class frmViewPicture
    Public MyID As Long
    Public GroupID As Long
    Public HasInit As Boolean
    Public sName As String = ""
    Public sNote As String = ""
#Region "Menu Items"
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub ExportPictureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportPictureToolStripMenuItem.Click
        Try
            SaveFileDialog1.FilterIndex = 3
            SaveFileDialog1.Filter = "Bmp Files(*.bmp)|*.bmp|Gif Files(*.gif)|*.gif|Jpg Files(*.jpg)|*.jpg|Tiff Files(*.tiff)|*.tiff|WMF Files(*.wmf)|*.wmf"
            SaveFileDialog1.FileName = "PictureID_" & MyID '& ".jpg"
            SaveFileDialog1.Title = "Export Image to File"
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
            Dim strFilePath As String = SaveFileDialog1.FileName
            Dim ImgFormat As System.Drawing.Imaging.ImageFormat = Imaging.ImageFormat.Jpeg
            Dim fs As System.IO.FileStream = CType(SaveFileDialog1.OpenFile(), System.IO.FileStream)
            Select Case SaveFileDialog1.FilterIndex
                Case 1
                    ImgFormat = Imaging.ImageFormat.Bmp
                Case 2
                    ImgFormat = Imaging.ImageFormat.Gif
                Case 3
                    ImgFormat = Imaging.ImageFormat.Jpeg
                Case 4
                    ImgFormat = Imaging.ImageFormat.Tiff
                Case 5
                    ImgFormat = Imaging.ImageFormat.Wmf
                Case Else
                    ImgFormat = Imaging.ImageFormat.Jpeg
            End Select
            Dim bmp As New Bitmap(Me.PictureBox1.Image)
            bmp.Save(fs, ImgFormat)
            bmp.Dispose()
            fs.Close()
            fs = Nothing
            bmp = Nothing
            MsgBox("Picture was exported to " & strFilePath)
        Catch ex As Exception
            Dim sSubFunc As String = "ExportPictureToolStripMenuItem.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub ChangePictureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePictureToolStripMenuItem.Click
        Try
            Dim SQLU As String = "UPDATE Gun_Collection_Pictures set ISMAIN=0 where CID=" & GroupID
            Dim SQL As String = "UPDATE Gun_Collection_Pictures set ISMAIN=1 where ID=" & MyID
            Dim Obj As New BSDatabase
            Obj.ConnExec(SQLU)
            Obj.ConnExec(SQL)
            MsgBox("This is now the Default Picture")
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "ChangePictureToolStripMenuItem_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'stretch the windows to the original size of the picture
    Private Sub AutoSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoSizeToolStripMenuItem.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        AutoSizeToolStripMenuItem.Checked = True
        StretchToolStripMenuItem.Checked = False
        Call DoInitPicDrawing()
    End Sub
    'stretch the image to the size of the active window
    Private Sub StretchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StretchToolStripMenuItem.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        StretchToolStripMenuItem.Checked = True
        AutoSizeToolStripMenuItem.Checked = False
        Call DoResize()
    End Sub
#End Region
#Region "Form Items"
    'When the form closes, save location ending
    Private Sub frmViewPicture_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        PictureBox1.Dispose()

        If Not DoOriginalImage Then
            Dim ObjVS As New ViewSizeSettings
            ObjVS.SaveViewPicture(Me.Height, Me.Width, Me.Location.X, Me.Location.Y)
            ObjVS = Nothing
        End If
    End Sub
    Private Sub frmViewPicture_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GetPictureInfo(MyID, sName, sNote)
        If Len(sName) = 0 Then sName = "PictureID_" & MyID

        Me.Text = "View Picture - " & sName
        ToolTip1.ToolTipTitle = sName
        ToolTip1.SetToolTip(PictureBox1, sNote)
        If DoOriginalImage Then
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
            AutoSizeToolStripMenuItem.Checked = True
            StretchToolStripMenuItem.Checked = False
        Else
            'LoadViewSize()
            Dim objVS As New ViewSizeSettings
            objVS.LoadViewViewPicture(Me.Height, Me.Width, Me.Location)
            objVS = Nothing
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            StretchToolStripMenuItem.Checked = True
            AutoSizeToolStripMenuItem.Checked = False
        End If
        Call DoInitPicDrawing()
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub
    Private Sub frmViewPicture_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Height <> 0 Then Call DoResize()
    End Sub
#End Region
#Region "Sub and Functions"
    Public Sub GetPictureInfo(ByVal PID As Long, ByRef sName As String, ByRef sNotes As String)
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT pd_name,pd_note from Gun_Collection_Pictures where ID=" & MyID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            sName = ""
            sNotes = "N/A"
            While RS.Read()
                If Not IsDBNull(RS("pd_name")) Then sName = RS("pd_name")
                If Not IsDBNull(RS("pd_note")) Then sNotes = RS("pd_note")
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "GetPictureInfo"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try

    End Sub
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
    Sub GetPicture()
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT PICTURE from Gun_Collection_Pictures where ID=" & MyID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim b() As Byte = CMD.ExecuteScalar
            If (b.Length > 0) Then
                Dim stream As New MemoryStream(b, True)
                stream.Write(b, 0, b.Length)
                Dim bmp As Image = New Bitmap(stream)
                If AutoSizeToolStripMenuItem.Checked Then
                    Dim Workspace As Double = Me.MdiParent.Size.Width - MDIParent1.Panel1.Size.Width
                    If bmp.Size.Width > Workspace Then
                        Dim ImgSize As New Size
                        ImgSize = ProportionalSize(bmp.Size, PictureBox1.Size)
                        Dim newimg As New Bitmap(ImgSize.Width, ImgSize.Height)
                        Dim g As Graphics
                        g = Graphics.FromImage(newimg)
                        g.DrawImage(bmp, 0, 0, ImgSize.Width, ImgSize.Height)
                        PictureBox1.Image = newimg
                    Else
                        PictureBox1.Size = bmp.Size
                        PictureBox1.Image = bmp
                    End If
                Else
                    PictureBox1.Size = bmp.Size
                    PictureBox1.Image = bmp
                End If
                PictureBox1.Refresh()
                Me.Refresh()
                stream.Close()
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "GetPicture"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub DoInitPicDrawing()
        If AutoSizeToolStripMenuItem.Checked Then
            HasInit = True
            Me.WindowState = FormWindowState.Maximized
            Call DoResize()
            HasInit = False
            Call GetPicture()
            Me.WindowState = FormWindowState.Normal
            PictureBox1.Height = PictureBox1.Image.Height
            Me.Height = PictureBox1.Height + 28
            PictureBox1.Width = PictureBox1.Image.Width
            Me.Width = PictureBox1.Width + 10
            HasInit = True
        Else
            HasInit = True
            Call GetPicture()
            Call DoResize()
        End If
    End Sub
    Sub DoResize()
        If HasInit Then
            'If Not AutoSizeToolStripMenuItem.Checked Then
            PictureBox1.Height = Me.Height - 8
            PictureBox1.Width = Me.Width - 10
        End If
    End Sub
#End Region

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ToolTip1.Show(sNote, PictureBox1)
    End Sub

    Private Sub EditDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDetailsToolStripMenuItem.Click
        frmEditPicturedetails.MdiParent = Me.MdiParent
        frmEditPicturedetails.PID = MyID
        frmEditPicturedetails.Show()
        Me.Close()
    End Sub
End Class