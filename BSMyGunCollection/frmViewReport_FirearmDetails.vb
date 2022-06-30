Imports Microsoft.Reporting.WinForms
''' <summary>
''' Class frmViewReport_FirearmDetails.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmViewReport_FirearmDetails
    ''' <summary>
    ''' The int identifier
    ''' </summary>
    Public IntId As String
    ''' <summary>
    ''' The string name
    ''' </summary>
    Public StrName As String
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_FirearmDetails control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_FirearmDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            FullDetailsTableAdapter.FillBy_ID(MGCDataSet.FullDetails, IntId)
            If PersonalMark Then
                Dim parmList As New List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Insurance Report for " & OwnerName))
                ReportViewer1.LocalReport.SetParameters(parmList)
            End If
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class