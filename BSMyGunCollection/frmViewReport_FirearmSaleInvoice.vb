Imports BSMyGunCollection.MGC
Imports Microsoft.Reporting.WinForms
''' <summary>
''' Class FrmViewReportFirearmSaleInvoice.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewReportFirearmSaleInvoice
    ''' <summary>
    ''' The firearm identifier
    ''' </summary>
    Public FirearmId As Long
    ''' <summary>
    ''' The user identifier
    ''' </summary>
    Public UserId As Long
    ''' <summary>
    ''' Gets the data.
    ''' </summary>
    Sub GetData()
        Dim ownerRecId As Long = 0
        Dim ownerName As String = ""
        Dim ownerAddress As String = ""
        Dim ownerCity As String = ""
        Dim ownerState As String = ""
        Dim ownerZip As String = ""
        Dim ownerPhone As String = ""
        Dim ownerCcd As String = ""
        Dim obj As New GlobalFunctions
        obj.GetUserSettingsDB(ownerRecId, ownerName, ownerAddress, ownerCity, ownerState, ownerZip, ownerPhone, ownerCcd)
        Dim parmList As New List(Of ReportParameter)
        parmList.Add(New ReportParameter("OWNER_Name", ownerName))
        parmList.Add(New ReportParameter("OWNER_Address", ownerAddress))
        parmList.Add(New ReportParameter("OWNER_City", ownerCity))
        parmList.Add(New ReportParameter("OWNER_State", ownerState))
        parmList.Add(New ReportParameter("OWNER_ZIP", ownerZip))
        parmList.Add(New ReportParameter("OWNER_Phone", ownerPhone))
        parmList.Add(New ReportParameter("OWNER_CCD", ownerCcd))
        parmList.Add(New ReportParameter("USER_ID", UserId))
        parmList.Add(New ReportParameter("FIREARM_ID", FirearmId))
        ReportViewer1.LocalReport.SetParameters(parmList)
        Gun_Collection_SoldToTableAdapter.Fill(MGCDataSet.Gun_Collection_SoldTo)
        ForSaleDataTableAdapter.Fill(MGCDataSet.ForSaleData)

        ReportViewer1.RefreshReport()
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_FirearmSaleInvoice control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_FirearmSaleInvoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call GetData()
    End Sub
End Class