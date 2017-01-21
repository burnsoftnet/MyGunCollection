Imports BSMyGunCollection.MGC
Public Class frmAddAccessory
    Public ItemID As String
    Public IsShotGun As Boolean
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim strMan As String = FluffContent(txtMan.Text)
            Dim strModel As String = FluffContent(txtModel.Text)
            Dim strSerial As String = FluffContent(txtSerial.Text)
            Dim strCondition As String = cmdCondition.SelectedItem.ToString
            Dim strUse As String = FluffContent(txtUse.Text)
            Dim strPurVal As String = FluffContent(txtPurVal.Text)
            Dim strNotes As String = FluffContent(txtNotes.Text)
            Dim dAppValue As Double = FluffContent(txtAppValue.Text, 0.0)
            Dim iCIV As Integer = 0
            Dim iIC As Integer = 0
            If chkCIV.Checked Then iCIV = 1
            If chkIsChoke.CheckAlign Then iIC = 1
            If Not IsRequired(strMan, "Manufacturer", Me.Text) Then Exit Sub
            If Not IsRequired(strModel, "Model", Me.Text) Then Exit Sub

            Dim Obj As New BSDatabase
            Dim SQL As String = "INSERT INTO Gun_Collection_Accessories(GID,Manufacturer,Model,SerialNumber,Condition,Notes,Use,PurValue,AppValue,CIV,IC,sync_lastupdate) VALUES(" & _
                    ItemID & ",'" & strMan & "','" & strModel & "','" & strSerial & "','" & strCondition & "','" & _
                    strNotes & "','" & strUse & "','" & strPurVal & "'," & dAppValue & "," & iCIV & "," & iIC & ",Now())"
            Obj.ConnExec(SQL)
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmAddAccessory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Label10.Visible = IsShotGun
            chkIsChoke.Visible = IsShotGun
            Dim ObjAF As New AutoFillCollections
            txtMan.AutoCompleteCustomSource = ObjAF.Accessory_Manufacturer
            txtModel.AutoCompleteCustomSource = ObjAF.Accessory_Model
            txtUse.AutoCompleteCustomSource = ObjAF.Accessory_Use
            txtPurVal.AutoCompleteCustomSource = ObjAF.Accessory_PurValue
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class