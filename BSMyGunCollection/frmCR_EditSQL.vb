Imports BSMyGunCollection.MGC
Imports System.Data
Imports System.Data.Odbc
''TODO: Convert code from frmCR_EditSQL #12

''' <summary>
''' Class frmCR_EditSQL.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmCR_EditSQL
    ''' <summary>
    ''' The rid
    ''' </summary>
    Public RID As Long
    ''' <summary>
    ''' Get the data from the database based on the report id
    ''' </summary>
    Sub LoadData()
        Try
            Dim SQL As String = "select * from CR_SavedReports where id=" & RID
            Dim Obj As New BSDatabase
            Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                txtTitle.Text = RS("ReportName")
                txtSQL.Text = RS("MySQL")
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' when for first load
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmCR_EditSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RID > 0 Then
            Call LoadData()
        Else
            Me.Text = "Add SQL for Custom Report"
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
        frmnew.MdiParent = Me.MdiParent
        frmnew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnSave control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim Obj As New BSDatabase
            Dim ObjOF As New GlobalFunctions
            Dim ReportName As String = FluffContent(txtTitle.Text)
            Dim MySQL As String = FluffContent(txtSQL.Text)
            Dim SQL As String = ""
            If RID = 0 Then
                SQL = "INSERT INTO CR_SavedReports (ReportName,MySQL) VALUES('" & ReportName & "','" & MySQL & "')"
            Else
                SQL = "UPDATE CR_SavedReports set ReportName='" & ReportName & "',MySQL='" & MySQL & "' where ID=" & RID
            End If
            Obj.ConnExec(SQL)
            MsgBox("Report Was Saved!")
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnSave_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class