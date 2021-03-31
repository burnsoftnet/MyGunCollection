Imports BSMyGunCollection.MGC
Imports BurnSoft.Applications.MGC.Firearms

''' <summary>
''' Class frmAddMaintance.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddMaintance
    ''' <summary>
    ''' The gun id
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
    ''' The ammo type cal3
    ''' </summary>
    Public AmmoTypeCal3 As String
    ''' <summary>
    ''' The bsid
    ''' </summary>
    Public Bsid As String
    ''' <summary>
    ''' Handles the Load event of the frmAddMaintance control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddMaintance_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Maintance_PlansTableAdapter.Fill(MGCDataSet.Maintance_Plans)
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Dim sSubFunc As String = "btnViewPlans_Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Dim inAvg As Boolean = chkInAVG.Checked
            Dim sAu As String = FluffContent(txtAmmoUsed.Text)
            Dim iAvg As Integer = 0
            If inAvg Then iAvg = 1
            If Not IsRequired(strName, "Maintenance Plan", Text) Then Exit Sub
            Dim errOut As String = ""
            If Not MaintanceDetails.Add(DatabasePath, strName, Gid, strId, strOd, strOdDue, strOdrf, strNotes, sAu,Bsid, iAvg, errOut) Then Throw New Exception(errOut)

            'Dim sql As String = "INSERT INTO Maintance_Details(gid,mpid,Name,OpDate,OpDueDate,RndFired,Notes,au,BSID,DC,sync_lastupdate) VALUES(" &
            '            Gid & "," & strId & ",'" & strName & "','" & strOd & "','" & strOdDue & "','" &
            '            strOdrf & "','" & strNotes & "','" & sAu & "'," & Bsid & "," & iAvg & ",Now())"
            'Dim obj As New BSDatabase
            'obj.ConnExec(sql)
            MsgBox(strName & " was added!", MsgBoxStyle.Information, Text)
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
        frmAmmoCalc.AmmoTypeCal3 = AmmoTypeCal3
        frmAmmoCalc.Show()
    End Sub
End Class