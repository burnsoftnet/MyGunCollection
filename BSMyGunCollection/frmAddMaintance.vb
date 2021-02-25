Imports BSMyGunCollection.MGC
''' <summary>
''' Class frmAddMaintance.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
' ReSharper disable InconsistentNaming
Public Class frmAddMaintance
' ReSharper restore InconsistentNaming
    ''' <summary>
    ''' The gun id
    ''' </summary>
    Public GID As String
    ''' <summary>
    ''' The ammo type
    ''' </summary>
    Public AmmoType As String
    ''' <summary>
    ''' The ammo type pet
    ''' </summary>
    Public AmmoTypePet As String
    ''' <summary>
    ''' The ammo type cal3
    ''' </summary>
    Public AmmoTypeCal3 As String
    ''' <summary>
    ''' The bsid
    ''' </summary>
    Public BSID As String
    ''' <summary>
    ''' Handles the Load event of the frmAddMaintance control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddMaintance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Maintance_PlansTableAdapter.Fill(Me.MGCDataSet.Maintance_Plans)
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnViewPlans control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnViewPlans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewPlans.Click
        Try
            frmViewMaintancePlan.MdiParent = Me.MdiParent
            Dim strID As String = ComboBox1.SelectedValue
            frmViewMaintancePlan.ID = strID
            frmViewMaintancePlan.Show()
        Catch ex As Exception
            Dim sSubFunc As String = "btnViewPlans_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim strID As String = ComboBox1.SelectedValue
            Dim strName As String = FluffContent(ComboBox1.Text)
            Dim strOD As String = DateTimePicker1.Value
            Dim strODDue As String = DateTimePicker2.Value
            Dim strODRF As String = NumericUpDown1.Value
            Dim strNotes As String = FluffContent(txtNotes.Text)
            Dim InAvg As Boolean = chkInAVG.Checked
            Dim sAU As String = FluffContent(txtAmmoUsed.Text)
            Dim iAvg As Integer = 0
            If InAvg Then iAvg = 1
            If Not IsRequired(strName, "Maintenance Plan", Me.Text) Then Exit Sub
            Dim SQL As String = "INSERT INTO Maintance_Details(gid,mpid,Name,OpDate,OpDueDate,RndFired,Notes,au,BSID,DC,sync_lastupdate) VALUES(" &
                        GID & "," & strID & ",'" & strName & "','" & strOD & "','" & strODDue & "','" &
                        strODRF & "','" & strNotes & "','" & sAU & "'," & BSID & "," & iAvg & ",Now())"
            Dim Obj As New BSDatabase
            Obj.ConnExec(SQL)
            MsgBox(strName & " was added!", MsgBoxStyle.Information, Me.Text)
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the Button1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmAmmoCalc.MdiParent = Me.MdiParent
        frmAmmoCalc.AmmoType = AmmoType
        frmAmmoCalc.AmmoTypePet = AmmoTypePet
        frmAmmoCalc.AmmoTypeCal3 = AmmoTypeCal3
        frmAmmoCalc.Show()
    End Sub
End Class