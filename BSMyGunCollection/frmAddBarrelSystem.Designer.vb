<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBarrelSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddBarrelSystem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRecieverName = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSysType = New System.Windows.Forms.TextBox()
        Me.txtCal = New System.Windows.Forms.TextBox()
        Me.txtBarLen = New System.Windows.Forms.TextBox()
        Me.txtOvLen = New System.Windows.Forms.TextBox()
        Me.txtAction = New System.Windows.Forms.TextBox()
        Me.txtFeedSys = New System.Windows.Forms.TextBox()
        Me.txtSight = New System.Windows.Forms.TextBox()
        Me.txtPetLoads = New System.Windows.Forms.TextBox()
        Me.txtPurPrice = New System.Windows.Forms.TextBox()
        Me.txtPurFrom = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFinish = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkSetDefault = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Main Reciever:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "System Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Caliber:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Barrel Length:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Caliber #2:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Action:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Feed System:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Sights:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 302)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Purchased Price:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 328)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Purchased From:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Overall Length:"
        '
        'txtRecieverName
        '
        Me.txtRecieverName.Location = New System.Drawing.Point(99, 13)
        Me.txtRecieverName.Name = "txtRecieverName"
        Me.txtRecieverName.ReadOnly = True
        Me.txtRecieverName.Size = New System.Drawing.Size(211, 20)
        Me.txtRecieverName.TabIndex = 12
        '
        'txtName
        '
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.Location = New System.Drawing.Point(99, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(211, 20)
        Me.txtName.TabIndex = 1
        '
        'txtSysType
        '
        Me.txtSysType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSysType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSysType.Location = New System.Drawing.Point(99, 65)
        Me.txtSysType.Name = "txtSysType"
        Me.txtSysType.Size = New System.Drawing.Size(211, 20)
        Me.txtSysType.TabIndex = 2
        '
        'txtCal
        '
        Me.txtCal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCal.Location = New System.Drawing.Point(99, 91)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.Size = New System.Drawing.Size(211, 20)
        Me.txtCal.TabIndex = 3
        '
        'txtBarLen
        '
        Me.txtBarLen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBarLen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBarLen.Location = New System.Drawing.Point(99, 117)
        Me.txtBarLen.Name = "txtBarLen"
        Me.txtBarLen.Size = New System.Drawing.Size(211, 20)
        Me.txtBarLen.TabIndex = 4
        '
        'txtOvLen
        '
        Me.txtOvLen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtOvLen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtOvLen.Location = New System.Drawing.Point(99, 143)
        Me.txtOvLen.Name = "txtOvLen"
        Me.txtOvLen.Size = New System.Drawing.Size(211, 20)
        Me.txtOvLen.TabIndex = 5
        '
        'txtAction
        '
        Me.txtAction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtAction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAction.Location = New System.Drawing.Point(99, 195)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(211, 20)
        Me.txtAction.TabIndex = 7
        '
        'txtFeedSys
        '
        Me.txtFeedSys.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtFeedSys.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFeedSys.Location = New System.Drawing.Point(99, 221)
        Me.txtFeedSys.Name = "txtFeedSys"
        Me.txtFeedSys.Size = New System.Drawing.Size(211, 20)
        Me.txtFeedSys.TabIndex = 8
        '
        'txtSight
        '
        Me.txtSight.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSight.Location = New System.Drawing.Point(99, 247)
        Me.txtSight.Name = "txtSight"
        Me.txtSight.Size = New System.Drawing.Size(211, 20)
        Me.txtSight.TabIndex = 9
        '
        'txtPetLoads
        '
        Me.txtPetLoads.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPetLoads.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPetLoads.Location = New System.Drawing.Point(99, 273)
        Me.txtPetLoads.Name = "txtPetLoads"
        Me.txtPetLoads.Size = New System.Drawing.Size(211, 20)
        Me.txtPetLoads.TabIndex = 10
        '
        'txtPurPrice
        '
        Me.txtPurPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPurPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPurPrice.Location = New System.Drawing.Point(99, 299)
        Me.txtPurPrice.Name = "txtPurPrice"
        Me.txtPurPrice.Size = New System.Drawing.Size(211, 20)
        Me.txtPurPrice.TabIndex = 11
        '
        'txtPurFrom
        '
        Me.txtPurFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPurFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPurFrom.Location = New System.Drawing.Point(99, 325)
        Me.txtPurFrom.Name = "txtPurFrom"
        Me.txtPurFrom.Size = New System.Drawing.Size(211, 20)
        Me.txtPurFrom.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Finish:"
        '
        'txtFinish
        '
        Me.txtFinish.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtFinish.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFinish.Location = New System.Drawing.Point(99, 169)
        Me.txtFinish.Name = "txtFinish"
        Me.txtFinish.Size = New System.Drawing.Size(211, 20)
        Me.txtFinish.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(58, 390)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(204, 390)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkSetDefault
        '
        Me.chkSetDefault.AutoSize = True
        Me.chkSetDefault.Location = New System.Drawing.Point(99, 352)
        Me.chkSetDefault.Name = "chkSetDefault"
        Me.chkSetDefault.Size = New System.Drawing.Size(44, 17)
        Me.chkSetDefault.TabIndex = 13
        Me.chkSetDefault.Text = "Yes"
        Me.chkSetDefault.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 352)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Set As Default"
        '
        'frmAddBarrelSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 425)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.chkSetDefault)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtFinish)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPurFrom)
        Me.Controls.Add(Me.txtPurPrice)
        Me.Controls.Add(Me.txtPetLoads)
        Me.Controls.Add(Me.txtSight)
        Me.Controls.Add(Me.txtFeedSys)
        Me.Controls.Add(Me.txtAction)
        Me.Controls.Add(Me.txtOvLen)
        Me.Controls.Add(Me.txtBarLen)
        Me.Controls.Add(Me.txtCal)
        Me.Controls.Add(Me.txtSysType)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtRecieverName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAddBarrelSystem"
        Me.Text = "Add Barrel/Conversion Kit System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRecieverName As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtSysType As System.Windows.Forms.TextBox
    Friend WithEvents txtCal As System.Windows.Forms.TextBox
    Friend WithEvents txtBarLen As System.Windows.Forms.TextBox
    Friend WithEvents txtOvLen As System.Windows.Forms.TextBox
    Friend WithEvents txtAction As System.Windows.Forms.TextBox
    Friend WithEvents txtFeedSys As System.Windows.Forms.TextBox
    Friend WithEvents txtSight As System.Windows.Forms.TextBox
    Friend WithEvents txtPetLoads As System.Windows.Forms.TextBox
    Friend WithEvents txtPurPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtPurFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFinish As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkSetDefault As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
