Imports Microsoft.Reporting.WinForms
''' <summary>
''' Class FrmViewReportBoundBook.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewReportBoundBook
    ''' <summary>
    ''' The is first run
    ''' </summary>
    Public IsFirstRun As Boolean
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim reportTitle As String = ToolStripTextBox1.Text
            Dim parmList As New List(Of ReportParameter)
            parmList.Add(New ReportParameter("UserName", OwnerName))
            parmList.Add(New ReportParameter("ReportTitle", reportTitle))
            parmList.Add(New ReportParameter("License", OwnerLic))
            ReportViewer1.LocalReport.SetParameters(parmList)
            Select Case LCase(UCase(ToolStripComboBox1.SelectedItem.ToString))
                Case LCase("Custom Catalog No.")
                    BoundBooksTableAdapter.FillByCustomID(MGCDataSet.BoundBooks)
                Case LCase("Purchase Date")
                    BoundBooksTableAdapter.FillByPurchaseDate(MGCDataSet.BoundBooks)
                Case LCase("C & R Only")
                    BoundBooksTableAdapter.FillByCAndR(MGCDataSet.BoundBooks)
                Case LCase("Brand")
                    BoundBooksTableAdapter.FillByBrand(MGCDataSet.BoundBooks)
                Case LCase("Type")
                    BoundBooksTableAdapter.FillByType(MGCDataSet.BoundBooks)
                Case LCase("Caliber")
                    BoundBooksTableAdapter.FillByCaliber(MGCDataSet.BoundBooks)
                Case LCase("Gun Shop")
                    BoundBooksTableAdapter.FillByGun_Shop_Name(MGCDataSet.BoundBooks)
                Case LCase("Class III")
                    BoundBooksTableAdapter.FillBy_ClassIII(MGCDataSet.BoundBooks)
                Case Else
                    BoundBooksTableAdapter.Fill(MGCDataSet.BoundBooks)
            End Select
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewReport_BoundBook control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewReport_BoundBook_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            ToolStripTextBox1.Text = $"Bound Book for " & OwnerName
            ReportViewer1.RefreshReport()
            Call LoadData()
            ReportViewer1.Cursor = Cursors.Arrow
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        IsFirstRun = False
    End Sub
    ''' <summary>
    ''' Handles the SelectedIndexChanged event of the ToolStripComboBox1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            If Not IsFirstRun Then Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripComboBox1_SelectedIndexChanged"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Initializes a new instance of the <see cref="FrmViewReportBoundBook"/> class.
    ''' </summary>
    Public Sub New()
        IsFirstRun = True
        InitializeComponent()
    End Sub
End Class