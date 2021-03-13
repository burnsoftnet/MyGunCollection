''TODO #43 Clean up unused code 
Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Imports BurnSoft.Applications.MGC
Imports BurnSoft.Applications.MGC.AutoFill
Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class frmAddBarrelSystem.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddBarrelSystem
    ''' <summary>
    ''' The gid
    ''' </summary>
    Public Gid As Long
    ''' <summary>
    ''' Automatics the fill.
    ''' </summary>
    Sub AutoFill()
        Try
            Dim errOut As String = ""
            txtCal.AutoCompleteCustomSource = Ammo.Caliber(DatabasePath,errOut )
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtFeedSys.AutoCompleteCustomSource = GunCollection.Feedsystem(DatabasePath,errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtSight.AutoCompleteCustomSource = GunCollection.Sights(DatabasePath,errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtPetLoads.AutoCompleteCustomSource = Ammo.Caliber(DatabasePath,errOut )
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtFinish.AutoCompleteCustomSource = GunCollection.Finish(DatabasePath,errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtAction.AutoCompleteCustomSource = GunCollection.Action(DatabasePath,errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtPurFrom.AutoCompleteCustomSource = Gun.ShopDetails(DatabasePath,errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
            txtSysType.AutoCompleteCustomSource = GunCollection.BarrelSysTypes(DatabasePath,errOut)
            If errOut.Length > 0 then Throw New Exception(errOut)
        Catch ex As Exception
            Dim sSubFunc As String = "AutoFill"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            'Dim sql As String = "SELECT * from Gun_Collection where ID=" & Gid
            'Dim obj As New BSDatabase
            'Call obj.ConnectDB()
            'Dim cmd As New OdbcCommand(sql, obj.Conn)
            'Dim rs As OdbcDataReader
            'rs = cmd.ExecuteReader
            'While rs.Read
            '    If Not IsDBNull(rs("Fullname")) Then txtRecieverName.Text = rs("Fullname")
            '    If Not IsDBNull(rs("BarrelLength")) Then txtBarLen.Text = rs("BarrelLength")
            '    If Not IsDBNull(rs("Height")) Then txtOvLen.Text = rs("Height")
            '    If Not IsDBNull(rs("Action")) Then txtAction.Text = rs("Action")
            '    If Not IsDBNull(rs("Feedsystem")) Then txtFeedSys.Text = rs("Feedsystem")
            '    If Not IsDBNull(rs("Sights")) Then txtSight.Text = rs("Sights")
            '    If Not IsDBNull(rs("PetLoads")) Then txtPetLoads.Text = rs("PetLoads")
            '    If Not IsDBNull(rs("PurchasedPrice")) Then txtPurPrice.Text = rs("PurchasedPrice")
            '    If Not IsDBNull(rs("PurchasedFrom")) Then txtPurFrom.Text = rs("PurchasedFrom")
            '    If Not IsDBNull(rs("Finish")) Then txtFinish.Text = rs("Finish")
            'End While
            'rs.Close()
            'obj.CloseDB()
            Dim errOut as String = ""
            Dim lst as List(Of BarrelSystems) = ExtraBarrelConvoKits.GetCurrentBarrelDetailstList(DatabasePath, Gid, errOut)

            For Each o As BarrelSystems In lst
                txtRecieverName.Text = o.FullName
                txtBarLen.Text = o.BarrelLength
                txtOvLen.Text = o.Height
                txtAction.Text = o.Action
                txtFeedSys.Text = o.FeedSystem
                txtSight.Text = o.Sights
                txtPetLoads.Text = o.PetLoads
                txtPurPrice.Text = o.PurchasedPrice
                txtPurFrom.Text = o.PurchasedFrom
                txtFinish.Text = o.Finish
            Next

        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmAddBarrelSystem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddBarrelSystem_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call AutoFill()
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim obj As New BSDatabase
            Dim objGf As New GlobalFunctions
            Dim sName As String = FluffContent(txtName.Text)
            Dim sysType As String = FluffContent(txtSysType.Text)
            Dim cal As String = FluffContent(txtCal.Text)
            Dim barLen As String = FluffContent(txtBarLen.Text)
            Dim ovalLen As String = FluffContent(txtOvLen.Text)
            Dim stockFinish As String = FluffContent(txtFinish.Text)
            Dim fAction As String = FluffContent(txtAction.Text)
            Dim feedSys As String = FluffContent(txtFeedSys.Text)
            Dim sights As String = FluffContent(txtSight.Text)
            Dim petLoads As String = FluffContent(txtPetLoads.Text)
            Dim purPrice As String = FluffContent(txtPurPrice.Text)
            Dim purFrom As String = FluffContent(txtPurFrom.Text)
            Dim iDefault As Integer 
            Dim sql As String 

            If Not IsRequired(sName, "Name", Text) Then Exit Sub
            If Not IsRequired(sysType, "System Type", Text) Then Exit Sub
            If Not IsRequired(cal, "Caliber", Text) Then Exit Sub
            If Not IsRequired(purPrice, "Purchase Price", Text) Then Exit Sub
            If Not IsRequired(purFrom, "Purchased From", Text) Then Exit Sub

            Dim errOut as String = ""

            if Not ExtraBarrelConvoKits.Add(DatabasePath, Gid, sName, cal, stockFinish, barLen, petLoads, fAction, feedSys, sights, purPrice, purFrom,ovalLen, sysType, chkSetDefault.Checked, errOut) Then Throw New Exception(errOut)
            Dim barrelId As Long = ExtraBarrelConvoKits.GetBarrelId(DatabasePath, Gid, errOut)
            If Not ExtraBarrelConvoKits.AddLink(DatabasePath, barrelId, Gid, errOut) Then Throw New Exception(errOut)
            'If chkSetDefault.Checked Then
            '    iDefault = 1
            'Else
            '    iDefault = 0
            'End If

            'sql = "INSERT INTO Gun_Collection_Ext (GID,ModelName,Caliber,Finish,BarrelLength,PetLoads,Action," &
            '        "Feedsystem,Sights,PurchasedPrice,PurchasedFrom,dtp,Height,Type,IsDefault,sync_lastupdate) VALUES(" &
            '        Gid & ",'" & sName & "','" & cal & "','" & stockFinish & "','" & barLen &
            '        "','" & petLoads & "','" & fAction & "','" & feedSys & "','" & sights & "','" &
            '        purPrice & "','" & purFrom & "',DATE(),'" & ovalLen & "','" & sysType &
            '        "'," & iDefault & ",Now())"


            'obj.ConnExec(sql)
            'Dim barrelId As Long = objGf.GetBarrelID(Gid)
            Dim defaultBarrelId As Long
            'sql = "INSERT INTO Gun_Collection_Ext_Links(BSID,GID,sync_lastupdate) VALUES(" & barrelId &
            '        "," & Gid & ",Now())"
            'obj.ConnExec(sql)

            If chkSetDefault.Checked Then
                defaultBarrelId = objGf.GetBarrelID(Gid, 1)
                Call objGf.SwapDefaultBarrelSystems(defaultBarrelId, barrelId, Gid)
            End If
            Dim frmNew As New frmViewCollectionDetails
            frmNew.ItemId = Gid
            frmNew.MdiParent = MdiParent
            frmNew.Show()
            Close()

        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class