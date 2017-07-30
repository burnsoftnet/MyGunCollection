Public Class frmMain
    'when for loads
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call in the init in the modPublic File
        Call INIT()
        lblTitle.Text = Application.ProductName
        Me.Text = Application.ProductName
        lblWelcomeMsg.Text = " Welcome to the " & Application.ProductName & ".  " & My.Application.Info.Description
    End Sub
    'when next button is click, go to next screen
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        frmSelectUpdates.Show()
        Me.Close()
    End Sub
    'exit when the cancel button is clicked
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub
End Class
