Imports Microsoft.Reporting.WinForms
''' <summary>
''' Class frmViewReport_GunSmith.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmViewReport_GunSmith
    ''' <summary>
    ''' The gun id
    ''' </summary>
    Public Gid As String
    ''' <summary>
    ''' The title
    ''' </summary>
    Public Title As String
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_GunSmith control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_GunSmith_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            qryGunSmithDetailsTableAdapter.FillBy(MGCDataSet.qryGunSmithDetails, Gid)
            If PersonalMark Then
                Dim parmList As New List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Gun Smith Details for " & Title))
                parmList.Add(New ReportParameter("Firearm", Title))
                ReportViewer1.LocalReport.SetParameters(parmList)
            End If
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the SelectedIndexChanged event of the ToolStripComboBox1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            If Len(Gid) > 0 Then
                Select Case LCase(UCase(ToolStripComboBox1.SelectedItem.ToString))
                    Case LCase("Gun Smith")
                        qryGunSmithDetailsTableAdapter.FillByGunSmith(MGCDataSet.qryGunSmithDetails, Gid)
                    Case LCase("Ship Date")
                        qryGunSmithDetailsTableAdapter.FillByShipDate(MGCDataSet.qryGunSmithDetails, Gid)
                    Case LCase("Receive Date")
                        qryGunSmithDetailsTableAdapter.FillByRecDate(MGCDataSet.qryGunSmithDetails, Gid)
                    Case Else
                        qryGunSmithDetailsTableAdapter.FillBy(MGCDataSet.qryGunSmithDetails, Gid)
                End Select
                ReportViewer1.RefreshReport()
            End If
        Catch ex As Exception
            Call LogError(Name, "ToolStripComboBox1_SelectedIndexChanged", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class