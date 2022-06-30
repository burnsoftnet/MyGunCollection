''' <summary>
''' For Sale Form, to mark a fire arm as for sale
''' </summary>
Public Class frmForSale
    ''' <summary>
    ''' My identifier
    ''' </summary>
    Public MyId As String
    ''' <summary>
    ''' Handles the Load event of the frmForSale control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmForSale_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ForSaleDataTableAdapter.FillBy(MGCDataSet.ForSaleData, MyId)
        Owner_InfoTableAdapter.Fill(MGCDataSet.Owner_Info)
        ReportViewer1.RefreshReport()
    End Sub
End Class