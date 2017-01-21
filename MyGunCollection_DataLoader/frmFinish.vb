Public Class frmFinish

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub frmFinish_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblTitle.Text = Application.ProductName
        Me.Text = Application.ProductName
    End Sub
End Class