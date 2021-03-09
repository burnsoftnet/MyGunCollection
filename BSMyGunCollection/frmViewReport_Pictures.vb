Imports Microsoft.Reporting.WinForms
''' <summary>
''' Class FrmViewReportPictures.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewReportPictures
    ''' <summary>
    ''' My gun id
    ''' </summary>
    Public MyGid As String
    ''' <summary>
    ''' The title
    ''' </summary>
    Public Title As String
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_Pictures control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_Pictures_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Gun_Collection_PicturesTableAdapter.FillBy_CID(MGCDataSet.Gun_Collection_Pictures, MyGid)
            Text = $"Gallery List for " & Title
            If PersonalMark Then
                Dim parmList As New List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", "Gallery List for " & Title))
                parmList.Add(New ReportParameter("Firearm", Title))
                ReportViewer1.LocalReport.SetParameters(parmList)
            End If
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class