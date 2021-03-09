Imports BSMyGunCollection.MGC
Public Class frmEditModelTypes
    Public ManufacturersID As Long
    Public ManufacturersName As String
    Public ModelID As Long
    Public ModelName As String
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmEditModelTypes_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        txtManufacturer.Text = ManufacturersName
        txtModel.Text = ModelName
        Dim Obj As New GlobalFunctions
        ManufacturersID = Obj.GetManufacturersID(ManufacturersName)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim Manu As String = txtManufacturer.Text
            Dim Model As String = txtModel.Text
            Dim ObjDB As New BSDatabase
            Dim SQL As String = "UPDATE Gun_Model set [Model]='" & Model & "',sync_lastupdate=Now() where ID=" & ModelID
            ObjDB.ConnExec(SQL)
            SQL = "UPDATE Gun_Manufacturer set Brand='" & Manu & "',sync_lastupdate=Now() where ID=" & ManufacturersID
            ObjDB.ConnExec(SQL)
            frmEditModel.LoadData()
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class