Imports BSMyGunCollection.MGCDataSetTableAdapters
Imports BurnSoft.Applications.MGC

Public Class frmViewGeneralAccessories
    Private Sub frmViewGeneralAccessories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MGCDataSet.General_Accessories' table. You can move, or remove it, as needed.
        'string sql = $"select * from General_Accessories where id={id}";
        Dim sql As String = $"select * from General_Accessories"
        Dim errOut As String = ""
        Dim dt As DataTable = Database.GetDataFromTable(DatabasePath, sql, errOut)
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
        FrmAddAccessory.MdiParent = MdiParent
        FrmAddAccessory.IsGeneral = True
        FrmAddAccessory.Show()
        'dgvGeneralTable.Refresh()
    End Sub

    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        dgvGeneralTable.Refresh()
    End Sub
End Class