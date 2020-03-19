Imports Microsoft.Reporting.WinForms
Public Class frmViewReport_Accessories
    Public GID As String
    Public Title As String
    Dim ReportTitle As String
    Private Sub frmViewReport_Accessories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ReportTitle = "Accessories Report"
            Me.Text = ReportTitle
            Me.Gun_Collection_AccessoriesTableAdapter.FillBy(Me.MGCDataSet.Gun_Collection_Accessories, GID)
            If PersonalMark Then
                Dim parmList As New Generic.List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", ReportTitle & " for " & Title))
                parmList.Add(New ReportParameter("Firearm", Title))
                Me.ReportViewer1.LocalReport.SetParameters(parmList)
            End If
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class