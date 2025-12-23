Imports BurnSoft.Applications.MGC
Imports BurnSoft.Applications.MGC.Other
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class frmViewGeneralAccessories.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmViewGeneralAccessories
    Private errOut as String 
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
    ''' <summary>
    ''' Determines whether the specified item is attached to other firearms.
    ''' </summary>
    ''' <param name="item">The item.</param>
    ''' <returns><c>true</c> if the specified item is attached; otherwise, <c>false</c>.</returns>
    ''' <exception cref="System.Exception"></exception>
    Private Function IsAttached(item As Integer) As Boolean
        Dim bAns  As Boolean = False
        Try
            Dim lst As List(Of GeneralAccessoriesLinkers) = Other.GeneralAccessoriesLinking.Lists(DatabasePath, item, errOut)
            If errOut.Length > 0 Then Throw New Exception(errOut)
            bAns = lst.Count > 0
        Catch ex As Exception
            Call LogError(Name, "IsAttached", Err.Number, ex.Message.ToString)
        End Try
        Return bAns
    End Function
    ''' <summary>
    ''' Handles the Click event of the DeleteToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    ''' <exception cref="System.Exception"></exception>
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            Dim itemId As String = dgvGeneralTable.SelectedRows.Item(0).Cells.Item(0).Value
            Dim deleteAll As Boolean = False
            Dim msgAnsMain As String = MsgBox("Are you sure you want to delete this accessory?", MsgBoxStyle.YesNo, "Delete Accessory")
            If msgAnsMain = vbYes Then
                If IsAttached(CInt(itemId)) Then
                    Dim msgAns As String = MsgBox("Do you want to delete this accessory from attached firearms?", MsgBoxStyle.YesNo, "Delete Accessory")
                    If msgAns = vbYes Then
                        deleteAll = True
                    End If
                End If
                if Not Other.GeneralAccessories.Delete(DatabasePath, cint(itemId), deleteAll, errOut) Then Throw New Exception(errOut)
                MsgBox("Accessory was Deleted!")
                RefreshData()
            End If
        Catch ex As Exception
            Call LogError(Name, "DeleteToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the AttachToFirearmToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub AttachToFirearmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttachToFirearmToolStripMenuItem.Click
        Try 
            Dim itemId As Long = Clng(dgvGeneralTable.SelectedRows.Item(0).Cells.Item(0).Value)
            Dim frmNew As New FrmLinkAccessoryToFirearm
            frmNew.AccessoryId = itemId
            frmNew.MdiParent = MdiParent
            frmNew.Show()
        Catch ex As Exception
            Call LogError(Name, "AttachToFirearmToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the DuplicateToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    ''' <exception cref="System.Exception"></exception>
    Private Sub DuplicateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicateToolStripMenuItem.Click
        Try 
            Dim itemId As Long = Clng(dgvGeneralTable.SelectedRows.Item(0).Cells.Item(0).Value)
            if Not GeneralAccessories.Duplicate(DatabasePath, itemId, errOut) Then Throw New Exception(errOut)
            MsgBox("Accessory was Duplicated!")
            RefreshData()
        Catch ex As Exception
            Call LogError(Name, "DuplicateToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the MoveToAFirearmToolStripMenuItem control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub MoveToAFirearmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveToAFirearmToolStripMenuItem.Click
        Try 
            Dim itemId As Long = Clng(dgvGeneralTable.SelectedRows.Item(0).Cells.Item(0).Value)
            Dim frmNew As New FrmLinkAccessoryToFirearm
            frmNew.AccessoryId = itemId
            frmNew.MdiParent = MdiParent
            frmNew.MoveMode = True
            frmNew.Show()
        Catch ex As Exception
            Call LogError(Name, "MoveToAFirearmToolStripMenuItem_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class