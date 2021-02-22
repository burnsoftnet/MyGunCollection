Imports BSMyGunCollection.MGC
''' <summary>
''' Class frmEditModel.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmEditModel
    ''' <summary>
    ''' The update pending
    ''' </summary>
    Public UpdatePending As Boolean
    ''' <summary>
    ''' Handles the Load event of the frmEditModel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditModel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Public Sub LoadData()
        Try
            Me.GryGunModelToManufacturerTableAdapter.Fill(Me.MGCDataSet.gryGunModelToManufacturer)
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmEditModel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditModel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            If Me.Height <> 0 Then
                DataGridView1.Height = Me.Height - 38
                DataGridView1.Width = Me.Width - 19
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "Resize"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            Dim MyID As Integer = CInt(DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value.ToString)
            Dim Manu As String = DataGridView1.SelectedRows.Item(0).Cells.Item(1).Value.ToString
            Dim Model As String = DataGridView1.SelectedRows.Item(0).Cells.Item(2).Value.ToString
            Dim strFull As String = Manu & " " & Model
            Dim sAns As String = MsgBox("Are you sure you wish to delete " & strFull & "?", MsgBoxStyle.YesNo, "Delete Model")
            If sAns = vbYes Then
                Dim Obj As New BSDatabase
                Dim SQL As String = "DELETE FROM Gun_Model where ID=" & MyID
                Obj.ConnExec(SQL)
                Call LoadData()
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "DeleteToolStripMenuItem_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Try
            Dim MyID As Integer = CInt(DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value.ToString)
            Dim Manu As String = DataGridView1.SelectedRows.Item(0).Cells.Item(1).Value.ToString
            Dim Model As String = DataGridView1.SelectedRows.Item(0).Cells.Item(2).Value.ToString
            Dim frmNew As New frmEditModelTypes
            frmNew.ModelID = MyID
            frmNew.ModelName = Model
            frmNew.ManufacturersName = Manu
            frmNew.MdiParent = Me.MdiParent
            frmNew.Show()
        Catch ex As Exception
            Dim sSubFunc As String = "EditToolStripMenuItem_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class