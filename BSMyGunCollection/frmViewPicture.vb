Imports System.IO
Imports System.Data.Odbc
Imports System.Drawing.Imaging
Imports BSMyGunCollection.MGC
''' <summary>
''' Class FrmViewPicture.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewPicture
    ''' <summary>
    ''' My identifier
    ''' </summary>
    Public MyId As Long
    ''' <summary>
    ''' The group identifier
    ''' </summary>
    Public GroupId As Long
    ''' <summary>
    ''' The has initialize
    ''' </summary>
    Public HasInit As Boolean
    ''' <summary>
    ''' The s name
    ''' </summary>
    Public SName As String = ""
    ''' <summary>
    ''' The s note
    ''' </summary>
    Public SNote As String = ""
#Region "Menu Items"
    ''' <summary>
    ''' Handles the Click event of the CloseToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ExportPictureToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ExportPictureToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExportPictureToolStripMenuItem.Click
        Try
            SaveFileDialog1.FilterIndex = 3
            SaveFileDialog1.Filter = $"Bmp Files(*.bmp)|*.bmp|Gif Files(*.gif)|*.gif|Jpg Files(*.jpg)|*.jpg|Tiff Files(*.tiff)|*.tiff|WMF Files(*.wmf)|*.wmf"
            SaveFileDialog1.FileName = "PictureID_" & MyId '& ".jpg"
            SaveFileDialog1.Title = $"Export Image to File"
            If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
            Dim strFilePath As String = SaveFileDialog1.FileName
' ReSharper disable once RedundantAssignment
            Dim imgFormat As ImageFormat = ImageFormat.Jpeg
            Dim fs As FileStream = CType(SaveFileDialog1.OpenFile(), FileStream)
            Select Case SaveFileDialog1.FilterIndex
                Case 1
                    imgFormat = ImageFormat.Bmp
                Case 2
                    imgFormat = ImageFormat.Gif
                Case 3
                    imgFormat = ImageFormat.Jpeg
                Case 4
                    imgFormat = ImageFormat.Tiff
                Case 5
                    imgFormat = ImageFormat.Wmf
                Case Else
                    imgFormat = ImageFormat.Jpeg
            End Select
            Dim bmp As New Bitmap(PictureBox1.Image)
            bmp.Save(fs, imgFormat)
            bmp.Dispose()
            fs.Close()
            MsgBox("Picture was exported to " & strFilePath)
        Catch ex As Exception
            Call LogError(Name, "ExportPictureToolStripMenuItem.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ChangePictureToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ChangePictureToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ChangePictureToolStripMenuItem.Click
        Try
            Dim sqlu As String = "UPDATE Gun_Collection_Pictures set ISMAIN=0 where CID=" & GroupId
            Dim sql As String = "UPDATE Gun_Collection_Pictures set ISMAIN=1 where ID=" & MyId
            Dim obj As New BsDatabase
            obj.ConnExec(sqlu)
            obj.ConnExec(sql)
            MsgBox("This is now the Default Picture")
        Catch ex As Exception
            Call LogError(Name, "ChangePictureToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the AutoSizeToolStripMenuItem control. stretch the windows to the original size of the picture
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub AutoSizeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AutoSizeToolStripMenuItem.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        AutoSizeToolStripMenuItem.Checked = True
        StretchToolStripMenuItem.Checked = False
        Call DoInitPicDrawing()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the StretchToolStripMenuItem control. stretch the image to the size of the active window
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub StretchToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StretchToolStripMenuItem.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        StretchToolStripMenuItem.Checked = True
        AutoSizeToolStripMenuItem.Checked = False
        Call DoResize()
    End Sub
#End Region
#Region "Form Items"
    ''' <summary>
    ''' Handles the Leave event of the frmViewPicture control. When the form closes, save location ending
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewPicture_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Leave
        PictureBox1.Dispose()

        If Not DoOriginalImage Then
            Dim objVs As New ViewSizeSettings
            objVs.SaveViewPicture(Height, Width, Location.X, Location.Y)
        End If
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewPicture control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewPicture_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Call GetPictureInfo(MyId, SName, SNote)
        If Len(SName) = 0 Then SName = "PictureID_" & MyId

        Text = $"View Picture - " & SName
        ToolTip1.ToolTipTitle = SName
        ToolTip1.SetToolTip(PictureBox1, SNote)
        If DoOriginalImage Then
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
            AutoSizeToolStripMenuItem.Checked = True
            StretchToolStripMenuItem.Checked = False
        Else
            Dim objVs As New ViewSizeSettings
            objVs.LoadViewViewPicture(Height, Width, Location)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            StretchToolStripMenuItem.Checked = True
            AutoSizeToolStripMenuItem.Checked = False
        End If
        Call DoInitPicDrawing()
        StartPosition = FormStartPosition.CenterParent
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmViewPicture control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewPicture_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        If Height <> 0 Then Call DoResize()
    End Sub
#End Region
#Region "Sub and Functions"
    ''' <summary>
    ''' Gets the picture information.
    ''' </summary>
    ''' <param name="pid">The pid.</param>
    ''' <param name="sName">Name of the s.</param>
    ''' <param name="sNotes">The s notes.</param>
' ReSharper disable once ParameterHidesMember
    Public Sub GetPictureInfo(ByVal pid As Long, ByRef sName As String, ByRef sNotes As String)
        Try
            '' TODO: #50 Convert this function to use on from the updated library: BurnSoft.Applications.MGC.Firearms.Pictures.GetList
            Dim obj As New BsDatabase
            Call obj.ConnectDb()
            Dim sql As String = "SELECT pd_name,pd_note from Gun_Collection_Pictures where ID=" & MyId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            sName = ""
            sNotes = "N/A"
            While rs.Read()
                If Not IsDBNull(rs("pd_name")) Then sName = rs("pd_name")
                If Not IsDBNull(rs("pd_note")) Then sNotes = rs("pd_note")
            End While
            rs.Close()

        Catch ex As Exception
            Call LogError(Name, "GetPictureInfo", Err.Number, ex.Message.ToString)
        End Try

    End Sub
    ''' <summary>
    ''' Proportionals the size.
    ''' </summary>
    ''' <param name="imageSize">Size of the image.</param>
    ''' <param name="maxWMaxH">The maximum w maximum h.</param>
    ''' <returns>Size.</returns>
    Public Function ProportionalSize(ByVal imageSize As Size, ByVal maxWMaxH As Size) As Size
        Dim multBy As Double = 1.01
        Dim w As Double = imageSize.Width
        Dim h As Double = imageSize.Height

        While (w < maxWMaxH.Width And h < maxWMaxH.Height)
            w = imageSize.Width * multBy
            h = imageSize.Height * multBy
            multBy = multBy + 0.001
        End While

        While (w > maxWMaxH.Width Or h > maxWMaxH.Height)
            multBy = multBy - 0.001
            w = imageSize.Width * multBy
            h = imageSize.Height * multBy
        End While

        If (imageSize.Width < 1) Then
            ' ReSharper disable RedundantAssignment
            imageSize = New Size(imageSize.Width - imageSize.Width + 1, imageSize.Height - imageSize.Width - 1)
        ElseIf (imageSize.Height < 1) Then
            imageSize = New Size(imageSize.Width - imageSize.Height - 1, imageSize.Height - imageSize.Height + 1)
' ReSharper restore RedundantAssignment
        End If
        imageSize = New Size(Convert.ToInt32(w), Convert.ToInt32(h))
        Return imageSize
    End Function
    ''' <summary>
    ''' Gets the picture.
    ''' </summary>
    Sub GetPicture()
        Try
            Dim obj As New BsDatabase
            Call obj.ConnectDb()
            Dim sql As String = "SELECT PICTURE from Gun_Collection_Pictures where ID=" & MyId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim b() As Byte = cmd.ExecuteScalar
            If (b.Length > 0) Then
                Dim stream As New MemoryStream(b, True)
                stream.Write(b, 0, b.Length)
                Dim bmp As Image = New Bitmap(stream)
                If AutoSizeToolStripMenuItem.Checked Then
                    Dim workspace As Double = MdiParent.Size.Width - MDIParent1.Panel1.Size.Width
                    If bmp.Size.Width > workspace Then
' ReSharper disable once RedundantAssignment
                        Dim imgSize As New Size
                        imgSize = ProportionalSize(bmp.Size, PictureBox1.Size)
                        Dim newimg As New Bitmap(imgSize.Width, imgSize.Height)
                        Dim g As Graphics
                        g = Graphics.FromImage(newimg)
                        g.DrawImage(bmp, 0, 0, imgSize.Width, imgSize.Height)
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
                Refresh()
                stream.Close()
            End If
        Catch ex As Exception
            Call LogError(Name, "GetPicture", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Does the initialize pic drawing.
    ''' </summary>
    Sub DoInitPicDrawing()
        If AutoSizeToolStripMenuItem.Checked Then
            HasInit = True
            WindowState = FormWindowState.Maximized
            Call DoResize()
            HasInit = False
            Call GetPicture()
            WindowState = FormWindowState.Normal
            PictureBox1.Height = PictureBox1.Image.Height
            Height = PictureBox1.Height + 28
            PictureBox1.Width = PictureBox1.Image.Width
            Width = PictureBox1.Width + 10
            HasInit = True
        Else
            HasInit = True
            Call GetPicture()
            Call DoResize()
        End If
    End Sub
    ''' <summary>
    ''' Does the resize.
    ''' </summary>
    Sub DoResize()
        If HasInit Then
            PictureBox1.Height = Height - 8
            PictureBox1.Width = Width - 10
        End If
    End Sub
#End Region
    ''' <summary>
    ''' Handles the Click event of the PictureBox1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox1.Click
        ToolTip1.Show(SNote, PictureBox1)
    End Sub
    ''' <summary>
    ''' Handles the Click event of the EditDetailsToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub EditDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditDetailsToolStripMenuItem.Click
        frmEditPicturedetails.MdiParent = MdiParent
        frmEditPicturedetails.Pid = MyId
        frmEditPicturedetails.Show()
        Close()
    End Sub
End Class