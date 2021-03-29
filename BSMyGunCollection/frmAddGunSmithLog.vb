Imports BSMyGunCollection.MGC
Imports System.Data.Odbc

''' <summary>
''' Class frmAddGunSmithLog.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddGunSmithLog
    ''' <summary>
    ''' The gun id
    ''' </summary>
    Public Gid As String
    ''' <summary>
    ''' The error out
    ''' </summary>
    Private errOut As String
    ''' <summary>
    ''' Handles the Load event of the frmAddGunSmithLog control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddGunSmithLog_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            'Dim objAf As New AutoFillCollections
            'txtGS.AutoCompleteCustomSource = objAf.GunSmith_Name
            ''TODO #2 Convert Code
            txtGS.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.GunSmith.Name(DatabasePath, errOut)
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' check is a gun Smith the exists.
    ''' </summary>
    ''' <param name="strName">Name of the string.</param>
    ''' <param name="intCount">The int count.</param>
    ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    Private Function SmithExists(ByVal strName As String, Optional ByRef intCount As Integer = 0) As Boolean
        Dim bAns As Boolean = False
        Dim sql As String = "SELECT Count(*) as Total from GunSmith_Contact_Details where gname like '" & strName & "%'"
        Try
            intCount = 0
            Dim obj As New BSDatabase
            Call obj.ConnectDB()
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            If rs.HasRows Then
                While (rs.Read)
                    intCount = rs("Total")
                End While
            End If
            If intCount <> 0 Then bAns = True
            rs.Close()

            Call obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "SmithExists"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return bAns
    End Function
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim strSmith As String = FluffContent(txtGS.Text)
            Dim strShip As String = DateTimePicker1.Value
            Dim strReturn As String = DateTimePicker2.Value
            Dim strOd As String = FluffContent(txtOD.Text)
            Dim strNotes As String = FluffContent(txtNotes.Text)

            If Not IsRequired(strSmith, "Gun Smith Name", Text) Then Exit Sub
            If Not IsRequired(strOd, "Operation Details", Text) Then Exit Sub

            Dim obj As New BSDatabase
            Call obj.ConnectDB()
            If Not SmithExists(strSmith) Then
                Call obj.InsertNewContact(strSmith, "GunSmith_Contact_Details", "gName")
            End If
            Dim sql As String = "INSERT INTO GunSmith_Details(GID,gsmith,od,notes,sdate,rdate,sync_lastupdate) VALUES(" &
                                Gid & ",'" & strSmith & "','" & strOd & "','" & strNotes & "','" &
                                strShip & "','" & strReturn & "',Now())"
            obj.ConnExec(sql)
            MsgBox("Details where added to the Gun Smith Log", MsgBoxStyle.Information, Text)
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class