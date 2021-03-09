Imports System.Data
Imports System.IO
Imports System.Xml
Imports System.Xml.XPath
Imports System.Net
Imports MyGunCollection_DataLoader.Database_Updates
Public Class frmDownloadUpdates
    Public errMsg As String = ""
    Public NoErrors As Boolean = False
    'Download Data from burnsoft.net web services
    Sub DownloadDataSet(ByVal sMsg As String, ByVal sDataSet As String, ByVal iStatus As Integer)
        Try
            Application.DoEvents()
            Dim Obj As New MyGunCollectionDatabaseUpdate
            If LCase(sDataSet) = LCase("Gun_Model") Then
                Obj.Timeout = WEBSERVICETIMEOUT * 2
                lblStatusMsg.Text = sMsg & " (this will take awhile)."
            Else
                Obj.Timeout = WEBSERVICETIMEOUT
                lblStatusMsg.Text = sMsg
            End If
            lblStatusMsg.Refresh()
            Dim i As Integer = 1
            Dim RS As New DataSet

            Select Case LCase(sDataSet)
                Case LCase("Gun_Cal")
                    RS = Obj.Gun_Cal
                    RS.WriteXml(APPLICATION_PATH_DATA & "\" & DL_AMMO, XmlWriteMode.WriteSchema)
                Case LCase("Gun_GripType")
                    RS = Obj.Gun_GripType
                    RS.WriteXml(APPLICATION_PATH_DATA & "\" & DL_GRIPS, XmlWriteMode.WriteSchema)
                Case LCase("Gun_Manufacturer")
                    RS = Obj.Gun_Manufacturer
                    RS.WriteXml(APPLICATION_PATH_DATA & "\" & DL_MANU, XmlWriteMode.WriteSchema)
                Case LCase("Gun_Model")
                    RS = Obj.Gun_Model
                    RS.WriteXml(APPLICATION_PATH_DATA & "\" & DL_MOD, XmlWriteMode.WriteSchema)
                Case LCase("Gun_Nationality")
                    RS = Obj.Gun_Nationality
                    RS.WriteXml(APPLICATION_PATH_DATA & "\" & DL_NAT, XmlWriteMode.WriteSchema)
                Case LCase("Gun_Type")
                    RS = Obj.Gun_Type
                    RS.WriteXml(APPLICATION_PATH_DATA & "\" & DL_TYPES, XmlWriteMode.WriteSchema)
                Case LCase("Maintance_Plans")
                    RS = Obj.Maintance_Plans
                    RS.WriteXml(APPLICATION_PATH_DATA & "\" & DL_MAINT, XmlWriteMode.WriteSchema)
                    'Case LCase("")
            End Select
            ProgressBar1.Value = iStatus
            ProgressBar1.Refresh()
            Me.Refresh()
            Application.DoEvents()
            RS = Nothing
            Obj = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "DownloadDataSet"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Start the process of what to download 
    Function DoUpdates() As Integer
        Try
            Dim i As Integer = 1
            Me.Cursor = Cursors.WaitCursor
            Timer1.Enabled = False
            lblStatusMsg.Text = "Connected Found!  Downloading Updates."
            ProgressBar1.Maximum = 8
            ProgressBar1.Minimum = 0
            ProgressBar1.Value = i
            ProgressBar1.Refresh()
            If bAmmo Then Call DownloadDataSet("Downloading Ammunition Calibers", "Gun_Cal", 2)
            If bGripType Then Call DownloadDataSet("Downloading Grip Types", "Gun_GripType", 3)
            If bManufacturer Then Call DownloadDataSet("Downloading Manufacturers", "Gun_Manufacturer", 4)
            If BNationality Then Call DownloadDataSet("Downloading Manufacturers Nationality", "Gun_Nationality", 5)
            If bType Then Call DownloadDataSet("Downloading Firearm Types", "Gun_Type", 6)
            If BMaintPlan Then DownloadDataSet("Downloading Maintenance Plans", "Maintance_Plans", 7)
            If bModel Then Call DownloadDataSet("Downloading Models", "Gun_Model", 8)
            NoErrors = False
            Me.Cursor = Cursors.Arrow
            Return 0
        Catch ex As Exception
            Dim sSubFunc As String = "DoUpdates"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
            NoErrors = True
            errMsg = ex.Message.ToString
            ProgressBar1.Visible = False
            Return Err.Number
        End Try
    End Function
    'Actions on Form Load
    Private Sub frmDownloadUpdates_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        lblTitle.Text = Application.ProductName
        Me.Text = Application.ProductName
        Timer1.Enabled = True
    End Sub
    'Set the timer to show the status of the update, or a guestament of it.
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If DoUpdates() = 0 Then
            frmApplyUpdates.Show()
            Me.Close()
        Else
            MsgBox(errMsg & Chr(13) & "Please check your internet connection or try again later.")
            Me.Close()
        End If
    End Sub
End Class