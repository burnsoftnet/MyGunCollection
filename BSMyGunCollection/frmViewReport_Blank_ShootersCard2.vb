''' <summary>
''' Report for the Blank Shooters Card report to print out
''' </summary>
Public Class frmViewReport_Blank_ShootersCard2
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_Blank_ShootersCard2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_Blank_ShootersCard2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ReportViewer1.RefreshReport()
    End Sub
End Class