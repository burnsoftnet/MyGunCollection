Imports Microsoft.Reporting.WinForms
Public Class frmViewReport_Pictures
    Public MyGID As String
    Public Title As String
    Private Sub frmViewReport_Pictures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Gun_Collection_PicturesTableAdapter.FillBy_CID(Me.MGCDataSet.Gun_Collection_Pictures, MyGID)
            Me.Text = "Gallery List for " & Title
            If PersonalMark Then
                Dim parmList As New Generic.List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Gallery List for " & Title))
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