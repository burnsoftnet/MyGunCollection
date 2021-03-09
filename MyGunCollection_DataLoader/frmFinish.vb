Public Class frmFinish
    'exit when canceled button is clicked
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        End
    End Sub
    'when sub loads
    Private Sub frmFinish_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        lblTitle.Text = Application.ProductName
        Me.Text = Application.ProductName
    End Sub
End Class