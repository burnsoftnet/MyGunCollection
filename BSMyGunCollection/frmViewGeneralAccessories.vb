Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports BurnSoft.Applications.MGC
Imports Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel

Public Class frmViewGeneralAccessories
    Private Sub frmViewGeneralAccessories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MGCDataSet.General_Accessories' table. You can move, or remove it, as needed.
        'string sql = $"select * from General_Accessories where id={id}";
        'Dim sql As String = $"select * from General_Accessories"
        'Dim errOut As String = ""
        'Dim dt As DataTable = Database.GetDataFromTable(DatabasePath, sql, errOut)
        'DataTable dt = Database.GetDataFromTable(DatabasePath, Sql, out errOut);
        'Me.General_AccessoriesTableAdapter.Fill(Me.MGCDataSet.General_Accessories)
        'Me.General_AccessoriesTableAdapter.Fill(dt)
        General_AccessoriesTableAdapter.Fill(MGCDataSet.General_Accessories)
        ' dgvGeneralTable.DataSource = dt
    End Sub
    ''' <summary>
    ''' Handles the Click event of the tsBtnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub tsBtnAdd_Click(sender As Object, e As EventArgs) Handles tsBtnAdd.Click
        'Using frmNew As New FrmAddAccessory
        '    frmNew.MdiParent = MdiParent
        '    frmNew.IsGeneral = True
        '    frmNew.ShowDialog()
        'End Using

        'Dim frmNew As New FrmAddAccessory
        '''FrmAddAccessory.MdiParent = MdiParent
        'FrmAddAccessory.IsGeneral = True
        'Dim result As DialogResult = FrmAddAccessory.ShowDialog()

        'dgvGeneralTable.Refresh()
        OpenFrmAddAccessoryAndWait()
    End Sub

    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        General_AccessoriesTableAdapter.Fill(MGCDataSet.General_Accessories)
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
        General_AccessoriesTableAdapter.Fill(MGCDataSet.General_Accessories)
    End Sub
End Class