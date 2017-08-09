Imports BSMyGunCollection.MGC
Public Class frmMoveBarrelConKit
    Public BarrelID As Long

    Private Sub frmMoveBarrelConKit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Gun_CollectionTableAdapter.Fill(Me.MGCDataSet.Gun_Collection)
    End Sub

    Private Sub btnAttach_Click(sender As System.Object, e As System.EventArgs) Handles btnAttach.Click
        Try
            Dim GID As Long = cmbFirearm.SelectedValue
            Dim fullName As String = cmbFirearm.SelectedText
            Dim Obj As New BSDatabase
            Dim SQL As String = "Update Gun_Collection_Ext set GID=" & GID & " where id=" & BarrelID
            Obj.ConnExec(SQL)
            SQL = "update Gun_Collection_Ext_Links set gid=" & GID & " where bsid=" & BarrelID
            Obj.ConnExec(SQL)
            SQL = "UPDATE Maintance_Details set GID=" & GID & " where BSID=" & BarrelID
            Obj.ConnExec(SQL)
            MsgBox("Barrel/Conversion Kit was moved to " & fullName)
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAttach_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try

    End Sub
End Class