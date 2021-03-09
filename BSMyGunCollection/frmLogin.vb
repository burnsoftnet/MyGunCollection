''' <summary>
''' The Login form that is optional
''' </summary>
Public Class FrmLogin
    ''' <summary>
    ''' Handles the Click event of the OK control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK.Click
        Dim strUid As String = LCase(UsernameTextBox.Text)
        Dim strPwd As String = LCase(PasswordTextBox.Text)
        If strUid = LCase(UseMyUid) Then
            If strPwd = LCase(UseMyPwd) Then
                IsLoggedIn = True
                MDIParent1.Show()
                Close()
            Else
                MsgBox("Incorrect Username/Password", MsgBoxStyle.Critical, Text)
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
            End If
        Else
            MsgBox("Incorrect Username/Password", MsgBoxStyle.Critical, Text)
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
        End If
    End Sub
    ''' <summary>
    ''' Handles the Click event of the Cancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub Cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the Label1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub Label1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label1.Click
        TopMost = False
        frmForgotPassword.Show()
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmLogin control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        MDIParent1.Hide()
    End Sub
End Class
