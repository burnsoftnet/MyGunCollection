Imports Microsoft.Reporting.WinForms
''' <summary>
''' Class frmViewReport_Maintenance.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewReportMaintenance
    ''' <summary>
    ''' My gid
    ''' </summary>
    Public MyGid As String
    ''' <summary>
    ''' The title
    ''' </summary>
    Public Title As String
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_Maintenance control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_Maintenance_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            gryGunMaintanceTableAdapter.FillBy(MGCDataSet.gryGunMaintance, MyGid)
            If PersonalMark Then
                Dim parmList As New List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Maintenance Report for " & Title))
                parmList.Add(New ReportParameter("Firearm", Title))
                ReportViewer1.LocalReport.SetParameters(parmList)
            End If
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
            If Len(MyGid) > 0 Then
                Select Case LCase(UCase(ToolStripComboBox1.SelectedItem.ToString))
                    Case LCase("Operation Performed")
                        gryGunMaintanceTableAdapter.FillByOperation(MGCDataSet.gryGunMaintance, MyGid)
                    Case LCase("Operation Date")
                        gryGunMaintanceTableAdapter.FillByOpDate(MGCDataSet.gryGunMaintance, MyGid)
                    Case LCase("Operation Due Date")
                        gryGunMaintanceTableAdapter.FillByOpDueDate(MGCDataSet.gryGunMaintance, MyGid)
                    Case LCase("Rounds Fired")
                        gryGunMaintanceTableAdapter.FillByRndFired(MGCDataSet.gryGunMaintance, MyGid)
                    Case Else
                        gryGunMaintanceTableAdapter.FillBy(MGCDataSet.gryGunMaintance, MyGid)
                End Select
                ReportViewer1.RefreshReport()
            End If
        Catch ex As Exception
            Call LogError(Name, "ToolStripComboBox1_SelectedIndexChanged", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class