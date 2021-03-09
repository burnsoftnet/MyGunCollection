Imports Microsoft.Reporting.WinForms
Public Class FrmViewReport
    ''' <summary>
    ''' Handles the Load event of the frmViewReport control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            qryGunCollectionDetailsTableAdapter.FillBy_Default(MGCDataSet.qryGunCollectionDetails)
            If PersonalMark Then
                Dim parmList As New List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Quick Inventory List for " & OwnerName))
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
                Case LCase("Custom Catalog No.")
                    qryGunCollectionDetailsTableAdapter.FillBy_CustomID(MGCDataSet.qryGunCollectionDetails)
                Case LCase("Manufacturer")
                    qryGunCollectionDetailsTableAdapter.FillBy_Default(MGCDataSet.qryGunCollectionDetails)
                Case LCase("Type")
                    qryGunCollectionDetailsTableAdapter.FillBy_Type(MGCDataSet.qryGunCollectionDetails)
                Case LCase("Caliber")
                    qryGunCollectionDetailsTableAdapter.FillBy_Caliber(MGCDataSet.qryGunCollectionDetails)
                Case Else
                    qryGunCollectionDetailsTableAdapter.FillBy_Default(MGCDataSet.qryGunCollectionDetails)
            End Select
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripComboBox1_SelectedIndexChanged"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class