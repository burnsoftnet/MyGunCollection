Imports BSMyGunCollection.MGC
Imports BSMyGunCollection.ExportModule
''' <summary>
''' Class frmCR_ViewReport.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmCR_ViewReport
    ''' <summary>
    ''' The SQL
    ''' </summary>
    Public SQL As String
    ''' <summary>
    ''' The grid printer
    ''' </summary>
    Private GridPrinter As DataGridPrinter
    ''' <summary>
    ''' My data table
    ''' </summary>
    Private MyDataTable As DataTable
    ''' <summary>
    ''' The report name
    ''' </summary>
    Public ReportName As String
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim Obj As New BSDatabase
            MyDataTable = Obj.GetData(SQL)
            MyDataTable.TableName = "MyCustomReport"
            With DataGrid1
                .DataSource = MyDataTable
                .BorderStyle = BorderStyle.Fixed3D
            End With
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmCR_ViewReport control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmCR_ViewReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Len(ReportName) > 0 Then TextBox1.Text = ReportName
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton1_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            If GridPrinter Is Nothing Then
                GridPrinter = New DataGridPrinter(Me.DataGrid1)
            End If

            With Me.PageSetupDialog1
                .Document = GridPrinter.PrintDocument
                .ShowDialog()
            End With
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton1.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton2_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            If GridPrinter Is Nothing Then
                GridPrinter = New DataGridPrinter(Me.DataGrid1)
            End If

            With GridPrinter
                .HeaderText = Me.TextBox1.Text
                .HeaderHeightPercent = CInt(Me.NumericUpDown_HeaderHeightPercentage.Value)
                .FooterHeightPercent = CInt(Me.NumericUpDown_FooterHeightPercent.Value)
                .InterSectionSpacingPercent = CInt(Me.NumericUpDown_InterSectionSpacingPercent.Value)
                .HeaderPen = New Pen(CType(Me.ComboBox_ColourHeaderLine.SelectedItem, System.Drawing.Color))
                .FooterPen = New Pen(CType(Me.ComboBox_ColourFooterLine.SelectedItem, System.Drawing.Color))
                .GridPen = New Pen(CType(Me.ComboBox_ColourBodyline.SelectedItem, System.Drawing.Color))
                .HeaderBrush = CType(Me.ComboBox_HeaderBrush.SelectedItem, Brush)
                .EvenRowBrush = CType(Me.ComboBox_EvenBrush.SelectedItem, Brush)
                .OddRowBrush = CType(Me.ComboBox_OddRowBrush.SelectedItem, Brush)
                .FooterBrush = CType(Me.ComboBox_FooterBrush.SelectedItem, Brush)
                .ColumnHeaderBrush = CType(Me.ComboBox_ColumnHeaderBrush.SelectedItem, Brush)
                .PagesAcross = CInt(Me.NumericUpDown_PagesAcross.Value)
            End With

            With Me.PrintPreviewDialog1
                .Document = GridPrinter.PrintDocument
                If .ShowDialog = DialogResult.OK Then
                    GridPrinter.Print()
                End If
            End With
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton2.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        Call PopulateColourList(Me.ComboBox_ColourBodyline)
        Call PopulateColourList(Me.ComboBox_ColourFooterLine)
        Call PopulateColourList(Me.ComboBox_ColourHeaderLine)

        Call PopulateBrushList(Me.ComboBox_EvenBrush)
        Call PopulateBrushList(Me.ComboBox_FooterBrush)
        Call PopulateBrushList(Me.ComboBox_HeaderBrush)
        Call PopulateBrushList(Me.ComboBox_OddRowBrush)
        Call PopulateBrushList(Me.ComboBox_ColumnHeaderBrush)
    End Sub
#End Region
#Region "Private methods"
    Private Sub PopulateColourList(ByVal combo As ComboBox)

        combo.Items.Clear()
        combo.Items.Add(System.Drawing.Color.AliceBlue)
        combo.Items.Add(System.Drawing.Color.Aqua)
        combo.Items.Add(System.Drawing.Color.Azure)
        combo.Items.Add(System.Drawing.Color.Beige)
        combo.Items.Add(System.Drawing.Color.Black)
        combo.Items.Add(System.Drawing.Color.Blue)
        combo.Items.Add(System.Drawing.Color.Green)
        combo.Items.Add(System.Drawing.Color.Red)
        combo.SelectedIndex = 0
    End Sub

    Private Sub PopulateBrushList(ByVal Combo As ComboBox)
        Combo.Items.Clear()
        Combo.Items.Add(System.Drawing.Brushes.White)
        Combo.Items.Add(System.Drawing.Brushes.Beige)
        Combo.Items.Add(System.Drawing.Brushes.Bisque)
        Combo.Items.Add(System.Drawing.Brushes.BlanchedAlmond)
        Combo.Items.Add(System.Drawing.Brushes.Blue)
        Combo.Items.Add(System.Drawing.Brushes.BlueViolet)
        Combo.Items.Add(System.Drawing.Brushes.Brown)
        Combo.Items.Add(System.Drawing.Brushes.BurlyWood)
        Combo.Items.Add(System.Drawing.Brushes.CadetBlue)
        Combo.Items.Add(System.Drawing.Brushes.Chartreuse)
        Combo.Items.Add(System.Drawing.Brushes.Chocolate)
        Combo.Items.Add(System.Drawing.Brushes.Coral)
        Combo.Items.Add(System.Drawing.Brushes.CornflowerBlue)
        Combo.Items.Add(System.Drawing.Brushes.Cornsilk)
        Combo.Items.Add(System.Drawing.Brushes.Crimson)
        Combo.Items.Add(System.Drawing.Brushes.Cyan)
        Combo.SelectedIndex = 0
    End Sub
#End Region
    ''' <summary>
    ''' Handles the DrawItem event of the ComboBox_EvenBrush control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.DrawItemEventArgs"/> instance containing the event data.</param>
    Private Sub ComboBox_EvenBrush_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        e.Graphics.FillRectangle(CType(ComboBox_EvenBrush.Items(e.Index), Brush), e.Bounds)
        e.Graphics.DrawRectangle(System.Drawing.Pens.Black, e.Bounds)
    End Sub
    ''' <summary>
    ''' Handles the DrawItem event of the ComboBox_FooterBrush control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.DrawItemEventArgs"/> instance containing the event data.</param>
    Private Sub ComboBox_FooterBrush_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        e.Graphics.FillRectangle(CType(ComboBox_FooterBrush.Items(e.Index), Brush), e.Bounds)
        e.Graphics.DrawRectangle(System.Drawing.Pens.Black, e.Bounds)
    End Sub
    ''' <summary>
    ''' Handles the DrawItem event of the ComboBox_OddRowBrush control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.DrawItemEventArgs"/> instance containing the event data.</param>
    Private Sub ComboBox_OddRowBrush_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)

        e.Graphics.FillRectangle(CType(ComboBox_OddRowBrush.Items(e.Index), Brush), e.Bounds)
        e.Graphics.DrawRectangle(System.Drawing.Pens.Black, e.Bounds)

    End Sub
    ''' <summary>
    ''' Handles the DrawItem event of the ComboBox_HeaderBrush control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.DrawItemEventArgs"/> instance containing the event data.</param>
    Private Sub ComboBox_HeaderBrush_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        e.Graphics.FillRectangle(CType(ComboBox_HeaderBrush.Items(e.Index), Brush), e.Bounds)
        e.Graphics.DrawRectangle(System.Drawing.Pens.Black, e.Bounds)
    End Sub
    ''' <summary>
    ''' Handles the DrawItem event of the ComboBox_ColumnHeaderBrush control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.Windows.Forms.DrawItemEventArgs"/> instance containing the event data.</param>
    Private Sub ComboBox_ColumnHeaderBrush_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        e.Graphics.FillRectangle(CType(ComboBox_ColumnHeaderBrush.Items(e.Index), Brush), e.Bounds)
        e.Graphics.DrawRectangle(System.Drawing.Pens.Black, e.Bounds)
    End Sub
    ''' <summary>
    ''' Converts to olstripbutton3_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try
            Dim ReportName As String = TextBox1.Text
            Dim Obj As New BSDatabase
            Dim ObjGF As New GlobalFunctions
            Dim MySQL As String = ""
            If ObjGF.ObjectExistsinDB(ReportName, "ReportName", "CR_SavedReports") Then
                Dim sAns As String = MsgBox("Report Name """ & ReportName & """ already exists in the database!" & Chr(10) & "Do you wish to overwrite existing report?", MsgBoxStyle.YesNo, Me.Text)
                If sAns = vbYes Then
                    MySQL = "UPDATE CR_SavedReports set MySQL='" & Replace(SQL, "'", "''") & "',sync_lastupdate=Now() where ReportName='" & ReportName & "'"
                    Obj.ConnExec(MySQL)
                    MsgBox("The Report was Updated!")
                Else
                    MsgBox("Save Aborted!")
                End If
            Else
                MySQL = "INSERT INTO CR_SavedReports (ReportName,MySQL,DTC,sync_lastupdate) VALUES('" & ReportName & "','" &
                            Replace(SQL, "'", "''") & "','" & Now & "',Now())"
                Obj.ConnExec(MySQL)
                MsgBox("The Report was Saved!")
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton3.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelToolStripMenuItem.Click
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.Filter = "Excel File(*.xls)|*.xls|Text File(*.txt)|*.txt|XML File(*.xml)|*.xml|HTML File(*.html)|*.html|CVS File(*.cvs)|*.cvs"
        SaveFileDialog1.Title = "Export Data to Excel"
        SaveFileDialog1.FileName = Replace(ReportName, " ", "_")
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim strFilePath As String = SaveFileDialog1.FileName
        Call ExportExcel(MyDataTable, strFilePath)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub TXTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTToolStripMenuItem.Click
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.Filter = "Excel File(*.xls)|*.xls|Text File(*.txt)|*.txt|XML File(*.xml)|*.xml|HTML File(*.html)|*.html|CVS File(*.cvs)|*.cvs"
        SaveFileDialog1.Title = "Export Data to Text File"
        SaveFileDialog1.FileName = Replace(ReportName, " ", "_")
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim strFilePath As String = SaveFileDialog1.FileName
        Call ExportText(MyDataTable, strFilePath)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub CVSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CVSToolStripMenuItem.Click
        SaveFileDialog1.FilterIndex = 5
        SaveFileDialog1.Filter = "Excel File(*.xls)|*.xls|Text File(*.txt)|*.txt|XML File(*.xml)|*.xml|HTML File(*.html)|*.html|CSV File(*.csv)|*.csv"
        SaveFileDialog1.Title = "Export Data to CVS File"
        SaveFileDialog1.FileName = Replace(ReportName, " ", "_")
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim strFilePath As String = SaveFileDialog1.FileName
        Call ExportCSV(MyDataTable, strFilePath)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub HTMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HTMLToolStripMenuItem.Click
        SaveFileDialog1.FilterIndex = 4
        SaveFileDialog1.Filter = "Excel File(*.xls)|*.xls|Text File(*.txt)|*.txt|XML File(*.xml)|*.xml|HTML File(*.html)|*.html|CSV File(*.csv)|*.csv"
        SaveFileDialog1.Title = "Export Data to HTML File"
        SaveFileDialog1.FileName = Replace(ReportName, " ", "_")
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim strFilePath As String = SaveFileDialog1.FileName
        Call ExportHTML(MyDataTable, strFilePath)
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub XMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XMLToolStripMenuItem.Click
        SaveFileDialog1.FilterIndex = 3
        SaveFileDialog1.Filter = "Excel File(*.xls)|*.xls|Text File(*.txt)|*.txt|XML File(*.xml)|*.xml|HTML File(*.html)|*.html|CSV File(*.csv)|*.csv"
        SaveFileDialog1.Title = "Export Data to XML File"
        SaveFileDialog1.FileName = Replace(ReportName, " ", "_")
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim strFilePath As String = SaveFileDialog1.FileName
        Call ExportXML(MyDataTable, strFilePath)
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmCR_ViewReport control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmCR_ViewReport_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        DataGrid1.Height = GroupBox5.Location.Y - 31
    End Sub
End Class