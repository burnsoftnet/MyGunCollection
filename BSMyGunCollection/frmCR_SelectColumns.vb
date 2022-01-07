Imports BurnSoft.Applications.MGC.Types
''' <summary>
''' Class frmCR_SelectColumns.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmCrSelectColumns
    Dim _errOut as String
    ''' <summary>
    ''' The table name
    ''' </summary>
    Public TableName As String
    ''' <summary>
    ''' The table identifier
    ''' </summary>
    Public TableId As Long
    ''' <summary>
    ''' The table real name
    ''' </summary>
    Public TableRealName As String

    ''' <summary>
    ''' Handles the Click event of the Button1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetData.Click
        Dim frmnew As New FrmCrViewReport
        If Len(txtSQL.Text) = 0 Then txtSQL.Text = GenerateSql()
        frmnew.Sql = txtSQL.Text
        frmnew.MdiParent = MdiParent
        frmnew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmCR_SelectColumns control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmCR_SelectColumns_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            dim myList as List(Of ColumnLists) = BurnSoft.Applications.MGC.Reports.ColumnList.GetList(DatabasePath, TableId, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            For Each o As ColumnLists In myList
                CheckedListBox1.Items.Add(o.DisplayName)
            Next
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Generates the SQL.
    ''' </summary>
    ''' <returns>System.String.</returns>
    Function GenerateSql() As String
        Dim sAns As String = ""
        Try
            Dim strColumn As String 
            Dim displayName As String 
            sAns = "SELECT "
            Dim i As Integer
            For i = 0 To CheckedListBox1.CheckedItems.Count - 1
                displayName = CheckedListBox1.CheckedItems(i)
                strColumn = BurnSoft.Applications.MGC.Reports.ColumnList.GetColumnName(DatabasePath, TableId, displayName, _errOut)
                If _errOut.Length > 0 Then Throw New Exception(_errOut)
                If i = 0 Then
                    If displayName = strColumn Then
                        sAns &= strColumn & " "
                    Else
                        sAns &= strColumn & " as [" & displayName & "] "
                    End If
                Else
                    If displayName = strColumn Then
                        sAns &= "," & strColumn & " "
                    Else
                        sAns &= "," & strColumn & " as [" & displayName & "] "
                    End If
                End If
            Next i
            If i = 0 Then sAns &= "* "
            sAns &= " from " & TableRealName
        Catch ex As Exception
            Call LogError(Name, "GenerateSQL", Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    ''' <summary>
    ''' Handles the Click event of the btnGSQL control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnGSQL_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGSQL.Click
        txtSQL.Text = GenerateSql()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnHideSQL control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnHideSQL_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHideSQL.Click
        Height = 191
        Width = 303
        btnShowSQL.Visible = True
        btnHideSQL.Visible = False
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnShowSQL control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnShowSQL_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowSQL.Click
        btnHideSQL.Visible = True
        btnShowSQL.Visible = False
        Height = 355
        Width = 428
    End Sub
End Class