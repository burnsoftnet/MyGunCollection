Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class SplashScreen1
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents Version As Label
    Friend WithEvents Copyright As Label
    Friend WithEvents MainLayoutPanel As TableLayoutPanel
    Friend WithEvents DetailsLayoutPanel As TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(SplashScreen1))
        Me.MainLayoutPanel = New TableLayoutPanel
        Me.DetailsLayoutPanel = New TableLayoutPanel
        Me.Version = New Label
        Me.Copyright = New Label
        Me.ApplicationTitle = New Label
        Me.MainLayoutPanel.SuspendLayout()
        Me.DetailsLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.BackgroundImage = CType(resources.GetObject("MainLayoutPanel.BackgroundImage"), Image)
        Me.MainLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch
        Me.MainLayoutPanel.ColumnCount = 2
        Me.MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 243.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100.0!))
        Me.MainLayoutPanel.Controls.Add(Me.DetailsLayoutPanel, 1, 1)
        Me.MainLayoutPanel.Controls.Add(Me.ApplicationTitle, 1, 0)
        Me.MainLayoutPanel.Dock = DockStyle.Fill
        Me.MainLayoutPanel.Location = New Point(0, 0)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 218.0!))
        Me.MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 38.0!))
        Me.MainLayoutPanel.Size = New Size(496, 303)
        Me.MainLayoutPanel.TabIndex = 0
        '
        'DetailsLayoutPanel
        '
        Me.DetailsLayoutPanel.Anchor = AnchorStyles.None
        Me.DetailsLayoutPanel.BackColor = Color.Transparent
        Me.DetailsLayoutPanel.ColumnCount = 1
        Me.DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 247.0!))
        Me.DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142.0!))
        Me.DetailsLayoutPanel.Controls.Add(Me.Version, 0, 0)
        Me.DetailsLayoutPanel.Controls.Add(Me.Copyright, 0, 1)
        Me.DetailsLayoutPanel.Location = New Point(246, 221)
        Me.DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        Me.DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.Size = New Size(247, 79)
        Me.DetailsLayoutPanel.TabIndex = 1
        '
        'Version
        '
        Me.Version.Anchor = AnchorStyles.None
        Me.Version.BackColor = Color.Transparent
        Me.Version.Font = New Font("Microsoft Sans Serif", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New Point(3, 9)
        Me.Version.Name = "Version"
        Me.Version.Size = New Size(241, 20)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Version {0}.{1:00}"
        '
        'Copyright
        '
        Me.Copyright.Anchor = AnchorStyles.None
        Me.Copyright.BackColor = Color.Transparent
        Me.Copyright.Font = New Font("Microsoft Sans Serif", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New Point(3, 39)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New Size(241, 40)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright"
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = AnchorStyles.None
        Me.ApplicationTitle.BackColor = Color.Transparent
        Me.ApplicationTitle.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.Location = New Point(246, 3)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New Size(247, 212)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "ApplicationTitle"
        Me.ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MainLayoutPanel.ResumeLayout(False)
        Me.DetailsLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

End Class
