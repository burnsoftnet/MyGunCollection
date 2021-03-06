Public Class frmSearch_Collection
    Function BuildSearchString(ByVal sLookin As String)
        Dim sAns As String = ""
        Select Case LCase(sLookin)
            Case LCase("Display Name")
                sAns = "FullName"
            Case LCase("Manufacturer")
                sAns = "Brand"
            Case LCase("Model Name")
                sAns = "ModelName"
            Case LCase("Serial No.")
                sAns = "SerialNumber"
            Case LCase("Type")
                sAns = "Type"
            Case LCase("Caliber")
                sAns = "Caliber"
            Case LCase("Finish")
                sAns = "Finish"
            Case LCase("Condition")
                sAns = "Condition"
            Case LCase("Custom Catalog ID.")
                sAns = "CustomID"
            Case LCase("Weight")
                sAns = "Weight"
            Case LCase("Height")
                sAns = "Height"
            Case LCase("Stock Type")
                sAns = "StockType"
            Case LCase("Barrel Length")
                sAns = "BarrelLength"
            Case LCase("Action")
                sAns = "Action"
            Case LCase("Feed System")
                sAns = "FeedSystem"
            Case LCase("Sights")
                sAns = "Sights"
            Case LCase("Purchased Price")
                sAns = "PurchasedPrice"
            Case LCase("Purchased From")
                sAns = "PurchasedFrom"
            Case LCase("Storage Location")
                sAns = "StorageLocation"
            Case LCase("Additional Notes")
                sAns = "AdditionalNotes"
            Case LCase("Produced")
                sAns = "Produced"
            Case LCase("Pet Loads")
                sAns = "PetLoads"
            Case LCase("Condition Comments")
                sAns = "ConditionComments"
        End Select
        Return sAns
    End Function
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim SQL As String = "SELECT ID,FullName as [Full Name],Brand,ModelName as [Model],SerialNumber as [Serial No],Type,Caliber from qryGunCollectionDetails where " & _
                BuildSearchString(cmbLookIn.Text) & " like'%" & txtLookFor.Text & "%'"
            Dim Obj As New MGC.BSDatabase
            dgvResults.DataSource = Obj.GetData(SQL)
            dgvResults.Columns(0).Visible = False
            lblResults.Text = dgvResults.RowCount
            If dgvResults.RowCount = 1 Then Call ViewCollectionDetails()
        Catch ex As Exception
            Dim strProcedure As String = "btnSearch.Click"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Sub ViewCollectionDetails()
        Try
            Dim RowID As Long = dgvResults.SelectedCells.Item(0).Value
            Me.Cursor = Cursors.WaitCursor
            Dim frmNew As New frmViewCollectionDetails
            frmNew.MdiParent = Me.MdiParent
            frmNew.ItemId = RowID
            frmNew.Show()
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Dim strProcedure As String = "ViewCollectionDetails"
            Call LogError(Me.Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub dgvResults_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvResults.CellDoubleClick
        Call ViewCollectionDetails()
    End Sub
    Private Sub frmSearch_Collection_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        dgvResults.Width = Me.Width - 25
        dgvResults.Height = Me.Height - 140
    End Sub
End Class