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
End Class