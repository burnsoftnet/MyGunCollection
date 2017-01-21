<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.txtCCD = New System.Windows.Forms.TextBox
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ChkPassword = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtWord = New System.Windows.Forms.TextBox
        Me.txtPhrase = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCPWD = New System.Windows.Forms.MaskedTextBox
        Me.txtPWD = New System.Windows.Forms.MaskedTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.chkBackupOnExit = New System.Windows.Forms.CheckBox
        Me.lblLastSuc = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.nudDays = New System.Windows.Forms.NumericUpDown
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.chkBAKCleanup = New System.Windows.Forms.CheckBox
        Me.chkAOBU = New System.Windows.Forms.CheckBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.chkUnique = New System.Windows.Forms.CheckBox
        Me.chkAACID = New System.Windows.Forms.CheckBox
        Me.chkAAP = New System.Windows.Forms.CheckBox
        Me.chkNCCID = New System.Windows.Forms.CheckBox
        Me.chkIPer = New System.Windows.Forms.CheckBox
        Me.chkPetLoads = New System.Windows.Forms.CheckBox
        Me.chkDoOriginalImage = New System.Windows.Forms.CheckBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnApply = New System.Windows.Forms.Button
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.chkSelectiveBoundBook = New System.Windows.Forms.CheckBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.nudDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.HelpProvider1.SetHelpKeyword(Me.TabControl1, "Tools")
        Me.HelpProvider1.SetHelpNavigator(Me.TabControl1, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.HelpProvider1.SetHelpString(Me.TabControl1, "Tools")
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.HelpProvider1.SetShowHelp(Me.TabControl1, True)
        Me.TabControl1.Size = New System.Drawing.Size(309, 237)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtCCD)
        Me.TabPage1.Controls.Add(Me.txtPhone)
        Me.TabPage1.Controls.Add(Me.txtZip)
        Me.TabPage1.Controls.Add(Me.txtState)
        Me.TabPage1.Controls.Add(Me.txtCity)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpKeyword(Me.TabPage1, "Settings - User Details")
        Me.HelpProvider1.SetHelpNavigator(Me.TabPage1, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me.TabPage1, "Settings - User Details")
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.HelpProvider1.SetShowHelp(Me.TabPage1, True)
        Me.TabPage1.Size = New System.Drawing.Size(301, 210)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtCCD
        '
        Me.txtCCD.Location = New System.Drawing.Point(102, 164)
        Me.txtCCD.Name = "txtCCD"
        Me.txtCCD.Size = New System.Drawing.Size(173, 20)
        Me.txtCCD.TabIndex = 20
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(102, 138)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(173, 20)
        Me.txtPhone.TabIndex = 19
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(102, 111)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(173, 20)
        Me.txtZip.TabIndex = 18
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(102, 85)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(173, 20)
        Me.txtState.TabIndex = 17
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(102, 59)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(173, 20)
        Me.txtCity.TabIndex = 16
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(102, 32)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(173, 20)
        Me.txtAddress.TabIndex = 15
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(102, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(173, 20)
        Me.txtName.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "License #:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Phone Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Zip Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ChkPassword)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.HelpProvider1.SetHelpKeyword(Me.TabPage2, "Settings - Security")
        Me.HelpProvider1.SetHelpNavigator(Me.TabPage2, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me.TabPage2, "Settings - Security")
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.HelpProvider1.SetShowHelp(Me.TabPage2, True)
        Me.TabPage2.Size = New System.Drawing.Size(301, 210)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Security"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ChkPassword
        '
        Me.ChkPassword.AutoSize = True
        Me.ChkPassword.Location = New System.Drawing.Point(5, 6)
        Me.ChkPassword.Name = "ChkPassword"
        Me.ChkPassword.Size = New System.Drawing.Size(100, 17)
        Me.ChkPassword.TabIndex = 1
        Me.ChkPassword.Text = "Enable Security"
        Me.ChkPassword.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtWord)
        Me.GroupBox1.Controls.Add(Me.txtPhrase)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtLogin)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCPWD)
        Me.GroupBox1.Controls.Add(Me.txtPWD)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 178)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Security Info"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(12, 152)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(256, 20)
        Me.txtWord.TabIndex = 8
        '
        'txtPhrase
        '
        Me.txtPhrase.Location = New System.Drawing.Point(12, 113)
        Me.txtPhrase.Name = "txtPhrase"
        Me.txtPhrase.Size = New System.Drawing.Size(256, 20)
        Me.txtPhrase.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Forgot Password Word:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Forgot Password Phrase"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(102, 13)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(166, 20)
        Me.txtLogin.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Login Name:"
        '
        'txtCPWD
        '
        Me.txtCPWD.Location = New System.Drawing.Point(102, 65)
        Me.txtCPWD.Name = "txtCPWD"
        Me.txtCPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCPWD.Size = New System.Drawing.Size(166, 20)
        Me.txtCPWD.TabIndex = 4
        '
        'txtPWD
        '
        Me.txtPWD.Location = New System.Drawing.Point(102, 39)
        Me.txtPWD.Name = "txtPWD"
        Me.txtPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPWD.Size = New System.Drawing.Size(166, 20)
        Me.txtPWD.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Confirm Password:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Password"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chkBackupOnExit)
        Me.TabPage3.Controls.Add(Me.lblLastSuc)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.nudDays)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.chkBAKCleanup)
        Me.TabPage3.Controls.Add(Me.chkAOBU)
        Me.HelpProvider1.SetHelpKeyword(Me.TabPage3, "Backup Settings")
        Me.HelpProvider1.SetHelpNavigator(Me.TabPage3, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me.TabPage3, "Backup Settings")
        Me.TabPage3.ImageIndex = 2
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.HelpProvider1.SetShowHelp(Me.TabPage3, True)
        Me.TabPage3.Size = New System.Drawing.Size(301, 210)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Backups"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chkBackupOnExit
        '
        Me.chkBackupOnExit.AutoSize = True
        Me.chkBackupOnExit.Location = New System.Drawing.Point(9, 34)
        Me.chkBackupOnExit.Name = "chkBackupOnExit"
        Me.chkBackupOnExit.Size = New System.Drawing.Size(98, 17)
        Me.chkBackupOnExit.TabIndex = 7
        Me.chkBackupOnExit.Text = "Backup on Exit"
        Me.chkBackupOnExit.UseVisualStyleBackColor = True
        '
        'lblLastSuc
        '
        Me.lblLastSuc.AutoSize = True
        Me.lblLastSuc.Location = New System.Drawing.Point(163, 111)
        Me.lblLastSuc.Name = "lblLastSuc"
        Me.lblLastSuc.Size = New System.Drawing.Size(0, 13)
        Me.lblLastSuc.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Last Successful Backup Date:"
        '
        'nudDays
        '
        Me.nudDays.Location = New System.Drawing.Point(61, 80)
        Me.nudDays.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudDays.Name = "nudDays"
        Me.nudDays.Size = New System.Drawing.Size(48, 20)
        Me.nudDays.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(115, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Days."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Track by"
        '
        'chkBAKCleanup
        '
        Me.chkBAKCleanup.AutoSize = True
        Me.chkBAKCleanup.Location = New System.Drawing.Point(9, 57)
        Me.chkBAKCleanup.Name = "chkBAKCleanup"
        Me.chkBAKCleanup.Size = New System.Drawing.Size(186, 17)
        Me.chkBAKCleanup.TabIndex = 1
        Me.chkBAKCleanup.Text = "Automatically Delete Old Backups"
        Me.chkBAKCleanup.UseVisualStyleBackColor = True
        '
        'chkAOBU
        '
        Me.chkAOBU.AutoSize = True
        Me.chkAOBU.Location = New System.Drawing.Point(9, 15)
        Me.chkAOBU.Name = "chkAOBU"
        Me.chkAOBU.Size = New System.Drawing.Size(153, 17)
        Me.chkAOBU.TabIndex = 0
        Me.chkAOBU.Text = "Alert On Last Backup Time"
        Me.chkAOBU.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.chkSelectiveBoundBook)
        Me.TabPage4.Controls.Add(Me.chkUnique)
        Me.TabPage4.Controls.Add(Me.chkAACID)
        Me.TabPage4.Controls.Add(Me.chkAAP)
        Me.TabPage4.Controls.Add(Me.chkNCCID)
        Me.TabPage4.Controls.Add(Me.chkIPer)
        Me.TabPage4.Controls.Add(Me.chkPetLoads)
        Me.TabPage4.Controls.Add(Me.chkDoOriginalImage)
        Me.HelpProvider1.SetHelpKeyword(Me.TabPage4, "Settings - Other Options")
        Me.HelpProvider1.SetHelpNavigator(Me.TabPage4, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me.TabPage4, "Settings - Other Options")
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.HelpProvider1.SetShowHelp(Me.TabPage4, True)
        Me.TabPage4.Size = New System.Drawing.Size(301, 210)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Other"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'chkUnique
        '
        Me.chkUnique.AutoSize = True
        Me.chkUnique.Location = New System.Drawing.Point(9, 158)
        Me.chkUnique.Name = "chkUnique"
        Me.chkUnique.Size = New System.Drawing.Size(246, 17)
        Me.chkUnique.TabIndex = 6
        Me.chkUnique.Text = "Disable unique custom Catalog id requirements"
        Me.chkUnique.UseVisualStyleBackColor = True
        '
        'chkAACID
        '
        Me.chkAACID.AutoSize = True
        Me.chkAACID.Location = New System.Drawing.Point(9, 111)
        Me.chkAACID.Name = "chkAACID"
        Me.chkAACID.Size = New System.Drawing.Size(210, 17)
        Me.chkAACID.TabIndex = 5
        Me.chkAACID.Text = "Use Auto Assign for Custom Catalog ID"
        Me.chkAACID.UseVisualStyleBackColor = True
        '
        'chkAAP
        '
        Me.chkAAP.AutoSize = True
        Me.chkAAP.Location = New System.Drawing.Point(9, 134)
        Me.chkAAP.Name = "chkAAP"
        Me.chkAAP.Size = New System.Drawing.Size(139, 17)
        Me.chkAAP.TabIndex = 4
        Me.chkAAP.Text = "Audit Ammunition Prices"
        Me.chkAAP.UseVisualStyleBackColor = True
        '
        'chkNCCID
        '
        Me.chkNCCID.AutoSize = True
        Me.chkNCCID.Location = New System.Drawing.Point(9, 88)
        Me.chkNCCID.Name = "chkNCCID"
        Me.chkNCCID.Size = New System.Drawing.Size(257, 17)
        Me.chkNCCID.TabIndex = 3
        Me.chkNCCID.Text = "Use Numeric Only System for Custom Catalog ID."
        Me.chkNCCID.UseVisualStyleBackColor = True
        '
        'chkIPer
        '
        Me.chkIPer.AutoSize = True
        Me.chkIPer.Location = New System.Drawing.Point(9, 64)
        Me.chkIPer.Name = "chkIPer"
        Me.chkIPer.Size = New System.Drawing.Size(175, 17)
        Me.chkIPer.TabIndex = 2
        Me.chkIPer.Text = "Use Personal Reports Markings"
        Me.chkIPer.UseVisualStyleBackColor = True
        '
        'chkPetLoads
        '
        Me.chkPetLoads.AutoSize = True
        Me.chkPetLoads.Location = New System.Drawing.Point(9, 40)
        Me.chkPetLoads.Name = "chkPetLoads"
        Me.chkPetLoads.Size = New System.Drawing.Size(134, 17)
        Me.chkPetLoads.TabIndex = 1
        Me.chkPetLoads.Text = "View Pet Loads Option"
        Me.chkPetLoads.UseVisualStyleBackColor = True
        '
        'chkDoOriginalImage
        '
        Me.chkDoOriginalImage.AutoSize = True
        Me.chkDoOriginalImage.Location = New System.Drawing.Point(9, 16)
        Me.chkDoOriginalImage.Name = "chkDoOriginalImage"
        Me.chkDoOriginalImage.Size = New System.Drawing.Size(255, 17)
        Me.chkDoOriginalImage.TabIndex = 0
        Me.chkDoOriginalImage.Text = "Use Picture Original Size or close to Original Size"
        Me.chkDoOriginalImage.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "_14_16x16.ico")
        Me.ImageList1.Images.SetKeyName(1, "Computer_System_53_32x32.ico")
        Me.ImageList1.Images.SetKeyName(2, "Winxpicons_Disk_2_32x32.ico")
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(4, 243)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(219, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(106, 243)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 6
        Me.btnApply.Text = "&Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "my_gun_collection_help.chm"
        '
        'chkSelectiveBoundBook
        '
        Me.chkSelectiveBoundBook.AutoSize = True
        Me.chkSelectiveBoundBook.Location = New System.Drawing.Point(9, 182)
        Me.chkSelectiveBoundBook.Name = "chkSelectiveBoundBook"
        Me.chkSelectiveBoundBook.Size = New System.Drawing.Size(154, 17)
        Me.chkSelectiveBoundBook.TabIndex = 7
        Me.chkSelectiveBoundBook.Text = "Use Selective Bound Book"
        Me.chkSelectiveBoundBook.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(306, 269)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.nudDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtCCD As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents ChkPassword As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCPWD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPWD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkBAKCleanup As System.Windows.Forms.CheckBox
    Friend WithEvents chkAOBU As System.Windows.Forms.CheckBox
    Friend WithEvents nudDays As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblLastSuc As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkBackupOnExit As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents chkDoOriginalImage As System.Windows.Forms.CheckBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chkPetLoads As System.Windows.Forms.CheckBox
    Friend WithEvents chkIPer As System.Windows.Forms.CheckBox
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents txtPhrase As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents chkNCCID As System.Windows.Forms.CheckBox
    Friend WithEvents chkAAP As System.Windows.Forms.CheckBox
    Friend WithEvents chkAACID As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnique As System.Windows.Forms.CheckBox
    Friend WithEvents chkSelectiveBoundBook As System.Windows.Forms.CheckBox
End Class
