Imports BSMyGunCollection.MGC
Public Class frmAddCollectionAmmo

    Private Sub frmAddCollectionAmmo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ObjAF As New AutoFillCollections
            txtMan.AutoCompleteCustomSource = ObjAF.Ammo_Manufacturer
            txtCal.AutoCompleteCustomSource = ObjAF.Ammo_Cal
            txtName.AutoCompleteCustomSource = ObjAF.Ammo_Name
            txtGrain.AutoCompleteCustomSource = ObjAF.Ammo_Grain
            txtJacket.AutoCompleteCustomSource = ObjAF.Ammo_Jacket
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If Not IsNumeric(txtVelocity.Text) Then
                MsgBox("Please input a numeric value for Velocity!")
                Exit Sub
            End If
            Dim strMan As String = FluffContent(txtMan.Text)
            Dim strName As String = FluffContent(txtName.Text)
            Dim strCal As String = FluffContent(txtCal.Text)
            Dim strGrain As String = FluffContent(txtGrain.Text)
            Dim strJacket As String = FluffContent(txtJacket.Text)
            Dim strQty As String = CStr(txtQty.Value)
            Dim lVelocity As Long = FluffContent(txtVelocity.Text, 0)
            If Not IsRequired(strMan, "Manufacturer", Me.Text) Then Exit Sub
            If Not IsRequired(strName, "Name", Me.Text) Then Exit Sub
            If Not IsRequired(strCal, "Caliber", Me.Text) Then Exit Sub
            If Not IsRequired(strGrain, "Grain", Me.Text) Then Exit Sub
            If Not IsRequired(strJacket, "Jacket", Me.Text) Then Exit Sub
            If Not IsRequired(strQty, "Qty", Me.Text) Then Exit Sub
            Dim ddValue As Double = ConvToNum(strGrain)
            Dim Obj As New BSDatabase
            Dim SQL As String = "INSERT INTO Gun_Collection_Ammo(Manufacturer,Name,Cal,Grain,Jacket,Qty,dcal,vel_n,sync_lastupdate) VALUES('" & _
                                strMan & "','" & strName & "','" & strCal & "','" & strGrain & "','" & strJacket & "'," & _
                                strQty & "," & ddValue & "," & lVelocity & ",Now())"
            Obj.ConnExec(SQL)
            If AUDITAMMO Then
                Dim ObjGF As New GlobalFunctions
                Dim AID As Long = ObjGF.GetLastAmmoID
                Dim sValue As String = InputBox("How Much did you pay for this box?", "Ammo Audit", 0)
                If Len(sValue) = 0 Then sValue = 0
                Dim PPB As Double = CDbl(sValue) / CLng(strQty)
                Obj.ConnExec("INSERT INTO Gun_Collection_Ammo_PriceAudit (AID,DTA,Qty,PricePaid,PPB,sync_lastupdate) " & _
                            "VALUES(" & AID & ",'" & Now & "'," & strQty & "," & CDbl(sValue) & "," & PPB & ",Now())")
            End If
            MsgBox(strMan & " " & strName & " was added to the database!", MsgBoxStyle.Information, Me.Text)
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class