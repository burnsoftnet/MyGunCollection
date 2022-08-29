Imports Microsoft.Reporting.WinForms
''' <summary>
''' Class frmViewReportAccessories.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmViewReport_Accessories
    ''' <summary>
    ''' The gun id
    ''' </summary>
    Public Gid As String
    ''' <summary>
    ''' The title
    ''' </summary>
    Public Title As String
    ''' <summary>
    ''' The report title
    ''' </summary>
    Dim _reportTitle As String
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_Accessories control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_Accessories_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try

            _reportTitle = "Accessories Report"
            Text = _reportTitle
            Gun_Collection_AccessoriesTableAdapter.FillBy(MGCDataSet.Gun_Collection_Accessories, Gid)
            If PersonalMark Then
                Dim parmList As New List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", _reportTitle & " for " & Title))
                parmList.Add(New ReportParameter("Firearm", Title))
                ReportViewer1.LocalReport.SetParameters(parmList)
            End If
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class