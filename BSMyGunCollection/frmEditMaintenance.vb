Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class frmEditMaintenance.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmEditMaintenance
    ''' <summary>
    ''' The gid
    ''' </summary>
    Public Gid As String
    ''' <summary>
    ''' The ammo type
    ''' </summary>
    Public AmmoType As String
    ''' <summary>
    ''' The ammo type pet
    ''' </summary>
    Public AmmoTypePet As String
    ''' <summary>
    ''' The bsid
    ''' </summary>
    Public Bsid As String
    ''' <summary>
    ''' The mid
    ''' </summary>
    Public Mid As Long
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String = ""
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim maintId As Long
            Dim lst As List(Of MaintanceDetailsList) = BurnSoft.Applications.MGC.Firearms.MaintanceDetails.Lists(DatabasePath, CInt(Mid), _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            For Each o As MaintanceDetailsList In lst 
                maintId = o.PlanId
                Gid = o.GunId
                ComboBox1.SelectedValue = maintId
                DateTimePicker1.Value = o.OperationStartDate
                DateTimePicker2.Value = o.OperationDueDate
                NumericUpDown1.Value = o.RoundsFired
                txtNotes.Text = o.Notes
                txtAmmoUsed.Text = o.AmmoUsed
                Bsid = o.BarrelSystemId
                chkInAVG.Checked = o.DoesCount
            Next
        Catch ex As Exception
            Call LogError(Name, "LoadData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmEditMaintenance control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditMaintenance_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Maintance_PlansTableAdapter.Fill(MGCDataSet.Maintance_Plans)
            Call LoadData()
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnViewPlans control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnViewPlans_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnViewPlans.Click
        Try
            frmViewMaintancePlan.MdiParent = MdiParent
            Dim strId As String = ComboBox1.SelectedValue
            frmViewMaintancePlan.Id = strId
            frmViewMaintancePlan.Show()
        Catch ex As Exception
            Call LogError(Name, "btnViewPlans_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim strId As String = ComboBox1.SelectedValue
            Dim strName As String = FluffContent(ComboBox1.Text)
            Dim strOd As String = DateTimePicker1.Value
            Dim strOdDue As String = DateTimePicker2.Value
            Dim strOdrf As String = NumericUpDown1.Value
            Dim strNotes As String = FluffContent(txtNotes.Text)
            Dim sAu As String = FluffContent(txtAmmoUsed.Text)

            If Not BurnSoft.Applications.MGC.Firearms.MaintanceDetails.Update(DatabasePath, Mid, strName, Gid, strId, strOd,strOdDue, strOdrf, strNotes, sAu,Bsid, chkInAVG.Checked, _errOut) Then Throw New Exception(_errOut)
            Close()
        Catch ex As Exception
            Call LogError(Name, "btnAdd.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the Button1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        frmAmmoCalc.MdiParent = MdiParent
        frmAmmoCalc.AmmoType = AmmoType
        frmAmmoCalc.AmmoTypePet = AmmoTypePet
        frmAmmoCalc.Show()
    End Sub
End Class