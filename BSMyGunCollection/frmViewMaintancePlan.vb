Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Public Class frmViewMaintancePlan
    Public ID As String
    Sub GetData()
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Maintance_Plans where ID=" & ID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While (RS.Read())
                If Not IsDBNull(RS("Name")) Then txtName.Text = RS("Name")
                If Not IsDBNull(RS("OD")) Then txtOD.Text = RS("OD")
                If Not IsDBNull(RS("iid")) Then nudIID.Value = RS("iid")
                If Not IsDBNull(RS("iirf")) Then nudIIRF.Value = RS("iirf")
                If Not IsDBNull(RS("Notes")) Then txtNotes.Text = RS("Notes")
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GetData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmViewMaintancePlan_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Len(ID) > 0 Then
            Call GetData()
        Else
            Me.Close()
        End If
    End Sub
    Private Sub brnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles brnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        Me.Text = "Edit Maintenance Plan"
        btnEdit.Visible = False
        btnUpdate.Visible = True
        txtName.ReadOnly = False
        txtOD.ReadOnly = False
        nudIID.ReadOnly = False
        nudIIRF.ReadOnly = False
        txtNotes.ReadOnly = False
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Try
            Dim strName As String = FluffContent(txtName.Text)
            Dim strOD As String = FluffContent(txtOD.Text)
            Dim IntIID As Integer = nudIID.Value
            Dim intIIRF As Integer = nudIIRF.Value
            Dim strNotes As String = FluffContent(txtNotes.Text)
            Dim SQL As String = "UPDATE Maintance_Plans set Name='" & strName & "',OD='" & strOD & _
                        "',iid=" & IntIID & ",iirf=" & intIIRF & ",Notes='" & strNotes & "' where ID=" & ID
            Dim Obj As New BSDatabase
            Obj.ConnExec(SQL)
            Obj = Nothing
            btnEdit.Visible = True
            btnUpdate.Visible = False
            txtName.ReadOnly = True
            txtOD.ReadOnly = True
            nudIID.ReadOnly = True
            nudIIRF.ReadOnly = True
            txtNotes.ReadOnly = True
            Me.Text = "View Maintenance Plan"
        Catch ex As Exception
            Dim sSubFunc As String = "btnUpdate_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class