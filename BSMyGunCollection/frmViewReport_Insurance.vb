Imports Microsoft.Reporting.WinForms
Public Class frmViewReport_Insurance
    'Sub DoResize()
    '    If Me.Height <> 0 Then
    '        Me.ReportViewer1.Height = Me.Height - (46 + 15) 'org 46
    '        Me.ReportViewer1.Width = Me.Width - 5
    '    End If
    'End Sub
    Private Sub frmViewReport_Insurance_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.qryGunCollectionDetailsTableAdapter.FillByInsuranceReport(Me.MGCDataSet.qryGunCollectionDetails)
            If PersonalMark Then
                Dim parmList As New List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Insurance Report for " & OwnerName))
                Me.ReportViewer1.LocalReport.SetParameters(parmList)
            End If
            Me.ReportViewer1.RefreshReport()
            '    Call DoResize()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmViewReport_Insurance_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        'Call DoResize()
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            qryGunCollectionDetailsBindingSource.ResetBindings(True)
            Select Case UCase(ToolStripComboBox1.SelectedItem.ToString)
                Case UCase("Custom Catalog No.")
                    Me.qryGunCollectionDetailsTableAdapter.FillByInsuranceReportsByCustomID(Me.MGCDataSet.qryGunCollectionDetails)
                Case "PRICE"
                    Me.qryGunCollectionDetailsTableAdapter.FillByInsuranceReportByPurchasedPrice(Me.MGCDataSet.qryGunCollectionDetails)
                Case "CAILBER"
                    Me.qryGunCollectionDetailsTableAdapter.FillByInsuranceReportsByCailber(Me.MGCDataSet.qryGunCollectionDetails)
                Case "TYPE"
                    Me.qryGunCollectionDetailsTableAdapter.FillByInsuranceReportsbyType(Me.MGCDataSet.qryGunCollectionDetails)
                Case Else
                    Me.qryGunCollectionDetailsTableAdapter.FillByInsuranceReport(Me.MGCDataSet.qryGunCollectionDetails)
            End Select
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripComboBox1_SelectedIndexChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class