'TODO #43 Remove Unused Code
'Imports BSMyGunCollection.MGC
Imports BurnSoft.Applications.MGC.Ammo

''' <summary>
''' Class frmAddAmmo. Form to Add Ammo to the Main List to select from for inventory and firearms
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
' ReSharper disable once InconsistentNaming
Public Class frmAddAmmo
    ''' <summary>
    ''' Handles the Load event of the frmAddAmmo control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddAmmo_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            'Dim ObjAC As New AutoFillCollections
            'txtAmmo.AutoCompleteCustomSource = ObjAC.Gun_Cal
            Dim errOut As String = ""
            txtAmmo.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Ammo.Caliber(DatabasePath, errOut)
            if (errOut.Length > 0) Then Throw New Exception(errOut)
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the Button1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            'Dim ObjGF As New GlobalFunctions
            'Dim Obj As New BSDatabase
            'Dim strTableName As String = "Gun_Cal"
            'Dim strFieldName As String = "Cal"
            'Dim strAmmo As String = Trim(Replace(txtAmmo.Text, "'", "''"))
            Dim strAmmo As String = FluffContent(txtAmmo.Text)
            Dim errOut as String = ""
            'If Not ObjGF.ObjectExistsinDB(strAmmo, strFieldName, strTableName) Then
            '    Obj.ConnExec("INSERT INTO " & strTableName & "(" & strFieldName & ",sync_lastupdate) VALUES('" & strAmmo & "',Now())")
            '    txtAmmo.Text = ""
            '    Label1.Text = strAmmo & " was added!"
            'Else
            '    txtAmmo.Text = ""
            '    Label1.Text = strAmmo & " already existed!"
            'End If
            txtAmmo.Text = ""
            if Not GlobalList.Exists(DatabasePath, strAmmo, errOut ) Then
                If Not GlobalList.Add(DatabasePath, strAmmo, errOut) then Throw New Exception(errOut)
' ReSharper disable once LocalizableElement
                Label1.Text = strAmmo & " was added!"
            Else 
' ReSharper disable once LocalizableElement
                Label1.Text = strAmmo & " already existed!"
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "Button1.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the Button2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class