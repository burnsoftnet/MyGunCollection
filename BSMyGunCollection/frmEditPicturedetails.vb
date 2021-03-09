Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Public Class frmEditPicturedetails
    Public PID As Long
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Sub LoadData()
        Try
            Dim Obj As New BSDatabase
            Obj.ConnectDB()
            Dim SQL As String = "SELECT pd_name,pd_note from Gun_Collection_Pictures where ID=" & PID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                If Not IsDBNull(RS("pd_name")) Then txtName.Text = RS("pd_name")
                If Not IsDBNull(RS("pd_note")) Then txtNotes.Text = RS("pd_note")
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
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Try
            Dim sTitle As String = FluffContent(txtName.Text)
            Dim sNotes As String = FluffContent(txtNotes.Text)
            Dim SQL As String = "UPDATE Gun_Collection_Pictures set pd_name='" & _
                                sTitle & "', pd_note='" & sNotes & "',sync_lastupdate=Now() where ID=" & PID
            Dim Obj As New BSDatabase
            Obj.ConnExec(SQL)
            Obj = Nothing
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnUpdate.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmEditPicturedetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Call LoadData()
    End Sub
End Class