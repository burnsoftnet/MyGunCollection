Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FrmEditBarrelSystem
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
        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmEditBarrelSystem))
        Me.btnCancel = New Button
        Me.btnSave = New Button
        Me.txtFinish = New TextBox
        Me.Label13 = New Label
        Me.txtPurFrom = New TextBox
        Me.txtPurPrice = New TextBox
        Me.txtPetLoads = New TextBox
        Me.txtSight = New TextBox
        Me.txtFeedSys = New TextBox
        Me.txtAction = New TextBox
        Me.txtOvLen = New TextBox
        Me.txtBarLen = New TextBox
        Me.txtCal = New TextBox
        Me.txtSysType = New TextBox
        Me.txtName = New TextBox
        Me.txtRecieverName = New TextBox
        Me.Label12 = New Label
        Me.Label11 = New Label
        Me.Label10 = New Label
        Me.Label9 = New Label
        Me.Label8 = New Label
        Me.Label7 = New Label
        Me.Label6 = New Label
        Me.Label5 = New Label
        Me.Label4 = New Label
        Me.Label3 = New Label
        Me.Label2 = New Label
        Me.Label1 = New Label
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New Point(203, 369)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New Point(49, 369)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New Size(75, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtFinish
        '
        Me.txtFinish.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtFinish.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtFinish.Location = New Point(98, 171)
        Me.txtFinish.Name = "txtFinish"
        Me.txtFinish.Size = New Size(211, 20)
        Me.txtFinish.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New Point(12, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New Size(37, 13)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Finish:"
        '
        'txtPurFrom
        '
        Me.txtPurFrom.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtPurFrom.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtPurFrom.Location = New Point(98, 327)
        Me.txtPurFrom.Name = "txtPurFrom"
        Me.txtPurFrom.Size = New Size(211, 20)
        Me.txtPurFrom.TabIndex = 12
        '
        'txtPurPrice
        '
        Me.txtPurPrice.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtPurPrice.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtPurPrice.Location = New Point(98, 301)
        Me.txtPurPrice.Name = "txtPurPrice"
        Me.txtPurPrice.Size = New Size(211, 20)
        Me.txtPurPrice.TabIndex = 11
        '
        'txtPetLoads
        '
        Me.txtPetLoads.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtPetLoads.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtPetLoads.Location = New Point(98, 275)
        Me.txtPetLoads.Name = "txtPetLoads"
        Me.txtPetLoads.Size = New Size(211, 20)
        Me.txtPetLoads.TabIndex = 10
        '
        'txtSight
        '
        Me.txtSight.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtSight.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtSight.Location = New Point(98, 249)
        Me.txtSight.Name = "txtSight"
        Me.txtSight.Size = New Size(211, 20)
        Me.txtSight.TabIndex = 9
        '
        'txtFeedSys
        '
        Me.txtFeedSys.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtFeedSys.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtFeedSys.Location = New Point(98, 223)
        Me.txtFeedSys.Name = "txtFeedSys"
        Me.txtFeedSys.Size = New Size(211, 20)
        Me.txtFeedSys.TabIndex = 8
        '
        'txtAction
        '
        Me.txtAction.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtAction.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtAction.Location = New Point(98, 197)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New Size(211, 20)
        Me.txtAction.TabIndex = 7
        '
        'txtOvLen
        '
        Me.txtOvLen.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtOvLen.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtOvLen.Location = New Point(98, 145)
        Me.txtOvLen.Name = "txtOvLen"
        Me.txtOvLen.Size = New Size(211, 20)
        Me.txtOvLen.TabIndex = 5
        '
        'txtBarLen
        '
        Me.txtBarLen.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtBarLen.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtBarLen.Location = New Point(98, 119)
        Me.txtBarLen.Name = "txtBarLen"
        Me.txtBarLen.Size = New Size(211, 20)
        Me.txtBarLen.TabIndex = 4
        '
        'txtCal
        '
        Me.txtCal.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtCal.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtCal.Location = New Point(98, 93)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.Size = New Size(211, 20)
        Me.txtCal.TabIndex = 3
        '
        'txtSysType
        '
        Me.txtSysType.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtSysType.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtSysType.Location = New Point(98, 67)
        Me.txtSysType.Name = "txtSysType"
        Me.txtSysType.Size = New Size(211, 20)
        Me.txtSysType.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.txtName.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtName.Location = New Point(98, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New Size(211, 20)
        Me.txtName.TabIndex = 1
        '
        'txtRecieverName
        '
        Me.txtRecieverName.Location = New Point(98, 15)
        Me.txtRecieverName.Name = "txtRecieverName"
        Me.txtRecieverName.ReadOnly = True
        Me.txtRecieverName.Size = New Size(211, 20)
        Me.txtRecieverName.TabIndex = 52
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New Point(12, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New Size(79, 13)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Overall Length:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New Point(12, 330)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New Size(87, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Purchased From:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New Point(12, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New Size(88, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Purchased Price:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New Point(12, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New Size(39, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Sights:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New Point(12, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New Size(71, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Feed System:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New Point(12, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New Size(40, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Action:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New Point(12, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New Size(58, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Pet Loads:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New Point(12, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(73, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Barrel Length:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(42, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Caliber:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(71, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "System Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(38, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(79, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Main Receiver:"
        '
        'frmEditBarrelSystem
        '
        Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(330, 400)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEditBarrelSystem"
        Me.Text = "Edit Barrel/Conversion Kit System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtFinish As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPurFrom As TextBox
    Friend WithEvents txtPurPrice As TextBox
    Friend WithEvents txtPetLoads As TextBox
    Friend WithEvents txtSight As TextBox
    Friend WithEvents txtFeedSys As TextBox
    Friend WithEvents txtAction As TextBox
    Friend WithEvents txtOvLen As TextBox
    Friend WithEvents txtBarLen As TextBox
    Friend WithEvents txtCal As TextBox
    Friend WithEvents txtSysType As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtRecieverName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
