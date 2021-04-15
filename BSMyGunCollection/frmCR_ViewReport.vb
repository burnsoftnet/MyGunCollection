Imports BSMyGunCollection.MGC
Imports BurnSoft.Universal
Imports BurnSoft.Applications.MGC.Reports

''' <summary>
''' Class frmCR_ViewReport.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmCrViewReport
    ''' <summary>
    ''' The error out'
    ''' </summary>
    Dim _errOut as String
    ''' <summary>
    ''' The SQL
    ''' </summary>
    Public Sql As String
    ''' <summary>
    ''' The grid printer
    ''' </summary>
    Private _gridPrinter As DataGridPrinter
    ''' <summary>
    ''' My data table
    ''' </summary>
    Private _myDataTable As DataTable
    ''' <summary>
    ''' The report name
    ''' </summary>
    Public ReportName As String
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim obj As New BSDatabase
            _myDataTable = obj.GetData(Sql)
            _myDataTable.TableName = "MyCustomReport"
            With DataGrid1
                .DataSource = _myDataTable
                .BorderStyle = BorderStyle.Fixed3D
            End With
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmCR_ViewReport control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmCR_ViewReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Len(ReportName) > 0 Then TextBox1.Text = ReportName
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton1_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click
        Try
            If _gridPrinter Is Nothing Then
                _gridPrinter = New DataGridPrinter(DataGrid1)
            End If

            With PageSetupDialog1
                .Document = _gridPrinter.PrintDocument
                .ShowDialog()
            End With
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton1.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton2_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        Try
            If _gridPrinter Is Nothing Then
                _gridPrinter = New DataGridPrinter(DataGrid1)
            End If

            With _gridPrinter
                .HeaderText = TextBox1.Text
                .HeaderHeightPercent = CInt(NumericUpDown_HeaderHeightPercentage.Value)
                .FooterHeightPercent = CInt(NumericUpDown_FooterHeightPercent.Value)
                .InterSectionSpacingPercent = CInt(NumericUpDown_InterSectionSpacingPercent.Value)
                .HeaderPen = New Pen(CType(ComboBox_ColourHeaderLine.SelectedItem, Color))
                .FooterPen = New Pen(CType(ComboBox_ColourFooterLine.SelectedItem, Color))
                .GridPen = New Pen(CType(ComboBox_ColourBodyline.SelectedItem, Color))
                .HeaderBrush = CType(ComboBox_HeaderBrush.SelectedItem, Brush)
                .EvenRowBrush = CType(ComboBox_EvenBrush.SelectedItem, Brush)
                .OddRowBrush = CType(ComboBox_OddRowBrush.SelectedItem, Brush)
                .FooterBrush = CType(ComboBox_FooterBrush.SelectedItem, Brush)
                .ColumnHeaderBrush = CType(ComboBox_ColumnHeaderBrush.SelectedItem, Brush)
                .PagesAcross = CInt(NumericUpDown_PagesAcross.Value)
            End With

            With PrintPreviewDialog1
                .Document = _gridPrinter.PrintDocument
                If .ShowDialog = DialogResult.OK Then
                    _gridPrinter.Print()
                End If
            End With
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton2.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
#Region " Windows Form Designer generated code "
    ''' <summary>
    ''' Initializes a new instance of the <see cref="FrmCrViewReport"/> class.
    ''' </summary>
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        Call PopulateColourList(ComboBox_ColourBodyline)
        Call PopulateColourList(ComboBox_ColourFooterLine)
        Call PopulateColourList(ComboBox_ColourHeaderLine)

        Call PopulateBrushList(ComboBox_EvenBrush)
        Call PopulateBrushList(ComboBox_FooterBrush)
        Call PopulateBrushList(ComboBox_HeaderBrush)
        Call PopulateBrushList(ComboBox_OddRowBrush)
        Call PopulateBrushList(ComboBox_ColumnHeaderBrush)
    End Sub
#End Region
#Region "Private methods"
    ''' <summary>
    ''' Populates the colour list.
    ''' </summary>
    ''' <param name="combo">The combo.</param>
    Private Sub PopulateColourList(ByVal combo As ComboBox)

        combo.Items.Clear()
        combo.Items.Add(Color.AliceBlue)
        combo.Items.Add(Color.Aqua)
        combo.Items.Add(Color.Azure)
        combo.Items.Add(Color.Beige)
        combo.Items.Add(Color.Black)
        combo.Items.Add(Color.Blue)
        combo.Items.Add(Color.Green)
        combo.Items.Add(Color.Red)
        combo.SelectedIndex = 0
    End Sub
    ''' <summary>
    ''' Populates the brush list.
    ''' </summary>
    ''' <param name="combo">The combo.</param>
    Private Sub PopulateBrushList(ByVal combo As ComboBox)
        combo.Items.Clear()
        combo.Items.Add(Brushes.White)
        combo.Items.Add(Brushes.Beige)
        combo.Items.Add(Brushes.Bisque)
        combo.Items.Add(Brushes.BlanchedAlmond)
        combo.Items.Add(Brushes.Blue)
        combo.Items.Add(Brushes.BlueViolet)
        combo.Items.Add(Brushes.Brown)
        combo.Items.Add(Brushes.BurlyWood)
        combo.Items.Add(Brushes.CadetBlue)
        combo.Items.Add(Brushes.Chartreuse)
        combo.Items.Add(Brushes.Chocolate)
        combo.Items.Add(Brushes.Coral)
        combo.Items.Add(Brushes.CornflowerBlue)
        combo.Items.Add(Brushes.Cornsilk)
        combo.Items.Add(Brushes.Crimson)
        combo.Items.Add(Brushes.Cyan)
        combo.SelectedIndex = 0
    End Sub
#End Region

    ''' <summary>
    ''' Converts to olstripbutton3_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton3.Click
        Try
' ReSharper disable once LocalVariableHidesMember
            Dim reportName As String = TextBox1.Text
            Dim  objF as BSOtherObjects = New BSOtherObjects()

            If CustomReports.Exists(DatabasePath, reportName, _errOut) Then
                Dim sAns As String = MsgBox("Report Name """ & reportName & """ already exists in the database!" & Chr(10) & "Do you wish to overwrite existing report?", MsgBoxStyle.YesNo, Text)
                If sAns = vbYes Then
                    Dim id as  Long = CustomReports.GetId(DatabasePath, reportName, _errOut)
                    If Not CustomReports.Update(DatabasePath,id, reportName,objF.FC(Sql), _errOut ) Then Throw New Exception(_errOut)
                    MsgBox("The Report was Updated!")
                Else
                    MsgBox("Save Aborted!")
                End If
            Else 
                If Not CustomReports.Add(DatabasePath, reportName, objF.FC(sql), _errOut) Then Throw New Exception(_errOut)
                MsgBox("The Report was Saved!")
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton3.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ExcelToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExcelToolStripMenuItem.Click
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.Filter = CustomReports.FileTypes
        SaveFileDialog1.Title = $"Export Data to Excel"
        SaveFileDialog1.FileName = Replace(ReportName, " ", "_")
        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
        Dim strFilePath As String = SaveFileDialog1.FileName
        Call ExportExcel(_myDataTable, strFilePath)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub TXTToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TXTToolStripMenuItem.Click
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.Filter =CustomReports.FileTypes
        SaveFileDialog1.Title = $"Export Data to Text File"
        SaveFileDialog1.FileName = Replace(ReportName, " ", "_")
        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
        Dim strFilePath As String = SaveFileDialog1.FileName
        Call ExportText(_myDataTable, strFilePath)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub CVSToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CVSToolStripMenuItem.Click
        SaveFileDialog1.FilterIndex = 5
        SaveFileDialog1.Filter =CustomReports.FileTypes
        SaveFileDialog1.Title = $"Export Data to CVS File"
        SaveFileDialog1.FileName = Replace(ReportName, " ", "_")
        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
        Dim strFilePath As String = SaveFileDialog1.FileName
        Call ExportCsv(_myDataTable, strFilePath)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub HTMLToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles HTMLToolStripMenuItem.Click
        SaveFileDialog1.FilterIndex = 4
        SaveFileDialog1.Filter = CustomReports.FileTypes
        SaveFileDialog1.Title = $"Export Data to HTML File"
        SaveFileDialog1.FileName = Replace(ReportName, " ", "_")
        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
        Dim strFilePath As String = SaveFileDialog1.FileName
        Call ExportHtml(_myDataTable, strFilePath)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub XMLToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles XMLToolStripMenuItem.Click
        SaveFileDialog1.FilterIndex = 3
        SaveFileDialog1.Filter = CustomReports.FileTypes
        SaveFileDialog1.Title = $"Export Data to XML File"
        SaveFileDialog1.FileName = Replace(ReportName, " ", "_")
        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
        Dim strFilePath As String = SaveFileDialog1.FileName
        Call ExportXml(_myDataTable, strFilePath)
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmCR_ViewReport control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmCR_ViewReport_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        DataGrid1.Height = GroupBox5.Location.Y - 31
    End Sub
End Class