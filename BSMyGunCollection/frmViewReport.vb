Imports BSMyGunCollection.MGC
Imports Microsoft.Reporting.WinForms
Public Class frmViewReport

    Private Sub frmViewReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.qryGunCollectionDetailsTableAdapter.FillBy_Default(Me.MGCDataSet.qryGunCollectionDetails)
            If PersonalMark Then
                Dim parmList As New Generic.List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Quick Inventory List for " & OwnerName))
                Me.ReportViewer1.LocalReport.SetParameters(parmList)
            End If
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmViewReport_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'If Me.Height <> 0 Then
        ' Me.ReportViewer1.Height = Me.Height - (46 + 15)
        ' Me.ReportViewer1.Width = Me.Width - 5
        ' End If
    End Sub
    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            Select Case LCase(UCase(ToolStripComboBox1.SelectedItem.ToString))
                Case LCase("Custom Catalog No.")
                    Me.qryGunCollectionDetailsTableAdapter.FillBy_CustomID(Me.MGCDataSet.qryGunCollectionDetails)
                Case LCase("Manufacturer")
                    Me.qryGunCollectionDetailsTableAdapter.FillBy_Default(Me.MGCDataSet.qryGunCollectionDetails)
                Case LCase("Type")
                    Me.qryGunCollectionDetailsTableAdapter.FillBy_Type(Me.MGCDataSet.qryGunCollectionDetails)
                Case LCase("Caliber")
                    Me.qryGunCollectionDetailsTableAdapter.FillBy_Caliber(Me.MGCDataSet.qryGunCollectionDetails)
                Case Else
                    Me.qryGunCollectionDetailsTableAdapter.FillBy_Default(Me.MGCDataSet.qryGunCollectionDetails)
            End Select
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripComboBox1_SelectedIndexChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class