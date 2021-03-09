Imports Microsoft.Reporting.WinForms
''' <summary>
''' Class frmViewReport_Insurance_ApprisedValue.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewReportInsuranceApprisedValue
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_Insurance_ApprisedValue control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_Insurance_ApprisedValue_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            qryGunCollectionDetailsTableAdapter.FillByInsuranceReport_AppraisedValue(MGCDataSet.qryGunCollectionDetails)
            If PersonalMark Then
                Dim parmList As New List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Insurance Report for " & OwnerName))
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
            qryGunCollectionDetailsBindingSource.ResetBindings(True)
            Select Case UCase(ToolStripComboBox1.SelectedItem.ToString)
                Case UCase("Custom Catalog No.")
                    qryGunCollectionDetailsTableAdapter.FillByInsuranceReport_AppraisedValueByCustomID(MGCDataSet.qryGunCollectionDetails)
                Case "PRICE"
                    qryGunCollectionDetailsTableAdapter.FillByInsuranceReport_AppraisedValueByValue(MGCDataSet.qryGunCollectionDetails)
                Case "CAILBER"
                    qryGunCollectionDetailsTableAdapter.FillByInsuranceReport_AppraisedValueByCaliber(MGCDataSet.qryGunCollectionDetails)
                Case "TYPE"
                    qryGunCollectionDetailsTableAdapter.FillByInsuranceReport_AppraisedValueByType(MGCDataSet.qryGunCollectionDetails)
                Case Else
                    qryGunCollectionDetailsTableAdapter.Fill(MGCDataSet.qryGunCollectionDetails)
            End Select
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripComboBox1_SelectedIndexChanged"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class