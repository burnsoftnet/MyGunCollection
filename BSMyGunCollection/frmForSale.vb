Public Class frmForSale
    Public MyID As String
    Private Sub frmForSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ForSaleDataTableAdapter.FillBy(Me.MGCDataSet.ForSaleData, MyID)
        Me.Owner_InfoTableAdapter.Fill(Me.MGCDataSet.Owner_Info)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class