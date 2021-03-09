Imports BSMyGunCollection.MGC
Imports Microsoft.Reporting.WinForms
Public Class frmViewReport_Quickinv_w_DetailNotes

    Private Sub frmViewReport_Quickinv_w_DetailNotes_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.FullDetailsTableAdapter.FillBy_QI_All(Me.MGCDataSet.FullDetails)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            Select Case LCase(UCase(ToolStripComboBox1.SelectedItem.ToString))
                Case LCase("Manufacturer")
                    Me.FullDetailsTableAdapter.FillBy_QI_Manufacturer(Me.MGCDataSet.FullDetails)
                Case LCase("Type")
                    Me.FullDetailsTableAdapter.FillBy_QI_Type(Me.MGCDataSet.FullDetails)
                Case LCase("Caliber")
                    Me.FullDetailsTableAdapter.FillBy_QI_Caliber(Me.MGCDataSet.FullDetails)
                Case Else
                    Me.FullDetailsTableAdapter.FillBy_QI_All(Me.MGCDataSet.FullDetails)
            End Select
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripComboBox1_SelectedIndexChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class