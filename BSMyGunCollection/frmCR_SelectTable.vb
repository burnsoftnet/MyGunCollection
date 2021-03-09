Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
''' <summary>
''' Class frmCR_SelectTable.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmCR_SelectTable
    ''' <summary>
    ''' Gets the name of the table.
    ''' </summary>
    ''' <param name="TID">The tid.</param>
    ''' <returns>System.String.</returns>
    Function GetTableName(ByVal TID As Long) As String
        Dim sAns As String = ""
        Try
            Dim Obj As New BSDatabase
            Dim SQL As String = "SELECT * from CR_TableList where id=" & TID
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                sAns = RS("Tables")
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GetTableName"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    ''' <summary>
    ''' Load the combo boxes from the datasets and resize the for if it does or doesn't have any saved reports.
    ''' </summary>
    Sub LoadData()
        Try
            Me.CR_SavedReportsTableAdapter.Fill(Me.MGCDataSet.CR_SavedReports)
            Me.CR_TableListTableAdapter.Fill(Me.MGCDataSet.CR_TableList)
            Dim ObjGF As New GlobalFunctions
            If ObjGF.ObjectExistsinDB("CR_SavedReports") Then
                Me.Height = 157
            Else
                Me.Height = 102
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' When form loads
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmCR_SelectTable_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnNext control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        Try
            Dim TID As Long = ComboBox1.SelectedValue
            Dim TName As String = ComboBox1.Text
            Dim frmNew As New frmCR_SelectColumns
            frmNew.TableID = TID
            frmNew.TableName = TName
            frmNew.TableRealName = GetTableName(TID)
            frmNew.MdiParent = Me.MdiParent
            frmNew.Show()
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnNext.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Load from the saved reports when the Load button is clicked
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnLoadSaved_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadSaved.Click
        Try
            Dim SRID As Long = ComboBox2.SelectedValue
            Dim ReportName As String = ComboBox2.Text
            Dim ObjGF As New GlobalFunctions
            Dim SQL As String = ObjGF.GetReportSQL(SRID)
            Dim frmnew As New frmCR_ViewReport
            frmnew.SQL = Replace(SQL, "''", "'")
            frmnew.ReportName = ReportName
            frmnew.MdiParent = Me.MdiParent
            frmnew.Show()
        Catch ex As Exception
            Dim sSubFunc As String = "btnLoadSaved.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' when the user right clicks on the Load button, this is one of the context menu
    ''' options that appears that allows the user to delete the custom report.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            Dim selectedName As String = ComboBox2.SelectedText
            Dim selectedValue As String = ComboBox2.SelectedValue
            Dim sAns As String = MsgBox("Are you sure you want to delete " & selectedName & " Report?", MsgBoxStyle.YesNo, "Delete Custom Report")
            If sAns = vbYes Then
                Dim SQL As String = "delete from CR_SavedReports where ID=" & selectedValue
                Dim Obj As New BSDatabase
                Obj.ConnExec(SQL)
                Obj = Nothing
                MsgBox("Report was deleted")
                Call LoadData()
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "DeleteToolStripMenuItem_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' when the user right clicks on the Load button, this is one of the context menu
    ''' options that appears that allows the user to edit the custom report.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Call editReport()
    End Sub
    ''' <summary>
    ''' Bring up the SQL editor window
    ''' </summary>
    Sub ShowSQLEditor()
        Dim frmNew As New frmCR_EditSQL
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
        Me.Close()
    End Sub
    ''' <summary>
    ''' when the user right clicks on the Next button, this is one of the context menu
    ''' options that appears that allows the user to edit the custom report.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Call ShowSQLEditor()
    End Sub
    ''' <summary>
    ''' options that appears that allows the user to edit the custom report.
    ''' </summary>
    Sub editReport()
        Dim RID As Long = ComboBox2.SelectedValue
        Dim frmNew As New frmCR_EditSQL
        frmNew.RID = RID
        frmNew.MdiParent = Me.MdiParent
        frmNew.Show()
        Me.Close()
    End Sub
    ''' <summary>
    ''' when the user clicks on the Edit button
    ''' options that appears that allows the user to edit the custom report.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call editReport()
    End Sub
    ''' <summary>
    ''' when the user click on the sql editor button
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnSQLEditor_Click(sender As Object, e As EventArgs) Handles btnSQLEditor.Click
        Call ShowSQLEditor()
    End Sub
End Class