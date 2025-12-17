Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports Microsoft.Reporting.WinForms
''' <summary>
''' The Report Viewer for the General Collection
''' </summary>
Public Class frmView_Report_GeneralCollection
    '' <summary>
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
    Private Sub frmView_Report_GeneralCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _reportTitle = "General Accessories Report"
            Text = _reportTitle
            General_AccessoriesTableAdapter.FillBy(MGCDataSet.General_Accessories)
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class