Public Class frmLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
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

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.TopMost = False
        frmForgotPassword.Show()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MDIParent1.Hide()
    End Sub
End Class
