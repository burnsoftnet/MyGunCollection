Imports Microsoft.Reporting.WinForms
Public Class frmViewReport_Ammo_By_Caliber
    Public CAL As String
    Public PET As String
    Public BySorting As String
    Private Sub frmViewReport_Ammo_By_Caliber_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim Report_Title As String = "Ammunition Inventory Report for " & CAL
            Dim Report_UserName As String = "N/A"
            If PersonalMark Then Report_UserName = OwnerName
            If Len(PET) > 0 Then Report_Title &= " & " & PET
            Me.Text = Report_Title
            If Len(PET) = 0 Then
                Me.Gun_Collection_AmmoTableAdapter.FillBy(Me.MGCDataSet.Gun_Collection_Ammo, CAL)
            Else
                Me.Gun_Collection_AmmoTableAdapter.FillByCal_wPet(Me.MGCDataSet.Gun_Collection_Ammo, CAL, PET)
            End If

            Dim parmList As New List(Of ReportParameter)
            parmList.Add(New ReportParameter("UserName", Report_UserName))
            parmList.Add(New ReportParameter("ReportTitle", Report_Title))
            Me.ReportViewer1.LocalReport.SetParameters(parmList)
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
                    If Len(PET) = 0 Then
                        Me.Gun_Collection_AmmoTableAdapter.FillByCal_OrderByManName(Me.MGCDataSet.Gun_Collection_Ammo, CAL)
                    Else
                        Me.Gun_Collection_AmmoTableAdapter.FillByCal_wPet_OrderByManufacturer(Me.MGCDataSet.Gun_Collection_Ammo, CAL, PET)
                    End If
                Case LCase("Caliber")
                    If Len(PET) = 0 Then
                        Me.Gun_Collection_AmmoTableAdapter.FillByCal_OrderByCaliber(Me.MGCDataSet.Gun_Collection_Ammo, CAL)
                    Else
                        Me.Gun_Collection_AmmoTableAdapter.FillByCal_wPet_OrderByCal(Me.MGCDataSet.Gun_Collection_Ammo, CAL, PET)
                    End If
                Case LCase("Grains")
                    If Len(PET) = 0 Then
                        Me.Gun_Collection_AmmoTableAdapter.FillByCal_OrderByGrain(Me.MGCDataSet.Gun_Collection_Ammo, CAL)
                    Else
                        Me.Gun_Collection_AmmoTableAdapter.FillByCal_wPet_OrderByGrains(Me.MGCDataSet.Gun_Collection_Ammo, CAL, PET)
                    End If
                Case LCase("Qty.")
                    If Len(PET) = 0 Then
                        Me.Gun_Collection_AmmoTableAdapter.FillByCal_OrderByQty(Me.MGCDataSet.Gun_Collection_Ammo, CAL)
                    Else
                        Me.Gun_Collection_AmmoTableAdapter.FillByCal_wPet_OrderByQty(Me.MGCDataSet.Gun_Collection_Ammo, CAL, PET)
                    End If
                Case Else
                    If Len(PET) = 0 Then
                        Me.Gun_Collection_AmmoTableAdapter.FillBy(Me.MGCDataSet.Gun_Collection_Ammo, CAL)
                    Else
                        Me.Gun_Collection_AmmoTableAdapter.FillByCal_wPet(Me.MGCDataSet.Gun_Collection_Ammo, CAL, PET)
                    End If
            End Select
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripComboBox1_SelectedIndexChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class