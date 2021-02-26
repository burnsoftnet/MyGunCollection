''' <summary>
''' Class frmForgotPassword.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
' ReSharper disable once InconsistentNaming
Public Class frmForgotPassword
    ''' <summary>
    ''' Handles the Load event of the frmForgotPassword control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmForgotPassword_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        lblPhrase.Text = UseMyForgotPhrase
        TopMost = True
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAnswer control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAnswer_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnswer.Click
        Dim strword As String = Trim(txtWord.Text)
' ReSharper disable once RedundantAssignment
        Dim sMsg As String = ""
        If strword = UseMyForgotWord Then
            sMsg = "Your password is " & UseMyPwd
            txtWord.Text = ""
            MsgBox(sMsg)
            frmLogin.TopMost = True
            Close()
        Else
            sMsg = "That is incorrect!"
            txtWord.Text = ""
            MsgBox(sMsg)
        End If
    End Sub
End Class