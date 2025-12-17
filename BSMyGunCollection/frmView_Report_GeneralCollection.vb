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

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles General_Accessories_BindingSource.CurrentChanged

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.General_AccessoriesTableAdapter.FillBy(Me.MGCDataSet.General_Accessories)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class