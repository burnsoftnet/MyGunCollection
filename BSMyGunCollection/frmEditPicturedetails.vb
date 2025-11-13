Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class frmEditPicturedetails.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmEditPicturedetails
    ''' <summary>
    ''' The picture id
    ''' </summary>
    Public Pid As Long
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim lst As List(Of PictureDetails) = BurnSoft.Applications.MGC.Firearms.Pictures.GetList(DatabasePath, Pid, _errOut, false, true)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            For Each l As PictureDetails In lst
                txtName.Text = l.PictureDisplayName
                txtNotes.Text = l.PictureNotes
            Next
        Catch ex As Exception
            Call LogError(Name, "LoadData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnUpdate control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Try
            Dim sTitle As String = FluffContent(txtName.Text)
            Dim sNotes As String = FluffContent(txtNotes.Text)
            If Not BurnSoft.Applications.MGC.Firearms.Pictures.UpdatePictureDetails(DatabasePath, Pid, sTitle, sNotes, _errOut) Then Throw New Exception(_errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
        Catch ex As Exception
            Call LogError(Name, "btnUpdate.Click", Err.Number, ex.Message.ToString)
        End Try
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmEditPicturedetails control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditPicturedetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Call LoadData()
    End Sub
End Class