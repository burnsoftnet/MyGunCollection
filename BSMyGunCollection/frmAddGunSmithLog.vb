Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
''' <summary>
''' Class frmAddGunSmithLog.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddGunSmithLog
    ''' <summary>
    ''' The gun id
    ''' </summary>
    Public GID As String
    ''' <summary>
    ''' Handles the Load event of the frmAddGunSmithLog control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddGunSmithLog_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim ObjAF As New AutoFillCollections
            txtGS.AutoCompleteCustomSource = ObjAF.GunSmith_Name
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' check is a gun Smith the exists.
    ''' </summary>
    ''' <param name="strName">Name of the string.</param>
    ''' <param name="intCount">The int count.</param>
    ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    Private Function SmithExists(ByVal strName As String, Optional ByRef intCount As Integer = 0) As Boolean
        Dim bAns As Boolean = False
        Dim SQL As String = "SELECT Count(*) as Total from GunSmith_Contact_Details where gname like '" & strName & "%'"
        Try
            intCount = 0
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            If RS.HasRows Then
                While (RS.Read)
                    intCount = RS("Total")
                End While
            End If
            If intCount <> 0 Then bAns = True
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Call Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "SmithExists"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Dim strOD As String = FluffContent(txtOD.Text)
            Dim strNotes As String = FluffContent(txtNotes.Text)

            If Not IsRequired(strSmith, "Gun Smith Name", Me.Text) Then Exit Sub
            If Not IsRequired(strOD, "Operation Details", Me.Text) Then Exit Sub

            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            If Not SmithExists(strSmith) Then
                Call Obj.InsertNewContact(strSmith, "GunSmith_Contact_Details", "gName")
            End If
            Dim SQL As String = "INSERT INTO GunSmith_Details(GID,gsmith,od,notes,sdate,rdate,sync_lastupdate) VALUES(" &
                                GID & ",'" & strSmith & "','" & strOD & "','" & strNotes & "','" &
                                strShip & "','" & strReturn & "',Now())"
            Obj.ConnExec(SQL)
            MsgBox("Details where added to the Gun Smith Log", MsgBoxStyle.Information, Me.Text)
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class