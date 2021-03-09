Public Class frmLogin
    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK.Click
        Dim strUID As String = LCase(UsernameTextBox.Text)
        Dim strPWD As String = LCase(PasswordTextBox.Text)
        If strUID = LCase(UseMyUid) Then
            If strPWD = LCase(UseMyPwd) Then
                IsLoggedIn = True
                MDIParent1.Show()
                Me.Close()
            Else
                MsgBox("Incorrect Username/Password", MsgBoxStyle.Critical, Me.Text)
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
            End If
        Else
            MsgBox("Incorrect Username/Password", MsgBoxStyle.Critical, Me.Text)
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub Label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.Click
        Me.TopMost = False
        frmForgotPassword.Show()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        MDIParent1.Hide()
    End Sub
End Class
