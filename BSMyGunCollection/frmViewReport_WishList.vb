Imports Microsoft.Reporting.WinForms
''' <summary>
''' Class FrmViewReportWishList.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewReportWishList
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_WishList control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_WishList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        WishlistTableAdapter.Fill(MGCDataSet.Wishlist)

        Try
            If PersonalMark Then
                Dim parmList As New List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", OwnerName & " Wish List"))
                ReportViewer1.LocalReport.SetParameters(parmList)
            End If
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub


    ''' <summary>
    ''' Handles the SelectedIndexChanged event of the ToolStripComboBox1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            Select Case LCase(UCase(ToolStripComboBox1.SelectedItem.ToString))
                Case LCase("Place To Buy")
                    WishlistTableAdapter.FillByPlacetoBuy(MGCDataSet.Wishlist)
                Case LCase("Qty.")
                    WishlistTableAdapter.FillByQty(MGCDataSet.Wishlist)
                Case LCase("Manufacturer")
                    WishlistTableAdapter.FillByManufacturer(MGCDataSet.Wishlist)
                Case LCase("Value")
                    WishlistTableAdapter.FillByPrice(MGCDataSet.Wishlist)
                Case Else
                    WishlistTableAdapter.Fill(MGCDataSet.Wishlist)
            End Select
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripComboBox1_SelectedIndexChanged"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class