Imports BSMyGunCollection.MGC
''' <summary>
''' Class frmAddToWishList.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddToWishList
    ''' <summary>
    ''' Does the automatic fill.
    ''' </summary>
    Private Sub DoAutoFill()
        Try
            Dim ObjAF As New AutoFillCollections
            txtManu.AutoCompleteCustomSource = ObjAF.Wishlist_Manufacturer
            txtModel.AutoCompleteCustomSource = ObjAF.Wishlist_Model
            txtSS.AutoCompleteCustomSource = ObjAF.Wishlist_Shop
            txtValue.AutoCompleteCustomSource = ObjAF.Wishlist_Price
        Catch ex As Exception
            Dim sSubFunc As String = "DoAutoFill"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim ObjGF As New GlobalFunctions
            Dim Obj As New BSDatabase
            Dim strManu As String = FluffContent(txtManu.Text)
            Dim strModel As String = FluffContent(txtModel.Text)
            Dim strSS As String = FluffContent(txtSS.Text)
            Dim strQty As String = txtQty.Text
            Dim strValue As String = FluffContent(txtValue.Text)
            Dim strNotes As String = FluffContent(txtNotes.Text)
            Dim SQL As String = ""
            If Not IsRequired(strManu, "Manufacturer", Me.Text) Then Exit Sub
            If Not IsRequired(strModel, "Model", Me.Text) Then Exit Sub
            If Not IsRequired(strQty, "Qty", Me.Text) Then Exit Sub
            If Not IsRequired(strValue, "Value", Me.Text) Then Exit Sub

            If Not ObjGF.ObjectExistsinDB(strModel, "Model", "Wishlist") Then
                SQL = "INSERT INTO Wishlist (Manufacturer,Model,PlacetoBuy,Qty,[Value],Notes,sync_lastupdate) VALUES('" &
                        strManu & "','" & strModel & "','" & strSS & "','" & strQty & "','" &
                        strValue & "','" & strNotes & "',Now())"
                Obj.ConnExec(SQL)
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Me.Close()
    End Sub
    ''' <summary>
    ''' Converts to wishlist_load.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddToWishList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Call DoAutoFill()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class