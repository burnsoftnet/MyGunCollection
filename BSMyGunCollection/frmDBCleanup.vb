Imports BurnSoft.Applications.MGC

''' <summary>
''' Class frmDBCleanup.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmDbCleanup
    ''' <summary>
    ''' The i
    ''' </summary>
    Public I As Integer = 0
    ''' <summary>
    ''' The err container
    ''' </summary>
    Dim _errOut as String = ""
    ''' <summary>
    ''' Handles the SelectedIndexChanged event of the cbActionList control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub cbActionList_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbActionList.SelectedIndexChanged
        If cbActionList.SelectedItem <> Nothing Then
            Dim strList As String = cbActionList.SelectedItem.ToString
            If Len(strList) > 0 Then
                btnStart.Enabled = True
            Else
                btnStart.Enabled = False
            End If
        End If
    End Sub
   
    ''' <summary>
    ''' Kills the data.
    ''' </summary>
    ''' <param name="strTable">The string table.</param>
    Sub KillData(ByVal strTable As String)
        Try 
            If Not DatabaseCleanUp.KillData(DatabasePath, strTable, _errOut ) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Dim sSubFunc As String = "KillData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Clears the grip types.
    ''' </summary>
    Sub ClearGripTypes()
        Try
            If Not DatabaseCleanUp.ClearGripTypes(DatabasePath, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Dim sSubFunc As String = "ClearGripTypes"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Clears the buyer list.
    ''' </summary>
    Sub ClearBuyerList()
        Try
            If Not DatabaseCleanUp.ClearBuyerList(DatabasePath, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Dim sSubFunc As String = "ClearBuyerList"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Clears the gun shop list.
    ''' </summary>
    Sub ClearGunShopList()
        Try
            If Not DatabaseCleanUp.ClearGunShopList(DatabasePath, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Dim sSubFunc As String = "ClearGunShopList"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Clears the nationality.
    ''' </summary>
    Sub ClearNationality()
        Try
            If Not DatabaseCleanUp.ClearNationality(DatabasePath, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Dim sSubFunc As String = "ClearNationality"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Clears the models.
    ''' </summary>
    Sub ClearModels()
        Try
            If Not DatabaseCleanUp.ClearModels(DatabasePath, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Dim sSubFunc As String = "ClearModels"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Clears the manufacturers.
    ''' </summary>
    Sub ClearManufacturers()
        Try
            If Not DatabaseCleanUp.ClearManufacturers(DatabasePath, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Dim sSubFunc As String = "ClearManufacturers"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Clears the collection.
    ''' </summary>
    Sub ClearCollection()
        DatabaseCleanUp.ClearCollection(DatabasePath, _errOut)
        Call MDIParent1.RefreshCollection()
    End Sub
    ''' <summary>
    ''' Clears the caliber.
    ''' </summary>
    Sub ClearCaliber()
        Call KillData("Gun_Cal")
    End Sub
    ''' <summary>
    ''' Clears the ammunition.
    ''' </summary>
    Sub ClearAmmunition()
        Call KillData("Gun_Collection_Ammo")
    End Sub
    ''' <summary>
    ''' Clears the maint plans.
    ''' </summary>
    Sub ClearMaint_Plans()
        Call KillData("Maintance_Plans")
    End Sub
    ''' <summary>
    ''' Clears the wish list.
    ''' </summary>
    Sub ClearWishList()
        Call KillData("Wishlist")
    End Sub
    ''' <summary>
    ''' Clears the type of the gun.
    ''' </summary>
    Sub ClearGun_Type()
        Call KillData("Gun_Type")
    End Sub
    ''' <summary>
    ''' Clears the ammo audit.
    ''' </summary>
    Sub ClearAmmoAudit()
        Call KillData("Gun_Collection_Ammo_PriceAudit")
    End Sub
    ''' <summary>
    ''' Clears the saved c reports.
    ''' </summary>
    Sub ClearSavedCReports()
        Call KillData("CR_SavedReports")
    End Sub
    ''' <summary>
    ''' Clears all.
    ''' </summary>
    Sub ClearAll()
        ProgressBar1.Visible = True
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 14
        I = 0
        Call AddToProgBar("Clearing Collection")
        Call ClearCollection()
        Call AddToProgBar("Clearing Caliber")
        Call ClearCaliber()
        Call AddToProgBar("Clearing Ammunition")
        Call ClearAmmunition()
        Call AddToProgBar("Clearing Ammunition Audit List")
        Call ClearAmmoAudit()
        Call AddToProgBar("Clearing Gun Types")
        Call ClearGun_Type()
        Call AddToProgBar("Clearing Maintance Plans")
        Call ClearMaint_Plans()
        Call AddToProgBar("Clearing Wish List")
        Call ClearWishList()
        Call AddToProgBar("Clearing Nationality")
        Call ClearNationality()
        Call AddToProgBar("Clearing Gun Shop Lists")
        Call ClearGunShopList()
        Call AddToProgBar("Clearing Buyers List")
        Call ClearBuyerList()
        Call AddToProgBar("Clearing Grip Types")
        Call ClearGripTypes()
        Call AddToProgBar("Clearing Models")
        Call ClearModels()
        Call AddToProgBar("Clearing Manufacturers")
        Call ClearManufacturers()
        Call AddToProgBar("Clearing Saved Reports")
        Call ClearSavedCReports()
        ProgressBar1.Visible = False
        lblStatus.Text = ""
        lblStatus.Refresh()
    End Sub
    ''' <summary>
    ''' Converts to progress bar.
    ''' </summary>
    ''' <param name="strMsg">The string MSG.</param>
    Sub AddToProgBar(ByVal strMsg As String)
        lblStatus.Text = strMsg
        lblStatus.Refresh()
        I = I + 1
        ProgressBar1.Value = I
        ProgressBar1.Refresh()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnStart control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStart.Click
        Dim strSelected As String = cbActionList.SelectedItem.ToString
        btnStart.Enabled = False
        Select Case strSelected
            Case "Remove All Data"
                Dim sAns As String = MsgBox("Are you sure you wish to remove all data from the database?", MsgBoxStyle.YesNo, "Remove All Data")
                If sAns = vbYes Then Call ClearAll()
            Case "Clear Caliber List"
                Call ClearCaliber()
            Case "Clear Ammunition List"
                Call ClearAmmunition()
            Case "Clear Collection List"
                Call ClearCollection()
            Case "Clear Grip Types"
                Call ClearGripTypes()
            Case "Clear Buyer List"
                Call ClearBuyerList()
            Case "Clear Gun Shop List"
                Call ClearGunShopList()
            Case "Clear Models and Manufacturers"
                Call ClearModels()
                Call ClearManufacturers()
            Case "Clear Nationality"
                Call ClearNationality()
            Case "Clear Gun Type"
                Call ClearGun_Type()
            Case "Clear Maintance Plans"
                Call ClearMaint_Plans()
            Case "Clear WishList"
                Call ClearWishList()
            Case "Clear Saved Custom Reports"
                Call ClearSavedCReports()
            Case "Clear Ammunition Audit List"
                Call ClearAmmoAudit()
        End Select
        MsgBox("Database clean up to " & strSelected & " is complete!")
        btnStart.Enabled = True
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmDBCleanup control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmDBCleanup_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
End Class