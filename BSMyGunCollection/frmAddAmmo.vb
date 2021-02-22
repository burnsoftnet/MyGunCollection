Imports BSMyGunCollection.MGC
Public Class frmAddAmmo

    Private Sub frmAddAmmo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ObjAC As New AutoFillCollections
            txtAmmo.AutoCompleteCustomSource = ObjAC.Gun_Cal
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim ObjGF As New GlobalFunctions
            Dim Obj As New BSDatabase
            Dim strTableName As String = "Gun_Cal"
            Dim strFieldName As String = "Cal"
            Dim strAmmo As String = Trim(Replace(txtAmmo.Text, "'", "''"))
            If Not ObjGF.ObjectExistsinDB(strAmmo, strFieldName, strTableName) Then
                Obj.ConnExec("INSERT INTO " & strTableName & "(" & strFieldName & ",sync_lastupdate) VALUES('" & strAmmo & "',Now())")
                txtAmmo.Text = ""
                Label1.Text = strAmmo & " was added!"
            Else
                txtAmmo.Text = ""
                Label1.Text = strAmmo & " already existed!"
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "Button1.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class