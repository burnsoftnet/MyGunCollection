Imports Microsoft.Reporting.WinForms
Public Class frmViewReport_Maintenance
    Public MyGID As String
    Public Title As String
    Private Sub frmViewReport_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.gryGunMaintanceTableAdapter.FillBy(Me.MGCDataSet.gryGunMaintance, MyGID)
            If PersonalMark Then
                Dim parmList As New Generic.List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Maintenance Report for " & Title))
                parmList.Add(New ReportParameter("Firearm", Title))
                Me.ReportViewer1.LocalReport.SetParameters(parmList)
            End If
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmViewReport_Maintenance_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        '   If Me.Height <> 0 Then
        ' Me.ReportViewer1.Height = Me.Height - (46 + 15)
        ' Me.ReportViewer1.Width = Me.Width - 5
        ' End If
    End Sub
    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            If Len(MyGID) > 0 Then
                Select Case LCase(UCase(ToolStripComboBox1.SelectedItem.ToString))
                    Case LCase("Operation Performed")
                        Me.gryGunMaintanceTableAdapter.FillByOperation(Me.MGCDataSet.gryGunMaintance, MyGID)
                    Case LCase("Operation Date")
                        Me.gryGunMaintanceTableAdapter.FillByOpDate(Me.MGCDataSet.gryGunMaintance, MyGID)
                    Case LCase("Operation Due Date")
                        Me.gryGunMaintanceTableAdapter.FillByOpDueDate(Me.MGCDataSet.gryGunMaintance, MyGID)
                    Case LCase("Rounds Fired")
                        Me.gryGunMaintanceTableAdapter.FillByRndFired(Me.MGCDataSet.gryGunMaintance, MyGID)
                    Case Else
                        Me.gryGunMaintanceTableAdapter.FillBy(Me.MGCDataSet.gryGunMaintance, MyGID)
                End Select
                Me.ReportViewer1.RefreshReport()
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripComboBox1_SelectedIndexChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class