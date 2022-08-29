Imports Microsoft.Reporting.WinForms
''' <summary>
''' Class frmViewReport_Ammo.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
' ReSharper disable InconsistentNaming
Public Class frmViewReport_Ammo
' ReSharper restore InconsistentNaming
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_Ammo control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_Ammo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Gun_Collection_AmmoTableAdapter.Fill(MGCDataSet.Gun_Collection_Ammo)
            If PersonalMark Then
                Dim parmList As New List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Ammunition Inventory Report"))
                ReportViewer1.LocalReport.SetParameters(parmList)
            Else
                Dim parmList As New List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", "N/A"))
                parmList.Add(New ReportParameter("ReportTitle", "Ammunition Inventory Report"))
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
            Select Case LCase(UCase(ToolStripComboBox1.SelectedItem.ToString))
                Case LCase("Manufacturer")
                    Gun_Collection_AmmoTableAdapter.FillByOrderbyManName(MGCDataSet.Gun_Collection_Ammo)
                Case LCase("Caliber")
                    Gun_Collection_AmmoTableAdapter.FillByOrderByCal(MGCDataSet.Gun_Collection_Ammo)
                Case LCase("Grains")
                    Gun_Collection_AmmoTableAdapter.FillByOrderByGrains(MGCDataSet.Gun_Collection_Ammo)
                Case LCase("Qty.")
                    Gun_Collection_AmmoTableAdapter.FillByOrderByQty(MGCDataSet.Gun_Collection_Ammo)
                Case Else
                    Gun_Collection_AmmoTableAdapter.Fill(MGCDataSet.Gun_Collection_Ammo)
            End Select
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Call LogError(Name, "ToolStripComboBox1_SelectedIndexChanged", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class