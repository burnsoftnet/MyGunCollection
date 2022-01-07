
''' <summary>
''' Class frmEditModel.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmEditModel
    ''' <summary>
    ''' The update pending
    ''' </summary>
    Public UpdatePending As Boolean
    ''' <summary>
    ''' Handles the Load event of the frmEditModel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditModel_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call LoadData()
    End Sub
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Public Sub LoadData()
        Try
            GryGunModelToManufacturerTableAdapter.Fill(MGCDataSet.gryGunModelToManufacturer)
        Catch ex As Exception
            Call LogError(Name, "LoadData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmEditModel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditModel_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Try
            If Height <> 0 Then
                DataGridView1.Height = Height - 38
                DataGridView1.Width = Width - 19
            End If
        Catch ex As Exception
            Call LogError(Name, "Resize", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            Dim myId As Integer = CInt(DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value.ToString)
            Dim manu As String = DataGridView1.SelectedRows.Item(0).Cells.Item(1).Value.ToString
            Dim model As String = DataGridView1.SelectedRows.Item(0).Cells.Item(2).Value.ToString
            Dim strFull As String = manu & " " & model
            Dim sAns As String = MsgBox("Are you sure you wish to delete " & strFull & "?", MsgBoxStyle.YesNo, "Delete Model")
            If sAns = vbYes Then
                Dim errOut As String =""
                If Not BurnSoft.Applications.MGC.Firearms.Models.Delete(DatabasePath, myId, errOut) Then Throw New Exception(errOut)
                Call LoadData()
            End If
        Catch ex As Exception
            Call LogError(Name, "DeleteToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Converts to olstripmenuitem_click.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            Dim myId As Integer = CInt(DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value.ToString)
            Dim manu As String = DataGridView1.SelectedRows.Item(0).Cells.Item(1).Value.ToString
            Dim model As String = DataGridView1.SelectedRows.Item(0).Cells.Item(2).Value.ToString
            Dim frmNew As New frmEditModelTypes
            frmNew.ModelId = myId
            frmNew.ModelName = model
            frmNew.ManufacturersName = manu
            frmNew.MdiParent = MdiParent
            frmNew.Show()
        Catch ex As Exception
            Call LogError(Name, "EditToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class