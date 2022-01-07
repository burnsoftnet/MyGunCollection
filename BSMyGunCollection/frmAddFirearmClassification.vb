Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.Global

''' <summary>
''' Class frmAddFirearmClassification.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddFirearmClassification
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim errOut as String = ""
            Dim strClass As String = FluffContent(txtClass.Text)
            If Not Helpers.IsRequired(strClass, "Classification Type", Text, errOut) Then Exit Sub
            If Not Classification.Exists(DatabasePath, strClass, errOut) Then
                If Not Classification.Add(DatabasePath, strClass, errOut) Then Throw New Exception(errOut)
                Else 
                    MsgBox(strClass & " already existed in the database!", MsgBoxStyle.Critical, Text)
                    txtClass.Text = ""
            End If
        Catch ex As Exception
            Call LogError(Name, "btnAdd.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class