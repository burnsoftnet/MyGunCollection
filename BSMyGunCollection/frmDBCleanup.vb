Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
''' <summary>
''' Class frmDBCleanup.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmDBCleanup
    ''' <summary>
    ''' The i
    ''' </summary>
    Public i As Integer = 0
    ''' <summary>
    ''' Handles the SelectedIndexChanged event of the cbActionList control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub cbActionList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbActionList.SelectedIndexChanged
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
    ''' Datas the is related.
    ''' </summary>
    ''' <param name="strSQL">The string SQL.</param>
    ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    Function DataIsRelated(ByVal strSQL As String) As Boolean
        Dim bAns As Boolean = False
        Try
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(strSQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            bAns = RS.HasRows
            RS.Close()
            RS = Nothing
            CMD = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "DataIsRelated"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return bAns
    End Function
    ''' <summary>
    ''' Kills the data.
    ''' </summary>
    ''' <param name="strTable">The string table.</param>
    Sub KillData(ByVal strTable As String)
        Dim Obj As New BSDatabase
        Dim SQL As String = "DELETE from " & strTable
        Call Obj.ConnExec(SQL)
    End Sub
    ''' <summary>
    ''' Existsins the collection.
    ''' </summary>
    ''' <param name="strID">The string identifier.</param>
    ''' <param name="strColumn">The string column.</param>
    ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    Function ExistsinCollection(ByVal strID As String, ByVal strColumn As String) As Boolean
        Dim bAns As Boolean = False
        Try
            Dim SQL As String = "SELECT * from Gun_Collection where " & strColumn & "=" & strID
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            bAns = RS.HasRows
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "ExistsinCollection"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return bAns
    End Function
    ''' <summary>
    ''' Deletes the record.
    ''' </summary>
    ''' <param name="strTable">The string table.</param>
    ''' <param name="strID">The string identifier.</param>
    Sub DELETE_RECORD(ByVal strTable As String, ByVal strID As String)
        Dim SQL As String = "DELETE from " & strTable & " where ID=" & strID
        Dim Obj As New BSDatabase
        Obj.ConnExec(SQL)
    End Sub
    ''' <summary>
    ''' Clears the grip types.
    ''' </summary>
    Sub ClearGripTypes()
        Try
            Dim strTable As String = "Gun_GripType"
            Dim strCollectionID As String = "GripID"
            Dim strID As String = ""
            Dim SQL As String = "SELECT " & strTable & ".*  from " & strTable & " Inner Join Gun_Collection on Gun_Collection." & strCollectionID & " =" & strTable & ".ID"
            If DataIsRelated(SQL) Then
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                SQL = "SELECT ID from " & strTable
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                While RS.Read()
                    strID = CStr(RS("ID"))
                    If Not ExistsinCollection(strID, strCollectionID) Then Call DELETE_RECORD(strTable, strID)
                End While
                RS.Close()
                RS = Nothing
                Obj.CloseDB()
            Else
                Call KillData(strTable)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "ClearGripTypes"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Clears the buyer list.
    ''' </summary>
    Sub ClearBuyerList()
        Try
            Dim strTable As String = "Gun_Collection_SoldTo"
            Dim strCollectionID As String = "BID"
            Dim strID As String = ""
            Dim SQL As String = "SELECT " & strTable & ".*  from " & strTable & " Inner Join Gun_Collection on Gun_Collection." & strCollectionID & " =" & strTable & ".ID"
            If DataIsRelated(SQL) Then
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                SQL = "SELECT ID from " & strTable
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                While RS.Read()
                    strID = CStr(RS("ID"))
                    If Not ExistsinCollection(strID, strCollectionID) Then Call DELETE_RECORD(strTable, strID)
                End While
                RS.Close()
                RS = Nothing
                Obj.CloseDB()
            Else
                Call KillData(strTable)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "ClearBuyerList"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Clears the gun shop list.
    ''' </summary>
    Sub ClearGunShopList()
        Try
            Dim strTable As String = "Gun_Shop_Details"
            Dim strCollectionID As String = "SID"
            Dim strID As String = ""
            Dim SQL As String = "SELECT " & strTable & ".*  from " & strTable & " Inner Join Gun_Collection on Gun_Collection." & strCollectionID & " =" & strTable & ".ID"
            If DataIsRelated(SQL) Then
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                SQL = "SELECT ID from " & strTable
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                While RS.Read()
                    strID = CStr(RS("ID"))
                    If Not ExistsinCollection(strID, strCollectionID) Then Call DELETE_RECORD(strTable, strID)
                End While
                RS.Close()
                RS = Nothing
                Obj.CloseDB()
            Else
                Call KillData(strTable)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "ClearGunShopList"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Clears the nationality.
    ''' </summary>
    Sub ClearNationality()
        Try
            Dim strTable As String = "Gun_Nationality"
            Dim strCollectionID As String = "NatID"
            Dim strID As String = ""
            Dim SQL As String = "SELECT " & strTable & ".*  from " & strTable & " Inner Join Gun_Collection on Gun_Collection." & strCollectionID & " =" & strTable & ".ID"
            If DataIsRelated(SQL) Then
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                SQL = "SELECT ID from " & strTable
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                While RS.Read()
                    strID = CStr(RS("ID"))
                    If Not ExistsinCollection(strID, strCollectionID) Then Call DELETE_RECORD(strTable, strID)
                End While
                RS.Close()
                RS = Nothing
                Obj.CloseDB()
            Else
                Call KillData(strTable)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "ClearNationality"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Clears the models.
    ''' </summary>
    Sub ClearModels()
        Try
            Dim strTable As String = "Gun_Model"
            Dim strCollectionID As String = "ModelID"
            Dim strID As String = ""
            Dim SQL As String = "SELECT " & strTable & ".*  from " & strTable & " Inner Join Gun_Collection on Gun_Collection." & strCollectionID & " =" & strTable & ".ID"
            If DataIsRelated(SQL) Then
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                SQL = "SELECT ID from " & strTable
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                While RS.Read()
                    strID = CStr(RS("ID"))
                    If Not ExistsinCollection(strID, strCollectionID) Then Call DELETE_RECORD(strTable, strID)
                End While
                RS.Close()
                RS = Nothing
                Obj.CloseDB()
            Else
                Call KillData(strTable)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "ClearModels"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Clears the manufacturers.
    ''' </summary>
    Sub ClearManufacturers()
        Try
            Dim strTable As String = "Gun_Manufacturer"
            Dim strCollectionID As String = "MID"
            Dim strID As String = ""
            Dim SQL As String = "SELECT " & strTable & ".*  from " & strTable & " Inner Join Gun_Collection on Gun_Collection." & strCollectionID & " =" & strTable & ".ID"
            If DataIsRelated(SQL) Then
                Dim Obj As New BSDatabase
                Call Obj.ConnectDB()
                SQL = "SELECT ID from " & strTable
                Dim CMD As New OdbcCommand(SQL, Obj.Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                While RS.Read()
                    strID = CStr(RS("ID"))
                    If Not ExistsinCollection(strID, strCollectionID) Then Call DELETE_RECORD(strTable, strID)
                End While
                RS.Close()
                RS = Nothing
                Obj.CloseDB()
            Else
                Call KillData(strTable)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "ClearManufacturers"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Clears the collection.
    ''' </summary>
    Sub ClearCollection()
        Call KillData("Gun_Collection_Accessories")
        Call KillData("Gun_Collection_Pictures")
        Call KillData("Maintance_Details")
        Call KillData("GunSmith_Details")
        Call KillData("Gun_Collection_Ext")
        Call KillData("Gun_Collection")
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
        i = 0
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
    ''' Converts to progbar.
    ''' </summary>
    ''' <param name="strMsg">The string MSG.</param>
    Sub AddToProgBar(ByVal strMsg As String)
        'Try
        lblStatus.Text = strMsg
        lblStatus.Refresh()
        i = i + 1
        ProgressBar1.Value = i
        ProgressBar1.Refresh()
        'Catch ex As Exception

        'End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnStart control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
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
    Private Sub frmDBCleanup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class