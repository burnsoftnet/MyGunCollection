Imports Microsoft.Reporting.WinForms
Public Class frmViewReport_Ammo
    Public BySorting As String
    Private Sub frmViewReport_Ammo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Gun_Collection_AmmoTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Ammo)
            If PersonalMark Then
                Dim parmList As New Generic.List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Ammunition Inventory Report"))
                Me.ReportViewer1.LocalReport.SetParameters(parmList)
            Else
                Dim parmList As New Generic.List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", "N/A"))
                parmList.Add(New ReportParameter("ReportTitle", "Ammunition Inventory Report"))
                Me.ReportViewer1.LocalReport.SetParameters(parmList)
            End If
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmViewReport_Ammo_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'If Me.Height <> 0 Then
        ' Me.ReportViewer1.Height = Me.Height - (46 + 15)
        ' Me.ReportViewer1.Width = Me.Width - 5
        'End If
    End Sub
    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            Select Case LCase(UCase(ToolStripComboBox1.SelectedItem.ToString))
                Case LCase("Manufacturer")
                    Me.Gun_Collection_AmmoTableAdapter.FillByOrderbyManName(Me.MGCDataSet.Gun_Collection_Ammo)
                Case LCase("Caliber")
                    Me.Gun_Collection_AmmoTableAdapter.FillByOrderByCal(Me.MGCDataSet.Gun_Collection_Ammo)
                Case LCase("Grains")
                    Me.Gun_Collection_AmmoTableAdapter.FillByOrderByGrains(Me.MGCDataSet.Gun_Collection_Ammo)
                Case LCase("Qty.")
                    Me.Gun_Collection_AmmoTableAdapter.FillByOrderByQty(Me.MGCDataSet.Gun_Collection_Ammo)
                Case Else
                    Me.Gun_Collection_AmmoTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Ammo)
            End Select
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripComboBox1_SelectedIndexChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class