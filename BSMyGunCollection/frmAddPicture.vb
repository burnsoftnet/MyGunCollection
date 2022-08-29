Imports BurnSoft.Applications.MGC.Firearms
''' <summary>
''' Class frmAddPicture.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddPicture
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemId As String
    ''' <summary>
    ''' Handles the Click event of the btnBrowse control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowse.Click
        Try
            OpenFileDialog1.FilterIndex = 3
            OpenFileDialog1.Filter = Pictures.FileFilterList
            If OpenFileDialog1.ShowDialog() <> DialogResult.Cancel Then PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception
            Call LogError(Name, "btnBrowse.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            If Len(OpenFileDialog1.FileName) = 0 Then
                MsgBox("You need to select a picture!")
                Exit Sub
            End If
            Enabled = False
            Cursor = Cursors.WaitCursor

            Dim sName As String = FluffContent(txtName.Text, " ")
            Dim sNotes As String = FluffContent(txtNotes.Text, " ")
            Dim errOut As String = ""
            If Not Pictures.Save(DatabasePath,OpenFileDialog1.FileName,ApplicationPathData,Convert.ToInt32(ItemId),sName, sNotes, errOut) Then Throw New Exception(errOut)
            
            Cursor = Cursors.Arrow
            Enabled = True
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Select Case Err.Number
                Case 5
                    MsgBox("You are currently out of memory!" & Chr(13) & " Please close some programs to free up memory")
                    Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
                Case Else
                    Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
            End Select
        End Try
        Cursor = Cursors.Arrow
        Enabled = True
    End Sub
End Class