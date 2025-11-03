Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports BurnSoft.Applications.MGC
Imports Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel
''' <summary>
''' Class frmViewGeneralAccessories.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmViewGeneralAccessories
    Private Sub frmViewGeneralAccessories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the tsBtnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub tsBtnAdd_Click(sender As Object, e As EventArgs) Handles tsBtnAdd.Click
        OpenFrmAddAccessoryAndWait()
    End Sub
    ''' <summary>
    ''' Refreshes the data.
    ''' </summary>
    Private Sub RefreshData()
        General_AccessoriesTableAdapter.Fill(MGCDataSet.General_Accessories)
    End Sub
    ''' <summary>
    ''' Handles the Click event of the tsbRefresh control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        RefreshData()
    End Sub
    ''' <summary>
    ''' Opens the FRM add accessory and wait.
    ''' </summary>
    Private Sub OpenFrmAddAccessoryAndWait()
        ' Create the child form
        Dim child As New FrmAddAccessory
        child.MdiParent = MdiParent
        child.IsGeneral = True
        ' Attach handler for when the child closes
        AddHandler child.FormClosed, AddressOf ChildFormClosed
        ' Show the child form
        child.Show()
    End Sub

    ''' <summary>
    ''' This runs AFTER the child form is closed
    ''' </summary>
    ''' <param name="sender">The sender.</param>
    ''' <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
    Private Sub ChildFormClosed(sender As Object, e As FormClosedEventArgs)
        ' Remove handler to avoid memory leaks
        RemoveHandler DirectCast(sender, Form).FormClosed, AddressOf ChildFormClosed

        ' Call the next function
        NextFunction()
    End Sub
    ''' <summary>
    ''' Nexts the function.
    ''' </summary>
    Private Sub NextFunction()
        RefreshData()
    End Sub

    ''' <summary>
    ''' Opens the FRM add accessory and wait.
    ''' </summary>
    Private Sub OpenfrmEditAccessoryAndWait(itemId As String)
        ' Create the child form
        Dim child As New frmEditAccessory
        child.MdiParent = MdiParent
        child.ItemId = itemId
        child.IsGeneral = True
        ' Attach handler for when the child closes
        AddHandler child.FormClosed, AddressOf ChildFormClosed
        ' Show the child form
        child.Show()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the EditToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim itemId As String = dgvGeneralTable.SelectedRows.Item(0).Cells.Item(0).Value
        OpenfrmEditAccessoryAndWait(itemId)
    End Sub
End Class