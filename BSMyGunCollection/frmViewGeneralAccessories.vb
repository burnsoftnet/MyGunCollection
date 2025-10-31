Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports BurnSoft.Applications.MGC
Imports Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel

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
    Private Sub RefreshData()
        General_AccessoriesTableAdapter.Fill(MGCDataSet.General_Accessories)
    End Sub
    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        RefreshData()
    End Sub

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

    ' This runs AFTER the child form is closed
    Private Sub ChildFormClosed(sender As Object, e As FormClosedEventArgs)
        ' Remove handler to avoid memory leaks
        RemoveHandler DirectCast(sender, Form).FormClosed, AddressOf ChildFormClosed

        ' Call the next function
        NextFunction()
    End Sub

    Private Sub NextFunction()
        RefreshData()
    End Sub
End Class