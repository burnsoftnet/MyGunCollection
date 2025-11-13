Public Class frmViewBarrelSystemData
    Private Sub frmViewBarrelSystemData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MGCDataSet.Gun_Collection_Ext' table. You can move, or remove it, as needed.
        Me.Gun_Collection_ExtTableAdapter.Fill(Me.MGCDataSet.Gun_Collection_Ext)

    End Sub
End Class