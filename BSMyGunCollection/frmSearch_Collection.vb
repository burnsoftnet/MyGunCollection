Imports BSMyGunCollection.MGC
Imports BurnSoft.Applications.MGC

''' <summary>
''' Class FrmSearchCollection.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmSearchCollection
    ''' <summary>
    ''' Builds the search string.
    ''' </summary>
    ''' <param name="sLookin">The s lookin.</param>
    ''' <returns>System.Object.</returns>
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
    ''' <summary>
    ''' Handles the Click event of the btnSearch control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Try
            Dim sql As String = "SELECT ID,FullName as [Full Name],Brand,ModelName as [Model],SerialNumber as [Serial No],Type,Caliber from qryGunCollectionDetails where " & _
                BuildSearchString(cmbLookIn.Text) & " like'%" & txtLookFor.Text & "%'"
            Dim errOut As String = ""
            dgvResults.DataSource = Database.GetDataFromTable(DatabasePath, sql, errOut)
            dgvResults.Columns(0).Visible = False
            lblResults.Text = dgvResults.RowCount
            If dgvResults.RowCount = 1 Then Call ViewCollectionDetails()
        Catch ex As Exception
            Dim strProcedure As String = "btnSearch.Click"
            Call LogError(Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Views the collection details.
    ''' </summary>
    Sub ViewCollectionDetails()
        Try
            Dim rowId As Long = dgvResults.SelectedCells.Item(0).Value
            Cursor = Cursors.WaitCursor
            Dim frmNew As New frmViewCollectionDetails
            frmNew.MdiParent = MdiParent
            frmNew.GunId = rowId
            frmNew.Show()
            Cursor = Cursors.Arrow
        Catch ex As Exception
            Dim strProcedure As String = "ViewCollectionDetails"
            Call LogError(Name, strProcedure, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the CellDoubleClick event of the dgvResults control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
    Private Sub dgvResults_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvResults.CellDoubleClick
        Call ViewCollectionDetails()
    End Sub
    ''' <summary>
    ''' Handles the Resize event of the frmSearch_Collection control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmSearch_Collection_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        dgvResults.Width = Width - 25
        dgvResults.Height = Height - 140
    End Sub
End Class