''' <summary>
''' Class frmViewAmmoAuditList.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmViewAmmoAuditList
    ''' <summary>
    ''' The aid
    ''' </summary>
    Public Aid As Long
    ''' <summary>
    ''' The s name
    ''' </summary>
    Public SName As String
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim errOut as String
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Gun_Collection_Ammo_PriceAuditTableAdapter.FillBy_AID(MGCDataSet.Gun_Collection_Ammo_PriceAudit, Aid)
        Catch ex As Exception
            Call LogError(Name, "LoadData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Loads the size of the view.
    ''' </summary>
    Sub LoadViewSize()
        If My.Settings.ViewAmmoadt_Width.Length > 0 And My.Settings.ViewAmmoadt_Height.Length > 0 Then
            Height = My.Settings.ViewAmmoadt_Height
            Width = My.Settings.ViewAmmoadt_Width
        End If
        If My.Settings.ViewAmmoadt_X.Length > 0 And My.Settings.ViewAmmoadt_Y.Length > 0 Then
            Location = New Point(My.Settings.ViewAmmoadt_X, My.Settings.ViewAmmoadt_Y)
        End If
    End Sub
    ''' <summary>
    ''' Saves the size of the view.
    ''' </summary>
    Sub SaveViewSize()
        My.Settings.ViewAmmoadt_Height = Height
        My.Settings.ViewAmmoadt_Width = Width
        My.Settings.ViewAmmoadt_X = Location.X
        My.Settings.ViewAmmoadt_Y = Location.Y
        My.Settings.Save()
    End Sub
    ''' <summary>
    ''' Handles the Disposed event of the frmViewAmmoAuditList control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewAmmoAuditList_Disposed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Disposed
        Call SaveViewSize()
    End Sub
    Private Sub frmViewAmmoAuditList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Text = $"Ammo Audit - " & SName
        Call LoadViewSize()
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton3 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton3.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton1.Click
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the ToolStripButton2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripButton2.Click
        Try
            Dim itemId As Long = DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value
            Dim qty As Long = DataGridView1.SelectedRows.Item(0).Cells.Item(2).Value
            Dim price As Double = DataGridView1.SelectedRows.Item(0).Cells.Item(3).Value
' ReSharper disable once LocalVariableHidesMember
            Dim ppb As Double = FormatNumber(price / qty, 2)
          
            If Not BurnSoft.Applications.MGC.Ammo.Audit.UpdatePricePerBullet(DatabasePath, itemId, ppb, errOut) Then Throw New Exception(errOut)
            Call LoadData()
        Catch ex As Exception
            Call LogError(Name, "ToolStripButton2_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class