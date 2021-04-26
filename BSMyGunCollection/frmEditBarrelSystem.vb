Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Imports BurnSoft.Applications.MGC.Types

''TODO: Convert code from FrmEditBarrelSystem #18

''' <summary>
''' Class frmEditBarrelSystem.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmEditBarrelSystem
    ''' <summary>
    ''' The gid
    ''' </summary>
    Public Gid As Long
    ''' <summary>
    ''' The recname
    ''' </summary>
    Public Recname As String
    ''' <summary>
    ''' The bid
    ''' </summary>
    Public Bid As Long
    ''' <summary>
    ''' Error container string
    ''' </summary>
    Dim errOut as String
    ''' <summary>
    ''' Automatics the fill.
    ''' </summary>
    Sub AutoFill()
        Try
            'Dim objAf As New AutoFillCollections
            'txtCal.AutoCompleteCustomSource = objAf.Gun_Cal
            'txtFeedSys.AutoCompleteCustomSource = objAf.Gun_Collection_FeedSystem
            'txtSight.AutoCompleteCustomSource = objAf.Gun_Collection_Sights
            'txtPetLoads.AutoCompleteCustomSource = objAf.Gun_Cal
            'txtFinish.AutoCompleteCustomSource = objAf.Gun_Collection_Finish
            'txtAction.AutoCompleteCustomSource = objAf.Gun_Collection_Action
            'txtPurFrom.AutoCompleteCustomSource = objAf.Gun_Shop_Details
            'txtSysType.AutoCompleteCustomSource = objAf.Gun_Collection_BarrelSysTypes
        Catch ex As Exception
            Dim sSubFunc As String = "AutoFill"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        txtRecieverName.Text = Recname
        Try
            Dim lst As List(Of BarrelSystems) = BurnSoft.Applications.MGC.Firearms.ExtraBarrelConvoKits.GetList(DatabasePath, Bid, errOut)

            For Each o As BarrelSystems In lst
                txtName.Text = Trim(o.ModelName)
                txtSysType.Text = Trim(o.ExtType)
                txtCal.Text = Trim(o.Caliber)
                txtBarLen.Text = Trim(o.BarrelLength)
                txtOvLen.Text = Trim(o.Height)
                txtFinish.Text = Trim(o.Finish)
                txtAction.Text = Trim(o.Action)
                txtFeedSys.Text = Trim(o.FeedSystem)
                txtSight.Text = Trim(o.Sights)
                txtPetLoads.Text = Trim(o.PetLoads)
                txtPurPrice.Text = Trim(o.PurchasedPrice)
                txtPurFrom.Text = Trim(o.PurchasedFrom)
            Next

            'Dim sql As String = "SELECT * from Gun_Collection_Ext where ID=" & Bid
            'Dim obj As New BSDatabase
            'Call obj.ConnectDB()
            'Dim cmd As New OdbcCommand(sql, obj.Conn)
            'Dim rs As OdbcDataReader
            'rs = cmd.ExecuteReader
            'While rs.Read
            '    txtName.Text = Trim(rs("ModelName"))
            '    txtSysType.Text = Trim(rs("Type"))
            '    txtCal.Text = Trim(rs("Caliber"))
            '    txtBarLen.Text = Trim(rs("BarrelLength"))
            '    txtOvLen.Text = Trim(rs("Height"))
            '    txtFinish.Text = Trim(rs("Finish"))
            '    txtAction.Text = Trim(rs("Action"))
            '    txtFeedSys.Text = Trim(rs("Feedsystem"))
            '    txtSight.Text = Trim(rs("Sights"))
            '    txtPetLoads.Text = Trim(rs("PetLoads"))
            '    txtPurPrice.Text = Trim(rs("PurchasedPrice"))
            '    txtPurFrom.Text = Trim(rs("PurchasedFrom"))
            'End While
            'rs.Close()
            'obj.CloseDB()
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
    ''' <summary>
    ''' Saves the data.
    ''' </summary>
    Sub SaveData()
        Try
            Dim obj As New BSDatabase
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
            Dim sql As String 

            If Not IsRequired(sName, "Name", Text) Then Exit Sub
            If Not IsRequired(sysType, "System Type", Text) Then Exit Sub
            If Not IsRequired(cal, "Caliber", Text) Then Exit Sub
            If Not IsRequired(purPrice, "Purchase Price", Text) Then Exit Sub
            If Not IsRequired(purFrom, "Purchased From", Text) Then Exit Sub

            sql = "UPDATE Gun_Collection_Ext set ModelName='" & sName & "',Caliber='" & cal &
                    "',Finish='" & stockFinish & "',BarrelLength='" & barLen & "',PetLoads='" &
                    petLoads & "',Action='" & fAction & "',Feedsystem='" & feedSys & "',Sights='" &
                    sights & "',PurchasedPrice='" & purPrice & "',PurchasedFrom='" & purFrom &
                    "',Height='" & ovalLen & "',Type='" & sysType & "',sync_lastupdate=Now() where ID=" & Bid

            obj.ConnExec(sql)
            MdiParent.Refresh()
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "SaveData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmEditBarrelSystem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditBarrelSystem_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call LoadData()
        Call AutoFill()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnSave control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
End Class