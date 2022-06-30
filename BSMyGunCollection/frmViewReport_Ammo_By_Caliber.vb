Imports Microsoft.Reporting.WinForms
''' <summary>
''' Class frmViewReportAmmoByCaliber.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmViewReport_Ammo_By_Caliber
    ''' <summary>
    ''' The calibler
    ''' </summary>
    Public Cal As String
    ''' <summary>
    ''' The pet load or second caliber
    ''' </summary>
    Public Pet As String
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_Ammo_By_Caliber control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_Ammo_By_Caliber_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim reportTitle As String = "Ammunition Inventory Report for " & Cal
            Dim reportUserName As String = "N/A"
            If PersonalMark Then reportUserName = OwnerName
            If Len(Pet) > 0 Then reportTitle &= " & " & Pet
            Text = reportTitle
            If Len(Pet) = 0 Then
                Gun_Collection_AmmoTableAdapter.FillBy(MGCDataSet.Gun_Collection_Ammo, Cal)
            Else
                Gun_Collection_AmmoTableAdapter.FillByCal_wPet(MGCDataSet.Gun_Collection_Ammo, Cal, Pet)
            End If

            Dim parmList As New List(Of ReportParameter)
            parmList.Add(New ReportParameter("UserName", reportUserName))
            parmList.Add(New ReportParameter("ReportTitle", reportTitle))
            ReportViewer1.LocalReport.SetParameters(parmList)
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
                    If Len(Pet) = 0 Then
                        Gun_Collection_AmmoTableAdapter.FillByCal_OrderByManName(MGCDataSet.Gun_Collection_Ammo, Cal)
                    Else
                        Gun_Collection_AmmoTableAdapter.FillByCal_wPet_OrderByManufacturer(MGCDataSet.Gun_Collection_Ammo, Cal, Pet)
                    End If
                Case LCase("Caliber")
                    If Len(Pet) = 0 Then
                        Gun_Collection_AmmoTableAdapter.FillByCal_OrderByCaliber(MGCDataSet.Gun_Collection_Ammo, Cal)
                    Else
                        Gun_Collection_AmmoTableAdapter.FillByCal_wPet_OrderByCal(MGCDataSet.Gun_Collection_Ammo, Cal, Pet)
                    End If
                Case LCase("Grains")
                    If Len(Pet) = 0 Then
                        Gun_Collection_AmmoTableAdapter.FillByCal_OrderByGrain(MGCDataSet.Gun_Collection_Ammo, Cal)
                    Else
                        Gun_Collection_AmmoTableAdapter.FillByCal_wPet_OrderByGrains(MGCDataSet.Gun_Collection_Ammo, Cal, Pet)
                    End If
                Case LCase("Qty.")
                    If Len(Pet) = 0 Then
                        Gun_Collection_AmmoTableAdapter.FillByCal_OrderByQty(MGCDataSet.Gun_Collection_Ammo, Cal)
                    Else
                        Gun_Collection_AmmoTableAdapter.FillByCal_wPet_OrderByQty(MGCDataSet.Gun_Collection_Ammo, Cal, Pet)
                    End If
                Case Else
                    If Len(Pet) = 0 Then
                        Gun_Collection_AmmoTableAdapter.FillBy(MGCDataSet.Gun_Collection_Ammo, Cal)
                    Else
                        Gun_Collection_AmmoTableAdapter.FillByCal_wPet(MGCDataSet.Gun_Collection_Ammo, Cal, Pet)
                    End If
            End Select
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Call LogError(Name, "ToolStripComboBox1_SelectedIndexChanged", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class