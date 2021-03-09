Imports BSMyGunCollection.MGC
Imports Microsoft.Reporting.WinForms
Public Class frmViewReport_FirearmSaleInvoice
    Public FIREARM_ID As Long
    Public USER_ID As Long
    Sub GetData()
        Dim OWNER_RecID As Long = 0
        Dim OWNER_Name As String = ""
        Dim OWNER_Address As String = ""
        Dim OWNER_City As String = ""
        Dim OWNER_State As String = ""
        Dim OWNER_ZIP As String = ""
        Dim OWNER_Phone As String = ""
        Dim OWNER_CCD As String = ""
        Dim Obj As New GlobalFunctions
        Obj.GetUserSettingsDB(OWNER_RecID, OWNER_Name, OWNER_Address, OWNER_City, OWNER_State, OWNER_ZIP, OWNER_Phone, OWNER_CCD)
        Dim parmList As New List(Of ReportParameter)
        parmList.Add(New ReportParameter("OWNER_Name", OWNER_Name))
        parmList.Add(New ReportParameter("OWNER_Address", OWNER_Address))
        parmList.Add(New ReportParameter("OWNER_City", OWNER_City))
        parmList.Add(New ReportParameter("OWNER_State", OWNER_State))
        parmList.Add(New ReportParameter("OWNER_ZIP", OWNER_ZIP))
        parmList.Add(New ReportParameter("OWNER_Phone", OWNER_Phone))
        parmList.Add(New ReportParameter("OWNER_CCD", OWNER_CCD))
        parmList.Add(New ReportParameter("USER_ID", USER_ID))
        parmList.Add(New ReportParameter("FIREARM_ID", FIREARM_ID))
        Me.ReportViewer1.LocalReport.SetParameters(parmList)
        Me.Gun_Collection_SoldToTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_SoldTo)
        Me.ForSaleDataTableAdapter.Fill(Me.MGCDataSet.ForSaleData)

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub frmViewReport_FirearmSaleInvoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call GetData()
    End Sub
End Class