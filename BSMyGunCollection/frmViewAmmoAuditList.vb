Imports BSMyGunCollection.MGC
Public Class frmViewAmmoAuditList
    Public AID As Long
    Public sName As String
    Sub LoadData()
        Try
            Me.Gun_Collection_Ammo_PriceAuditTableAdapter.FillBy_AID(Me.MGCDataSet.Gun_Collection_Ammo_PriceAudit, AID)
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub LoadViewSize()
        If My.Settings.ViewAmmoadt_Width.Length > 0 And My.Settings.ViewAmmoadt_Height.Length > 0 Then
            Me.Height = My.Settings.ViewAmmoadt_Height
            Me.Width = My.Settings.ViewAmmoadt_Width
        End If
        If My.Settings.ViewAmmoadt_X.Length > 0 And My.Settings.ViewAmmoadt_Y.Length > 0 Then
            Me.Location = New System.Drawing.Point(My.Settings.ViewAmmoadt_X, My.Settings.ViewAmmoadt_Y)
        End If
    End Sub
    Sub SaveViewSize()
        My.Settings.ViewAmmoadt_Height = Me.Height
        My.Settings.ViewAmmoadt_Width = Me.Width
        My.Settings.ViewAmmoadt_X = Me.Location.X
        My.Settings.ViewAmmoadt_Y = Me.Location.Y
        My.Settings.Save()
    End Sub

    Private Sub frmViewAmmoAuditList_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call SaveViewSize()
    End Sub
    Private Sub frmViewAmmoAuditList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Ammo Audit - " & sName
        Call LoadViewSize()
        Call LoadData()
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Call LoadData()
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            Dim ItemID As Long = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Dim Qty As Long = DataGridView1.SelectedRows.Item(0).Cells.Item(2).Value
            Dim Price As Double = DataGridView1.SelectedRows.Item(0).Cells.Item(3).Value
            Dim PPB As Double = FormatNumber(Price / Qty, 2)
            Dim Obj As New BSDatabase
            Dim SQL As String = "UPDATE Gun_Collection_Ammo_PriceAudit set PPB=" & _
                                PPB & " where ID=" & ItemID
            Obj.ConnExec(SQL)
            Obj = Nothing
            Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripButton2_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class