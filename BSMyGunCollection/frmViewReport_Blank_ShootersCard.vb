''' <summary>
''' Report for the other Blank Shooters card to print out
''' </summary>
Public Class FrmViewReportBlankShootersCard
    ''' <summary>
    ''' Handles the Load event of the frmReport_Blank_ShootersCard control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmReport_Blank_ShootersCard_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ReportViewer1.RefreshReport()
    End Sub
End Class