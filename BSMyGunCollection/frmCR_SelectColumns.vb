Imports System.Data.Odbc
Imports BSMyGunCollection.MGC
''' <summary>
''' Class frmCR_SelectColumns.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmCR_SelectColumns
    ''' <summary>
    ''' The table name
    ''' </summary>
    Public TableName As String
    ''' <summary>
    ''' The table identifier
    ''' </summary>
    Public TableID As Long
    ''' <summary>
    ''' The table real name
    ''' </summary>
    Public TableRealName As String
    ''' <summary>
    ''' Gets the name of the column.
    ''' </summary>
    ''' <param name="DN">The dn.</param>
    ''' <returns>System.String.</returns>
    Function GetColumnName(ByVal DN As String) As String
        Dim sAns As String = ""
        Try
            Dim Obj As New BSDatabase
            Dim SQL As String = "SELECT col from CR_ColumnList where tid=" & TableID & " and DN='" & DN & "'"
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                sAns = RS("col")
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GetColumnName"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    ''' <summary>
    ''' Handles the Click event of the Button1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        Dim frmnew As New frmCR_ViewReport
        If Len(txtSQL.Text) = 0 Then txtSQL.Text = GenerateSQL()
        frmnew.SQL = txtSQL.Text
        frmnew.MdiParent = Me.MdiParent
        frmnew.Show()
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmCR_SelectColumns control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmCR_SelectColumns_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Obj As New BSDatabase
            Dim SQL As String = "Select * from CR_ColumnList where tid=" & TableID
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                CheckedListBox1.Items.Add(RS("DN"))
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Generates the SQL.
    ''' </summary>
    ''' <returns>System.String.</returns>
    Function GenerateSQL() As String
        Dim sAns As String = ""
        Try
            Dim strColumn As String = ""
            Dim DisplayName As String = ""
            sAns = "SELECT "
            Dim i As Integer = 0
            For i = 0 To CheckedListBox1.CheckedItems.Count - 1
                DisplayName = CheckedListBox1.CheckedItems(i)
                strColumn = GetColumnName(DisplayName)
                If i = 0 Then
                    If DisplayName = strColumn Then
                        sAns &= strColumn & " "
                    Else
                        sAns &= strColumn & " as [" & DisplayName & "] "
                    End If
                Else
                    If DisplayName = strColumn Then
                        sAns &= "," & strColumn & " "
                    Else
                        sAns &= "," & strColumn & " as [" & DisplayName & "] "
                    End If
                End If
            Next i
            If i = 0 Then sAns &= "* "
            sAns &= " from " & TableRealName
        Catch ex As Exception
            Dim sSubFunc As String = "GenerateSQL"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    ''' <summary>
    ''' Handles the Click event of the btnGSQL control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnGSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGSQL.Click
        txtSQL.Text = GenerateSQL()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnHideSQL control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnHideSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideSQL.Click
        Me.Height = 191
        Me.Width = 303
        btnShowSQL.Visible = True
        btnHideSQL.Visible = False
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnShowSQL control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnShowSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSQL.Click
        btnHideSQL.Visible = True
        btnShowSQL.Visible = False
        Me.Height = 355
        Me.Width = 428
    End Sub
End Class