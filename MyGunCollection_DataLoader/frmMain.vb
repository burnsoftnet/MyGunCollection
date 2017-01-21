Public Class frmMain

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTitle.Text = Application.ProductName
        Me.Text = Application.ProductName
        lblWelcomeMsg.Text = " Welcome to the " & Application.ProductName & ".  " & My.Application.Info.Description
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        frmSelectUpdates.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub
End Class
