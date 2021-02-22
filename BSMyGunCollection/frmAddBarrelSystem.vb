Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
''' <summary>
''' Class frmAddBarrelSystem.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddBarrelSystem
    ''' <summary>
    ''' The gid
    ''' </summary>
    Public GID As Long
    ''' <summary>
    ''' Automatics the fill.
    ''' </summary>
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
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim SQL As String = "SELECT * from Gun_Collection where ID=" & GID
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While RS.Read
                If Not IsDBNull(RS("Fullname")) Then txtRecieverName.Text = RS("Fullname")
                If Not IsDBNull(RS("BarrelLength")) Then txtBarLen.Text = RS("BarrelLength")
                If Not IsDBNull(RS("Height")) Then txtOvLen.Text = RS("Height")
                If Not IsDBNull(RS("Action")) Then txtAction.Text = RS("Action")
                If Not IsDBNull(RS("Feedsystem")) Then txtFeedSys.Text = RS("Feedsystem")
                If Not IsDBNull(RS("Sights")) Then txtSight.Text = RS("Sights")
                If Not IsDBNull(RS("PetLoads")) Then txtPetLoads.Text = RS("PetLoads")
                If Not IsDBNull(RS("PurchasedPrice")) Then txtPurPrice.Text = RS("PurchasedPrice")
                If Not IsDBNull(RS("PurchasedFrom")) Then txtPurFrom.Text = RS("PurchasedFrom")
                If Not IsDBNull(RS("Finish")) Then txtFinish.Text = RS("Finish")
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
    ''' <summary>
    ''' Handles the Load event of the frmAddBarrelSystem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddBarrelSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call AutoFill()
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
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
            Dim iDefault As Integer = 0
            Dim SQL As String = ""

            If Not IsRequired(sName, "Name", Me.Text) Then Exit Sub
            If Not IsRequired(SysType, "System Type", Me.Text) Then Exit Sub
            If Not IsRequired(Cal, "Caliber", Me.Text) Then Exit Sub
            If Not IsRequired(PurPrice, "Purchase Price", Me.Text) Then Exit Sub
            If Not IsRequired(PurFrom, "Purchased From", Me.Text) Then Exit Sub

            If chkSetDefault.Checked Then
                iDefault = 1
            Else
                iDefault = 0
            End If

            SQL = "INSERT INTO Gun_Collection_Ext (GID,ModelName,Caliber,Finish,BarrelLength,PetLoads,Action," &
                    "Feedsystem,Sights,PurchasedPrice,PurchasedFrom,dtp,Height,Type,IsDefault,sync_lastupdate) VALUES(" &
                    GID & ",'" & sName & "','" & Cal & "','" & StockFinish & "','" & BarLen &
                    "','" & PetLoads & "','" & fAction & "','" & FeedSys & "','" & Sights & "','" &
                    PurPrice & "','" & PurFrom & "',DATE(),'" & OvalLen & "','" & SysType &
                    "'," & iDefault & ",Now())"


            Obj.ConnExec(SQL)
            Dim BarrelID As Long = ObjGF.GetBarrelID(GID)
            Dim DefaultBarrelId As Long = 0
            SQL = "INSERT INTO Gun_Collection_Ext_Links(BSID,GID,sync_lastupdate) VALUES(" & BarrelID &
                    "," & GID & ",Now())"
            Obj.ConnExec(SQL)

            If chkSetDefault.Checked Then
                DefaultBarrelId = ObjGF.GetBarrelID(GID, 1)
                Call ObjGF.SwapDefaultBarrelSystems(DefaultBarrelId, BarrelID, GID)
            End If
            Dim frmNew As New frmViewCollectionDetails
            frmNew.ItemID = GID
            frmNew.MdiParent = Me.MdiParent
            frmNew.Show()
            Me.Close()

        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class