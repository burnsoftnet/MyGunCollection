Imports BSMyGunCollection.MGC
Public Class BSRegistration
    Public StatusMessage As String
    Public MainFormUnloaded As Boolean
    'Put up the status message when the form loads
    Private Sub BSRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblApplicationStatus.Text = StatusMessage
    End Sub
    'When the Register button is click, start the process to see if it is valid and warn the user if it is not
    'or thank the user for their purchase.
    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Dim sKey As String
        Dim oReg As New Cyhper.CGenericRegistration
        Dim oRP As New Cyhper.RegistrationProcess
        Dim MyReg As New BSRegistry
        Dim sMessage As String = ""
        sKey = Replace(txtRegKey.Text, "-", "")
        If oReg.IsKeyOK(sKey, oRP.RegistrationKeyValue) Then
            Call oRP.DeleteInstalledBefore()
            Call MyReg.SetSettingDetails()
            oRP.JustSave(oRP.DefaultRegPath & "\Settings", txtRegName.Text, txtRegKey.Text)
            sMessage = "This is a valid Key!" & Chr(10)
            sMessage &= "Thank you for your purchase and we hope" & Chr(10)
            sMessage &= "you enjoy this application." & Chr(10)
            sMessage &= "Please restart the application for the changes to take place."
            MsgBox(sMessage, MsgBoxStyle.Information, "BurnSoft Registration")
            Global.System.Windows.Forms.Application.Exit()
        Else
            sMessage = "This is a invalid Key!" & Chr(10)
            sMessage &= "Please try again, or contact" & Chr(10)
            sMessage &= "Customer support to make sure that you have a valid" & Chr(10)
            sMessage &= "registration key." & Chr(10)
            MsgBox(sMessage, MsgBoxStyle.Critical, "BurnSoft Registration")
            Global.System.Windows.Forms.Application.Exit()
        End If
        oReg = Nothing
    End Sub
    'Cancel Button just in case the user decides not to register
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub
    'Action taken when the purchase button is clicked, it will take them to the purchase page.
    Private Sub btnPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchase.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = MENU_SHOP
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        myProcess.Start()
    End Sub
End Class