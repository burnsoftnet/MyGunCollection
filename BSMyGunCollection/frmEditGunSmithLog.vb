Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Public Class frmEditGunSmithLog
    Public ID As Long
    Sub PreLoad()
        Try
            Dim ObjAF As New AutoFillCollections
            txtGS.AutoCompleteCustomSource = ObjAF.GunSmith_Name
        Catch ex As Exception
            Dim sSubFunc As String = "PreLoad"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub LoadData()
        Dim Obj As New BSDatabase
        Obj.ConnectDB()
        Try
            Dim SQL As String = "SELECT * from GunSmith_Details where ID=" & ID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While (RS.Read)
                txtGS.Text = Trim(RS("gsmith"))
                DateTimePicker1.Value = CDate(RS("sdate"))
                DateTimePicker2.Value = CDate(RS("rdate"))
                txtOD.Text = Trim(RS("od"))
                txtNotes.Text = Trim(RS("notes"))
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmEditGunSmithLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ObjAF As New AutoFillCollections
            txtGS.AutoCompleteCustomSource = ObjAF.GunSmith_Name
            Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
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
            Dim SQL As String = "UPDATE GunSmith_Details set gsmith='" & strSmith & _
                    "',od='" & strOD & "',notes='" & strNotes & "',sdate='" & _
                    strShip & "',rdate='" & strReturn & "',sync_lastupdate=Now() where ID=" & ID
            Obj.ConnExec(SQL)
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnUpdate_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class