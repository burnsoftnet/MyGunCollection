Imports BurnSoft.Applications.MGC.Ammo
Imports BurnSoft.Applications.MGC.AutoFill

''' <summary>
''' Class frmAddAmmo. Form to Add Ammo to the Main List to select from for inventory and firearms
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddAmmo
    ''' <summary>
    ''' Handles the Load event of the frmAddAmmo control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddAmmo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim errOut As String = ""
            txtAmmo.AutoCompleteCustomSource = Ammo.Caliber(DatabasePath, errOut)
            if (errOut.Length > 0) Then Throw New Exception(errOut)
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the Button1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim strAmmo As String = FluffContent(txtAmmo.Text)
            Dim errOut as String = ""
            txtAmmo.Text = ""
            if Not GlobalList.Exists(DatabasePath, strAmmo, errOut ) Then
                If Not GlobalList.Add(DatabasePath, strAmmo, errOut) then Throw New Exception(errOut)
                Label1.Text = strAmmo & $" was added!"
            Else 
                Label1.Text = strAmmo & $" already existed!"
            End If
        Catch ex As Exception
            Call LogError(Name, "Button1.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the Button2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class