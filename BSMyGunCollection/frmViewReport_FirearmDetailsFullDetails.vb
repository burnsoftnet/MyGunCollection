Imports Microsoft.Reporting.WinForms
Public Class frmViewReport_FirearmDetailsFullDetails
    Public intID As String
    Public strName As String
    Private Sub frmViewReport_FirearmDetailsFullDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.qryGunSmithDetailsTableAdapter.FillBy(Me.MGCDataSet.qryGunSmithDetails, intID)
            Me.FullDetailsTableAdapter.FillBy_ID(Me.MGCDataSet.FullDetails, intID)
            Me.gryGunMaintanceTableAdapter.FillBy(Me.MGCDataSet.gryGunMaintance, intID)
            Me.Gun_Collection_AccessoriesTableAdapter.FillBy(Me.MGCDataSet.Gun_Collection_Accessories, intID)
            Me.Gun_Collection_ExtTableAdapter.FillBy_GID(Me.MGCDataSet.Gun_Collection_Ext, intID)
            If PersonalMark Then
                Dim parmList As New Generic.List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Insurance Report for " & OwnerName))
                Me.ReportViewer1.LocalReport.SetParameters(parmList)
            End If
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class