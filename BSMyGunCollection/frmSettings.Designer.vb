Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(FrmSettings))
        Me.TabControl1 = New TabControl
        Me.TabPage1 = New TabPage
        Me.txtCCD = New TextBox
        Me.txtPhone = New TextBox
        Me.txtZip = New TextBox
        Me.txtState = New TextBox
        Me.txtCity = New TextBox
        Me.txtAddress = New TextBox
        Me.txtName = New TextBox
        Me.Label7 = New Label
        Me.Label6 = New Label
        Me.Label5 = New Label
        Me.Label4 = New Label
        Me.Label3 = New Label
        Me.Label2 = New Label
        Me.Label1 = New Label
        Me.TabPage2 = New TabPage
        Me.ChkPassword = New CheckBox
        Me.GroupBox1 = New GroupBox
        Me.txtWord = New TextBox
        Me.txtPhrase = New TextBox
        Me.Label16 = New Label
        Me.Label15 = New Label
        Me.txtLogin = New TextBox
        Me.Label14 = New Label
        Me.txtCPWD = New MaskedTextBox
        Me.txtPWD = New MaskedTextBox
        Me.Label9 = New Label
        Me.Label8 = New Label
        Me.TabPage3 = New TabPage
        Me.chkBackupOnExit = New CheckBox
        Me.lblLastSuc = New Label
        Me.Label12 = New Label
        Me.nudDays = New NumericUpDown
        Me.Label11 = New Label
        Me.Label10 = New Label
        Me.chkBAKCleanup = New CheckBox
        Me.chkAOBU = New CheckBox
        Me.TabPage4 = New TabPage
        Me.chkUnique = New CheckBox
        Me.chkAACID = New CheckBox
        Me.chkAAP = New CheckBox
        Me.chkNCCID = New CheckBox
        Me.chkIPer = New CheckBox
        Me.chkPetLoads = New CheckBox
        Me.chkDoOriginalImage = New CheckBox
        Me.ImageList1 = New ImageList(Me.components)
        Me.btnSave = New Button
        Me.btnExit = New Button
        Me.btnApply = New Button
        Me.HelpProvider1 = New HelpProvider
        Me.chkSelectiveBoundBook = New CheckBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.nudDays, ISupportInitialize).BeginInit()
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
        Me.HelpProvider1.SetHelpNavigator(Me.TabControl1, HelpNavigator.TableOfContents)
        Me.HelpProvider1.SetHelpString(Me.TabControl1, "Tools")
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.HelpProvider1.SetShowHelp(Me.TabControl1, True)
        Me.TabControl1.Size = New Size(309, 237)
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
        Me.HelpProvider1.SetHelpNavigator(Me.TabPage1, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me.TabPage1, "Settings - User Details")
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New Padding(3)
        Me.HelpProvider1.SetShowHelp(Me.TabPage1, True)
        Me.TabPage1.Size = New Size(301, 210)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtCCD
        '
        Me.txtCCD.Location = New Point(102, 164)
        Me.txtCCD.Name = "txtCCD"
        Me.txtCCD.Size = New Size(173, 20)
        Me.txtCCD.TabIndex = 20
        '
        'txtPhone
        '
        Me.txtPhone.Location = New Point(102, 138)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New Size(173, 20)
        Me.txtPhone.TabIndex = 19
        '
        'txtZip
        '
        Me.txtZip.Location = New Point(102, 111)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New Size(173, 20)
        Me.txtZip.TabIndex = 18
        '
        'txtState
        '
        Me.txtState.Location = New Point(102, 85)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New Size(173, 20)
        Me.txtState.TabIndex = 17
        '
        'txtCity
        '
        Me.txtCity.Location = New Point(102, 59)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New Size(173, 20)
        Me.txtCity.TabIndex = 16
        '
        'txtAddress
        '
        Me.txtAddress.Location = New Point(102, 32)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New Size(173, 20)
        Me.txtAddress.TabIndex = 15
        '
        'txtName
        '
        Me.txtName.Location = New Point(102, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New Size(173, 20)
        Me.txtName.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New Point(8, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New Size(57, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "License #:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New Point(8, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New Size(81, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Phone Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New Point(8, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(53, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Zip Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(35, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(8, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(27, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(8, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(48, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(38, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ChkPassword)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.HelpProvider1.SetHelpKeyword(Me.TabPage2, "Settings - Security")
        Me.HelpProvider1.SetHelpNavigator(Me.TabPage2, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me.TabPage2, "Settings - Security")
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New Padding(3)
        Me.HelpProvider1.SetShowHelp(Me.TabPage2, True)
        Me.TabPage2.Size = New Size(301, 210)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Security"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ChkPassword
        '
        Me.ChkPassword.AutoSize = True
        Me.ChkPassword.Location = New Point(5, 6)
        Me.ChkPassword.Name = "ChkPassword"
        Me.ChkPassword.Size = New Size(100, 17)
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
        Me.GroupBox1.Location = New Point(9, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Size(286, 178)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Security Info"
        '
        'txtWord
        '
        Me.txtWord.Location = New Point(12, 152)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New Size(256, 20)
        Me.txtWord.TabIndex = 8
        '
        'txtPhrase
        '
        Me.txtPhrase.Location = New Point(12, 113)
        Me.txtPhrase.Name = "txtPhrase"
        Me.txtPhrase.Size = New Size(256, 20)
        Me.txtPhrase.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New Point(9, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New Size(118, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Forgot Password Word:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New Point(9, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New Size(122, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Forgot Password Phrase"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New Point(102, 13)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New Size(166, 20)
        Me.txtLogin.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New Point(9, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New Size(67, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Login Name:"
        '
        'txtCPWD
        '
        Me.txtCPWD.Location = New Point(102, 65)
        Me.txtCPWD.Name = "txtCPWD"
        Me.txtCPWD.PasswordChar = ChrW(42)
        Me.txtCPWD.Size = New Size(166, 20)
        Me.txtCPWD.TabIndex = 4
        '
        'txtPWD
        '
        Me.txtPWD.Location = New Point(102, 39)
        Me.txtPWD.Name = "txtPWD"
        Me.txtPWD.PasswordChar = ChrW(42)
        Me.txtPWD.Size = New Size(166, 20)
        Me.txtPWD.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New Point(9, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New Size(94, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Confirm Password:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New Point(9, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New Size(53, 13)
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
        Me.HelpProvider1.SetHelpNavigator(Me.TabPage3, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me.TabPage3, "Backup Settings")
        Me.TabPage3.ImageIndex = 2
        Me.TabPage3.Location = New Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.HelpProvider1.SetShowHelp(Me.TabPage3, True)
        Me.TabPage3.Size = New Size(301, 210)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Backups"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chkBackupOnExit
        '
        Me.chkBackupOnExit.AutoSize = True
        Me.chkBackupOnExit.Location = New Point(9, 34)
        Me.chkBackupOnExit.Name = "chkBackupOnExit"
        Me.chkBackupOnExit.Size = New Size(98, 17)
        Me.chkBackupOnExit.TabIndex = 7
        Me.chkBackupOnExit.Text = "Backup on Exit"
        Me.chkBackupOnExit.UseVisualStyleBackColor = True
        '
        'lblLastSuc
        '
        Me.lblLastSuc.AutoSize = True
        Me.lblLastSuc.Location = New Point(163, 111)
        Me.lblLastSuc.Name = "lblLastSuc"
        Me.lblLastSuc.Size = New Size(0, 13)
        Me.lblLastSuc.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New Point(6, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New Size(151, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Last Successful Backup Date:"
        '
        'nudDays
        '
        Me.nudDays.Location = New Point(61, 80)
        Me.nudDays.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudDays.Name = "nudDays"
        Me.nudDays.Size = New Size(48, 20)
        Me.nudDays.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New Point(115, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New Size(34, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Days."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New Point(6, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New Size(49, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Track by"
        '
        'chkBAKCleanup
        '
        Me.chkBAKCleanup.AutoSize = True
        Me.chkBAKCleanup.Location = New Point(9, 57)
        Me.chkBAKCleanup.Name = "chkBAKCleanup"
        Me.chkBAKCleanup.Size = New Size(186, 17)
        Me.chkBAKCleanup.TabIndex = 1
        Me.chkBAKCleanup.Text = "Automatically Delete Old Backups"
        Me.chkBAKCleanup.UseVisualStyleBackColor = True
        '
        'chkAOBU
        '
        Me.chkAOBU.AutoSize = True
        Me.chkAOBU.Location = New Point(9, 15)
        Me.chkAOBU.Name = "chkAOBU"
        Me.chkAOBU.Size = New Size(153, 17)
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
        Me.HelpProvider1.SetHelpNavigator(Me.TabPage4, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me.TabPage4, "Settings - Other Options")
        Me.TabPage4.Location = New Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New Padding(3)
        Me.HelpProvider1.SetShowHelp(Me.TabPage4, True)
        Me.TabPage4.Size = New Size(301, 210)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Other"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'chkUnique
        '
        Me.chkUnique.AutoSize = True
        Me.chkUnique.Location = New Point(9, 158)
        Me.chkUnique.Name = "chkUnique"
        Me.chkUnique.Size = New Size(246, 17)
        Me.chkUnique.TabIndex = 6
        Me.chkUnique.Text = "Disable unique custom Catalog id requirements"
        Me.chkUnique.UseVisualStyleBackColor = True
        '
        'chkAACID
        '
        Me.chkAACID.AutoSize = True
        Me.chkAACID.Location = New Point(9, 111)
        Me.chkAACID.Name = "chkAACID"
        Me.chkAACID.Size = New Size(210, 17)
        Me.chkAACID.TabIndex = 5
        Me.chkAACID.Text = "Use Auto Assign for Custom Catalog ID"
        Me.chkAACID.UseVisualStyleBackColor = True
        '
        'chkAAP
        '
        Me.chkAAP.AutoSize = True
        Me.chkAAP.Location = New Point(9, 134)
        Me.chkAAP.Name = "chkAAP"
        Me.chkAAP.Size = New Size(139, 17)
        Me.chkAAP.TabIndex = 4
        Me.chkAAP.Text = "Audit Ammunition Prices"
        Me.chkAAP.UseVisualStyleBackColor = True
        '
        'chkNCCID
        '
        Me.chkNCCID.AutoSize = True
        Me.chkNCCID.Location = New Point(9, 88)
        Me.chkNCCID.Name = "chkNCCID"
        Me.chkNCCID.Size = New Size(257, 17)
        Me.chkNCCID.TabIndex = 3
        Me.chkNCCID.Text = "Use Numeric Only System for Custom Catalog ID."
        Me.chkNCCID.UseVisualStyleBackColor = True
        '
        'chkIPer
        '
        Me.chkIPer.AutoSize = True
        Me.chkIPer.Location = New Point(9, 64)
        Me.chkIPer.Name = "chkIPer"
        Me.chkIPer.Size = New Size(175, 17)
        Me.chkIPer.TabIndex = 2
        Me.chkIPer.Text = "Use Personal Reports Markings"
        Me.chkIPer.UseVisualStyleBackColor = True
        '
        'chkPetLoads
        '
        Me.chkPetLoads.AutoSize = True
        Me.chkPetLoads.Location = New Point(9, 40)
        Me.chkPetLoads.Name = "chkPetLoads"
        Me.chkPetLoads.Size = New Size(134, 17)
        Me.chkPetLoads.TabIndex = 1
        Me.chkPetLoads.Text = "View Pet Loads Option"
        Me.chkPetLoads.UseVisualStyleBackColor = True
        '
        'chkDoOriginalImage
        '
        Me.chkDoOriginalImage.AutoSize = True
        Me.chkDoOriginalImage.Location = New Point(9, 16)
        Me.chkDoOriginalImage.Name = "chkDoOriginalImage"
        Me.chkDoOriginalImage.Size = New Size(255, 17)
        Me.chkDoOriginalImage.TabIndex = 0
        Me.chkDoOriginalImage.Text = "Use Picture Original Size or close to Original Size"
        Me.chkDoOriginalImage.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        Me.ImageList1.TransparentColor = Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "_14_16x16.ico")
        Me.ImageList1.Images.SetKeyName(1, "Computer_System_53_32x32.ico")
        Me.ImageList1.Images.SetKeyName(2, "Winxpicons_Disk_2_32x32.ico")
        '
        'btnSave
        '
        Me.btnSave.Location = New Point(4, 243)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = DialogResult.Cancel
        Me.btnExit.Location = New Point(219, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New Point(106, 243)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New Size(75, 23)
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
        Me.chkSelectiveBoundBook.Location = New Point(9, 182)
        Me.chkSelectiveBoundBook.Name = "chkSelectiveBoundBook"
        Me.chkSelectiveBoundBook.Size = New Size(154, 17)
        Me.chkSelectiveBoundBook.TabIndex = 7
        Me.chkSelectiveBoundBook.Text = "Use Selective Bound Book"
        Me.chkSelectiveBoundBook.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New Size(306, 269)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSettings"
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
        CType(Me.nudDays, ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtCCD As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents ChkPassword As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCPWD As MaskedTextBox
    Friend WithEvents txtPWD As MaskedTextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents chkBAKCleanup As CheckBox
    Friend WithEvents chkAOBU As CheckBox
    Friend WithEvents nudDays As NumericUpDown
    Friend WithEvents lblLastSuc As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents chkBackupOnExit As CheckBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents chkDoOriginalImage As CheckBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents chkPetLoads As CheckBox
    Friend WithEvents chkIPer As CheckBox
    Friend WithEvents txtWord As TextBox
    Friend WithEvents txtPhrase As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents chkNCCID As CheckBox
    Friend WithEvents chkAAP As CheckBox
    Friend WithEvents chkAACID As CheckBox
    Friend WithEvents chkUnique As CheckBox
    Friend WithEvents chkSelectiveBoundBook As CheckBox
End Class
