Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Public Class frmEditBarrelSystem
    Public GID As Long
    Public Recname As String
    Public BID As Long
    Sub AutoFill()
        Try
            Dim ObjAF As New AutoFillCollections
            txtCal.AutoCompleteCustomSource = ObjAF.Gun_Cal
            txtFeedSys.AutoCompleteCustomSource = ObjAF.Gun_Collection_FeedSystem
            txtSight.AutoCompleteCustomSource = ObjAF.Gun_Collection_Sights
            txtPetLoads.AutoCompleteCustomSource = ObjAF.Gun_Cal
            txtFinish.AutoCompleteCustomSource = ObjAF.Gun_Collection_Finish
            txtAction.AutoCompleteCustomSource = ObjAF.Gun_Collection_Action
            txtPurFrom.AutoCompleteCustomSource = ObjAF.Gun_Shop_Details
            txtSysType.AutoCompleteCustomSource = ObjAF.Gun_Collection_BarrelSysTypes
        Catch ex As Exception
            Dim sSubFunc As String = "AutoFill"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub LoadData()
        txtRecieverName.Text = Recname
        Try
            Dim SQL As String = "SELECT * from Gun_Collection_Ext where ID=" & BID
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            Dim iDefault As Integer = 0
            RS = CMD.ExecuteReader
            While RS.Read
                txtName.Text = Trim(RS("ModelName"))
                txtSysType.Text = Trim(RS("Type"))
                txtCal.Text = Trim(RS("Caliber"))
                txtBarLen.Text = Trim(RS("BarrelLength"))
                txtOvLen.Text = Trim(RS("Height"))
                txtFinish.Text = Trim(RS("Finish"))
                txtAction.Text = Trim(RS("Action"))
                txtFeedSys.Text = Trim(RS("Feedsystem"))
                txtSight.Text = Trim(RS("Sights"))
                txtPetLoads.Text = Trim(RS("PetLoads"))
                txtPurPrice.Text = Trim(RS("PurchasedPrice"))
                txtPurFrom.Text = Trim(RS("PurchasedFrom"))
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
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Sub SaveData()
        Try
            Dim Obj As New BSDatabase
            Dim ObjGF As New GlobalFunctions
            Dim sName As String = FluffContent(txtName.Text)
            Dim SysType As String = FluffContent(txtSysType.Text)
            Dim Cal As String = FluffContent(txtCal.Text)
            Dim BarLen As String = FluffContent(txtBarLen.Text)
            Dim OvalLen As String = FluffContent(txtOvLen.Text)
            Dim StockFinish As String = FluffContent(txtFinish.Text)
            Dim fAction As String = FluffContent(txtAction.Text)
            Dim FeedSys As String = FluffContent(txtFeedSys.Text)
            Dim Sights As String = FluffContent(txtSight.Text)
            Dim PetLoads As String = FluffContent(txtPetLoads.Text)
            Dim PurPrice As String = FluffContent(txtPurPrice.Text)
            Dim PurFrom As String = FluffContent(txtPurFrom.Text)
            Dim SQL As String = ""

            If Not IsRequired(sName, "Name", Me.Text) Then Exit Sub
            If Not IsRequired(SysType, "System Type", Me.Text) Then Exit Sub
            If Not IsRequired(Cal, "Caliber", Me.Text) Then Exit Sub
            If Not IsRequired(PurPrice, "Purchase Price", Me.Text) Then Exit Sub
            If Not IsRequired(PurFrom, "Purchased From", Me.Text) Then Exit Sub

            SQL = "UPDATE Gun_Collection_Ext set ModelName='" & sName & "',Caliber='" & Cal & _
                    "',Finish='" & StockFinish & "',BarrelLength='" & BarLen & "',PetLoads='" & _
                    PetLoads & "',Action='" & fAction & "',Feedsystem='" & FeedSys & "',Sights='" & _
                    Sights & "',PurchasedPrice='" & PurPrice & "',PurchasedFrom='" & PurFrom & _
                    "',Height='" & OvalLen & "',Type='" & SysType & "',sync_lastupdate=Now() where ID=" & BID

            Obj.ConnExec(SQL)
            Me.MdiParent.Refresh()
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "SaveData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmEditBarrelSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
        Call AutoFill()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
End Class