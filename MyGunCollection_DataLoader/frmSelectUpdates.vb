Public Class frmSelectUpdates
    Private Sub frmSelectUpdates_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblTitle.Text = Application.ProductName
        Me.Text = Application.ProductName
        bAmmo = False
        bGripType = False
        bManufacturer = False
        bModel = False
        BNationality = False
        bType = False
        BMaintPlan = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Dim SelectedItemsText As String = ""
        Dim ItemsText As String = ""
        Dim i As Integer = 0
        If Not CheckBox1.Checked Then
            bAmmo = CheckBox2.Checked
            bGripType = CheckBox3.Checked
            bManufacturer = CheckBox4.Checked
            bModel = CheckBox5.Checked
            BNationality = CheckBox6.Checked
            bType = CheckBox7.Checked
            BMaintPlan = CheckBox8.Checked
        Else
            bAmmo = True
            bGripType = True
            bManufacturer = True
            bModel = True
            BNationality = True
            bType = True
            BMaintPlan = True
        End If
        frmDownloadUpdates.Show()
        Me.Close()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.Checked Then CheckBox1.Checked = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox1.Checked Then CheckBox1.Checked = False
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox1.Checked Then CheckBox1.Checked = False
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox1.Checked Then CheckBox1.Checked = False
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox1.Checked Then CheckBox1.Checked = False
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox1.Checked Then CheckBox1.Checked = False
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox1.Checked Then CheckBox1.Checked = False
    End Sub
End Class