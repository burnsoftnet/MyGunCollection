Public Class frmForgotPassword

    Private Sub frmForgotPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblPhrase.Text = UseMyForgotPhrase
        Me.TopMost = True
    End Sub

    Private Sub btnAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer.Click
        'Dim strword As String = LCase(Trim(txtWord.Text))
        Dim strword As String = Trim(txtWord.Text)
        Dim sMsg As String = ""
        If strword = UseMyForgotWord Then
            sMsg = "Your password is " & UseMyPWD
            txtWord.Text = ""
            MsgBox(sMsg)
            frmLogin.TopMost = True
            Me.Close()
        Else
            sMsg = "That is incorrect!"
            txtWord.Text = ""
            MsgBox(sMsg)
        End If
    End Sub
End Class