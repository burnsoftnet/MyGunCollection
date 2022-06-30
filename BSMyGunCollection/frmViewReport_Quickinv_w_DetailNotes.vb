''' <summary>
''' View Quick Inventory Details with Notes Report
''' </summary>
Public Class frmViewReport_Quickinv_w_DetailNotes
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_Quickinv_w_DetailNotes control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_Quickinv_w_DetailNotes_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            FullDetailsTableAdapter.FillBy_QI_All(MGCDataSet.FullDetails)
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
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
                Case LCase("Manufacturer")
                    FullDetailsTableAdapter.FillBy_QI_Manufacturer(MGCDataSet.FullDetails)
                Case LCase("Type")
                    FullDetailsTableAdapter.FillBy_QI_Type(MGCDataSet.FullDetails)
                Case LCase("Caliber")
                    FullDetailsTableAdapter.FillBy_QI_Caliber(MGCDataSet.FullDetails)
                Case Else
                    FullDetailsTableAdapter.FillBy_QI_All(MGCDataSet.FullDetails)
            End Select
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Call LogError(Name, "ToolStripComboBox1_SelectedIndexChanged", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class