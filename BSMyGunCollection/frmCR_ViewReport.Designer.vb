Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmCR_ViewReport
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New Container
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmCR_ViewReport))
        Me.ToolStrip1 = New ToolStrip
        Me.ToolStripButton1 = New ToolStripButton
        Me.ToolStripButton2 = New ToolStripButton
        Me.ToolStripButton3 = New ToolStripButton
        Me.ToolStripSplitButton1 = New ToolStripSplitButton
        Me.ExcelToolStripMenuItem = New ToolStripMenuItem
        Me.TXTToolStripMenuItem = New ToolStripMenuItem
        Me.CVSToolStripMenuItem = New ToolStripMenuItem
        Me.HTMLToolStripMenuItem = New ToolStripMenuItem
        Me.XMLToolStripMenuItem = New ToolStripMenuItem
        Me.BindingSource1 = New BindingSource(Me.components)
        Me.PrintPreviewDialog1 = New PrintPreviewDialog
        Me.PageSetupDialog1 = New PageSetupDialog
        Me.DataGrid1 = New DataGrid
        Me.HelpProvider1 = New HelpProvider
        Me.SaveFileDialog1 = New SaveFileDialog
        Me.GroupBox5 = New GroupBox
        Me.GroupBox4 = New GroupBox
        Me.NumericUpDown_PagesAcross = New NumericUpDown
        Me.Label13 = New Label
        Me.GroupBox3 = New GroupBox
        Me.ComboBox_ColumnHeaderBrush = New ComboBox
        Me.Label12 = New Label
        Me.ComboBox_EvenBrush = New ComboBox
        Me.ComboBox_OddRowBrush = New ComboBox
        Me.Label8 = New Label
        Me.Label11 = New Label
        Me.ComboBox_FooterBrush = New ComboBox
        Me.ComboBox_HeaderBrush = New ComboBox
        Me.Label9 = New Label
        Me.Label10 = New Label
        Me.GroupBox2 = New GroupBox
        Me.ComboBox_ColourBodyline = New ComboBox
        Me.ComboBox_ColourFooterLine = New ComboBox
        Me.ComboBox_ColourHeaderLine = New ComboBox
        Me.Label5 = New Label
        Me.Label6 = New Label
        Me.Label7 = New Label
        Me.GroupBox1 = New GroupBox
        Me.NumericUpDown_InterSectionSpacingPercent = New NumericUpDown
        Me.Label4 = New Label
        Me.NumericUpDown_FooterHeightPercent = New NumericUpDown
        Me.Label3 = New Label
        Me.NumericUpDown_HeaderHeightPercentage = New NumericUpDown
        Me.Label2 = New Label
        Me.Label1 = New Label
        Me.TextBox1 = New TextBox
        Me.ToolStrip1.SuspendLayout()
        CType(Me.BindingSource1, ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NumericUpDown_PagesAcross, ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown_InterSectionSpacingPercent, ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_FooterHeightPercent, ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_HeaderHeightPercentage, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSplitButton1})
        Me.ToolStrip1.Location = New Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New Size(583, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        Me.ToolStripButton1.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New Size(23, 22)
        Me.ToolStripButton1.Text = "Print/Page Layout"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        Me.ToolStripButton2.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New Size(23, 22)
        Me.ToolStripButton2.Text = "Print Preview"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        Me.ToolStripButton3.ImageTransparentColor = Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New Size(23, 22)
        Me.ToolStripButton3.Text = "Save Report"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New ToolStripItem() {Me.ExcelToolStripMenuItem, Me.TXTToolStripMenuItem, Me.CVSToolStripMenuItem, Me.HTMLToolStripMenuItem, Me.XMLToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New Size(32, 22)
        Me.ToolStripSplitButton1.Text = "Export Results to File"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New Size(152, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'TXTToolStripMenuItem
        '
        Me.TXTToolStripMenuItem.Name = "TXTToolStripMenuItem"
        Me.TXTToolStripMenuItem.Size = New Size(152, 22)
        Me.TXTToolStripMenuItem.Text = "Text"
        '
        'CVSToolStripMenuItem
        '
        Me.CVSToolStripMenuItem.Name = "CVSToolStripMenuItem"
        Me.CVSToolStripMenuItem.Size = New Size(152, 22)
        Me.CVSToolStripMenuItem.Text = "CSV"
        '
        'HTMLToolStripMenuItem
        '
        Me.HTMLToolStripMenuItem.Name = "HTMLToolStripMenuItem"
        Me.HTMLToolStripMenuItem.Size = New Size(152, 22)
        Me.HTMLToolStripMenuItem.Text = "HTML"
        '
        'XMLToolStripMenuItem
        '
        Me.XMLToolStripMenuItem.Name = "XMLToolStripMenuItem"
        Me.XMLToolStripMenuItem.Size = New Size(152, 22)
        Me.XMLToolStripMenuItem.Text = "XML"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        Me.PrintPreviewDialog1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.PrintPreviewDialog1.ClientSize = New Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.HelpProvider1.SetHelpKeyword(Me.PrintPreviewDialog1, "Print Preview - Custom Reports")
        Me.HelpProvider1.SetHelpNavigator(Me.PrintPreviewDialog1, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me.PrintPreviewDialog1, "Print Preview - Custom Reports")
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.HelpProvider1.SetShowHelp(Me.PrintPreviewDialog1, True)
        Me.PrintPreviewDialog1.ShowIcon = False
        Me.PrintPreviewDialog1.Visible = False
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.ShowHelp = True
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = DockStyle.Top
        Me.DataGrid1.HeaderForeColor = SystemColors.ControlText
        Me.DataGrid1.Location = New Point(0, 25)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New Size(583, 200)
        Me.DataGrid1.TabIndex = 13
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((AnchorStyles.Bottom Or AnchorStyles.Left) _
                    Or AnchorStyles.Right), AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Controls.Add(Me.GroupBox3)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Location = New Point(12, 231)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New Size(555, 281)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Report Settings"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.NumericUpDown_PagesAcross)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New Point(6, 234)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New Size(536, 40)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Page layout"
        '
        'NumericUpDown_PagesAcross
        '
        Me.NumericUpDown_PagesAcross.Location = New Point(368, 10)
        Me.NumericUpDown_PagesAcross.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_PagesAcross.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_PagesAcross.Name = "NumericUpDown_PagesAcross"
        Me.NumericUpDown_PagesAcross.Size = New Size(48, 20)
        Me.NumericUpDown_PagesAcross.TabIndex = 3
        Me.NumericUpDown_PagesAcross.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.Location = New Point(24, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New Size(328, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Minimum number of pages across to split the columns over"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox_ColumnHeaderBrush)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.ComboBox_EvenBrush)
        Me.GroupBox3.Controls.Add(Me.ComboBox_OddRowBrush)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.ComboBox_FooterBrush)
        Me.GroupBox3.Controls.Add(Me.ComboBox_HeaderBrush)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New Point(6, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New Size(536, 56)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Grid background  colors"
        '
        'ComboBox_ColumnHeaderBrush
        '
        Me.ComboBox_ColumnHeaderBrush.DrawMode = DrawMode.OwnerDrawFixed
        Me.ComboBox_ColumnHeaderBrush.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox_ColumnHeaderBrush.Location = New Point(488, 24)
        Me.ComboBox_ColumnHeaderBrush.Name = "ComboBox_ColumnHeaderBrush"
        Me.ComboBox_ColumnHeaderBrush.Size = New Size(40, 21)
        Me.ComboBox_ColumnHeaderBrush.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.Location = New Point(424, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New Size(60, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Columns"
        '
        'ComboBox_EvenBrush
        '
        Me.ComboBox_EvenBrush.DrawMode = DrawMode.OwnerDrawFixed
        Me.ComboBox_EvenBrush.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox_EvenBrush.Location = New Point(368, 24)
        Me.ComboBox_EvenBrush.Name = "ComboBox_EvenBrush"
        Me.ComboBox_EvenBrush.Size = New Size(40, 21)
        Me.ComboBox_EvenBrush.TabIndex = 13
        '
        'ComboBox_OddRowBrush
        '
        Me.ComboBox_OddRowBrush.DrawMode = DrawMode.OwnerDrawFixed
        Me.ComboBox_OddRowBrush.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox_OddRowBrush.Location = New Point(256, 24)
        Me.ComboBox_OddRowBrush.Name = "ComboBox_OddRowBrush"
        Me.ComboBox_OddRowBrush.Size = New Size(40, 21)
        Me.ComboBox_OddRowBrush.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Location = New Point(304, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New Size(60, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Even rows"
        '
        'Label11
        '
        Me.Label11.Location = New Point(200, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New Size(56, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Odd rows"
        '
        'ComboBox_FooterBrush
        '
        Me.ComboBox_FooterBrush.DrawMode = DrawMode.OwnerDrawFixed
        Me.ComboBox_FooterBrush.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox_FooterBrush.Location = New Point(152, 24)
        Me.ComboBox_FooterBrush.Name = "ComboBox_FooterBrush"
        Me.ComboBox_FooterBrush.Size = New Size(40, 21)
        Me.ComboBox_FooterBrush.TabIndex = 9
        '
        'ComboBox_HeaderBrush
        '
        Me.ComboBox_HeaderBrush.DrawMode = DrawMode.OwnerDrawFixed
        Me.ComboBox_HeaderBrush.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox_HeaderBrush.Location = New Point(64, 24)
        Me.ComboBox_HeaderBrush.Name = "ComboBox_HeaderBrush"
        Me.ComboBox_HeaderBrush.Size = New Size(40, 21)
        Me.ComboBox_HeaderBrush.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.Location = New Point(112, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New Size(56, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Footer"
        '
        'Label10
        '
        Me.Label10.Location = New Point(8, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New Size(56, 16)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Header"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox_ColourBodyline)
        Me.GroupBox2.Controls.Add(Me.ComboBox_ColourFooterLine)
        Me.GroupBox2.Controls.Add(Me.ComboBox_ColourHeaderLine)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New Point(6, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New Size(536, 56)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grid line colors"
        '
        'ComboBox_ColourBodyline
        '
        Me.ComboBox_ColourBodyline.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox_ColourBodyline.Location = New Point(400, 24)
        Me.ComboBox_ColourBodyline.Name = "ComboBox_ColourBodyline"
        Me.ComboBox_ColourBodyline.Size = New Size(128, 21)
        Me.ComboBox_ColourBodyline.TabIndex = 10
        '
        'ComboBox_ColourFooterLine
        '
        Me.ComboBox_ColourFooterLine.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox_ColourFooterLine.Location = New Point(216, 24)
        Me.ComboBox_ColourFooterLine.Name = "ComboBox_ColourFooterLine"
        Me.ComboBox_ColourFooterLine.Size = New Size(104, 21)
        Me.ComboBox_ColourFooterLine.TabIndex = 9
        '
        'ComboBox_ColourHeaderLine
        '
        Me.ComboBox_ColourHeaderLine.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBox_ColourHeaderLine.Location = New Point(48, 24)
        Me.ComboBox_ColourHeaderLine.Name = "ComboBox_ColourHeaderLine"
        Me.ComboBox_ColourHeaderLine.Size = New Size(112, 21)
        Me.ComboBox_ColourHeaderLine.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Location = New Point(336, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(64, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Body"
        '
        'Label6
        '
        Me.Label6.Location = New Point(168, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New Size(56, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Footer"
        '
        'Label7
        '
        Me.Label7.Location = New Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New Size(56, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Header"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_InterSectionSpacingPercent)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_FooterHeightPercent)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_HeaderHeightPercentage)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New Point(6, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Size(536, 56)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Section Heights"
        '
        'NumericUpDown_InterSectionSpacingPercent
        '
        Me.NumericUpDown_InterSectionSpacingPercent.Location = New Point(384, 24)
        Me.NumericUpDown_InterSectionSpacingPercent.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown_InterSectionSpacingPercent.Name = "NumericUpDown_InterSectionSpacingPercent"
        Me.NumericUpDown_InterSectionSpacingPercent.Size = New Size(40, 20)
        Me.NumericUpDown_InterSectionSpacingPercent.TabIndex = 5
        Me.NumericUpDown_InterSectionSpacingPercent.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New Point(248, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(136, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Inter-section spacing"
        '
        'NumericUpDown_FooterHeightPercent
        '
        Me.NumericUpDown_FooterHeightPercent.Location = New Point(176, 24)
        Me.NumericUpDown_FooterHeightPercent.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_FooterHeightPercent.Name = "NumericUpDown_FooterHeightPercent"
        Me.NumericUpDown_FooterHeightPercent.Size = New Size(40, 20)
        Me.NumericUpDown_FooterHeightPercent.TabIndex = 3
        Me.NumericUpDown_FooterHeightPercent.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Location = New Point(120, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(56, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Footer"
        '
        'NumericUpDown_HeaderHeightPercentage
        '
        Me.NumericUpDown_HeaderHeightPercentage.Location = New Point(64, 24)
        Me.NumericUpDown_HeaderHeightPercentage.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_HeaderHeightPercentage.Name = "NumericUpDown_HeaderHeightPercentage"
        Me.NumericUpDown_HeaderHeightPercentage.Size = New Size(40, 20)
        Me.NumericUpDown_HeaderHeightPercentage.TabIndex = 1
        Me.NumericUpDown_HeaderHeightPercentage.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Location = New Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(56, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Header"
        '
        'Label1
        '
        Me.Label1.Location = New Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(80, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Page Heading"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Point(86, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Size(456, 20)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "My Custom Report"
        '
        'frmCR_ViewReport
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(583, 519)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.HelpProvider1.SetHelpKeyword(Me, "Custom Reports - Viewing Results")
        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me, "Custom Reports - Viewing Results")
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.Name = "frmCR_ViewReport"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "View Custom Report"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.BindingSource1, ISupportInitialize).EndInit()
        CType(Me.DataGrid1, ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.NumericUpDown_PagesAcross, ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NumericUpDown_InterSectionSpacingPercent, ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_FooterHeightPercent, ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_HeaderHeightPercentage, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents DataGrid1 As DataGrid
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TXTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents CVSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HTMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents NumericUpDown_PagesAcross As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox_ColumnHeaderBrush As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox_EvenBrush As ComboBox
    Friend WithEvents ComboBox_OddRowBrush As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox_FooterBrush As ComboBox
    Friend WithEvents ComboBox_HeaderBrush As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox_ColourBodyline As ComboBox
    Friend WithEvents ComboBox_ColourFooterLine As ComboBox
    Friend WithEvents ComboBox_ColourHeaderLine As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumericUpDown_InterSectionSpacingPercent As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown_FooterHeightPercent As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown_HeaderHeightPercentage As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
