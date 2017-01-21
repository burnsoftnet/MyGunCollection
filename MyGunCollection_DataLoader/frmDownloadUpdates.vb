Imports System.Data
Imports System.IO
Imports System.Xml
Imports System.Xml.XPath
Imports System.net
Imports MyGunCollection_DataLoader.Database_Updates
Public Class frmDownloadUpdates
    Public errMsg As String = ""
    Public NoErrors As Boolean = False
    Sub DownloadDataSet(ByVal sMsg As String, ByVal sDataSet As String, ByVal iStatus As Integer)
        System.Windows.Forms.Application.DoEvents()
        Dim Obj As New Database_Updates.MyGunCollectionDatabaseUpdate
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
                RS.WriteXml(DL_AMMO, XmlWriteMode.WriteSchema)
            Case LCase("Gun_GripType")
                RS = Obj.Gun_GripType
                RS.WriteXml(DL_GRIPS, XmlWriteMode.WriteSchema)
            Case LCase("Gun_Manufacturer")
                RS = Obj.Gun_Manufacturer
                RS.WriteXml(DL_MANU, XmlWriteMode.WriteSchema)
            Case LCase("Gun_Model")
                RS = Obj.Gun_Model
                RS.WriteXml(DL_MOD, XmlWriteMode.WriteSchema)
            Case LCase("Gun_Nationality")
                RS = Obj.Gun_Nationality
                RS.WriteXml(DL_NAT, XmlWriteMode.WriteSchema)
            Case LCase("Gun_Type")
                RS = Obj.Gun_Type
                RS.WriteXml(DL_TYPES, XmlWriteMode.WriteSchema)
            Case LCase("Maintance_Plans")
                RS = Obj.Maintance_Plans
                RS.WriteXml(DL_MAINT, XmlWriteMode.WriteSchema)
                'Case LCase("")
        End Select
        ProgressBar1.Value = iStatus
        ProgressBar1.Refresh()
        Me.Refresh()
        System.Windows.Forms.Application.DoEvents()
        RS = Nothing
        Obj = Nothing
    End Sub
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
            If BMaintPlan Then DownloadDataSet("Downloading Maintanence Plans", "Maintance_Plans", 7)
            If bModel Then Call DownloadDataSet("Downloading Models", "Gun_Model", 8)
            NoErrors = False
            Me.Cursor = Cursors.Arrow
            Return 0
        Catch ex As Exception
            NoErrors = True
            errMsg = ex.Message.ToString
            ProgressBar1.Visible = False
            Return Err.Number
        End Try
    End Function
    Private Sub frmDownloadUpdates_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblTitle.Text = Application.ProductName
        Me.Text = Application.ProductName
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If DoUpdates() = 0 Then
            frmApplyUpdates.Show()
            Me.Close()
        Else
            MsgBox(errMsg & Chr(13) & "Please check your internet connection or try again later.")
            Me.Close()
        End If
    End Sub
End Class