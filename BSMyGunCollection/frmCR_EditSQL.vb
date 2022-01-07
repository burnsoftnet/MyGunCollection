Imports BurnSoft.Applications.MGC.Reports
Imports BurnSoft.Applications.MGC.Types
''' <summary>
''' Class frmCR_EditSQL.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmCrEditSql
    ''' <summary>
    ''' The rid
    ''' </summary>
    Public Rid As Long
    Dim _errOut as String
    ''' <summary>
    ''' Get the data from the database based on the report id
    ''' </summary>
    Sub LoadData()
        Try
            Dim lst As List(Of CustomReportsLists) = CustomReports.List(DatabasePath, Rid, _errOut)
            For Each o As CustomReportsLists In lst
                txtTitle.Text = o.ReportName
                txtSQL.Text = o.Sql
            Next
        Catch ex As Exception
            Call LogError(Name,  "LoadData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' when for first load
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmCR_EditSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Rid > 0 Then
            Call LoadData()
        Else
            Text = $"Add SQL for Custom Report"
        End If
    End Sub
    ''' <summary>
    ''' when the user is ready to view the results, they click on the view in report button and this will pass the sql statement to the viewer
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnViewInReport_Click(sender As Object, e As EventArgs) Handles btnViewInReport.Click
        Dim frmnew As New FrmCrViewReport
        frmnew.Sql = txtSQL.Text
        frmnew.MdiParent = MdiParent
        frmnew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnSave control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim reportName As String = FluffContent(txtTitle.Text)
            Dim mySql As String = FluffContent(txtSQL.Text)
            If Rid = 0 Then
                If Not CustomReports.Add(DatabasePath, reportName, mySql, _errOut) Then Throw New Exception(_errOut)
            Else
                If Not CustomReports.Update(DatabasePath, Rid, reportName, mySql, _errOut) Then Throw New Exception(_errOut)
            End If
            MsgBox("Report Was Saved!")
            Close()
        Catch ex As Exception
            Call LogError(Name, "btnSave_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class