Imports BSMyGunCollection.MGC
Public Class frmAddMaintance
    Public GID As String
    Public AmmoType As String
    Public AmmoTypePet As String
    Public AmmoTypeCal3 As String
    Public BSID As String
    Private Sub frmAddMaintance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Maintance_PlansTableAdapter.Fill(Me.MGCDataSet.Maintance_Plans)
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

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
            Dim SQL As String = "INSERT INTO Maintance_Details(gid,mpid,Name,OpDate,OpDueDate,RndFired,Notes,au,BSID,DC,sync_lastupdate) VALUES(" & _
                        GID & "," & strID & ",'" & strName & "','" & strOD & "','" & strODDue & "','" & _
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmAmmoCalc.MdiParent = Me.MdiParent
        frmAmmoCalc.AmmoType = AmmoType
        frmAmmoCalc.AmmoTypePet = AmmoTypePet
        frmAmmoCalc.AmmoTypeCal3 = AmmoTypeCal3
        frmAmmoCalc.Show()
    End Sub
End Class