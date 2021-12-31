Imports Microsoft.Reporting.WinForms
''' <summary>
''' Class FrmViewReportFirearmDetailsFullDetails.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewReportFirearmDetailsFullDetails
    ''' <summary>
    ''' The int identifier
    ''' </summary>
    Public IntId As String
    ''' <summary>
    ''' The string name
    ''' </summary>
    Public StrName As String
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_FirearmDetailsFullDetails control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_FirearmDetailsFullDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try

            qryGunSmithDetailsTableAdapter.FillBy(MGCDataSet.qryGunSmithDetails, IntId)
            FullDetailsTableAdapter.FillBy_ID(MGCDataSet.FullDetails, IntId)
            gryGunMaintanceTableAdapter.FillBy(MGCDataSet.gryGunMaintance, IntId)
            Gun_Collection_AccessoriesTableAdapter.FillBy(MGCDataSet.Gun_Collection_Accessories, IntId)
            Gun_Collection_ExtTableAdapter.FillBy_GID(MGCDataSet.Gun_Collection_Ext, IntId)
            If PersonalMark Then
                Dim parmList As New List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Insurance Report for " & OwnerName))
                ReportViewer1.LocalReport.SetParameters(parmList)
            End If
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Call LogError(Name,  "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class