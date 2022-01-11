Imports BSMyGunCollection.MGC
Imports BurnSoft.Applications.MGC.Global
Imports BurnSoft.Applications.MGC.Other
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class FrmEditWishlist.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmEditWishlist
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemId As String
    ''' <summary>
    ''' The string name
    ''' </summary>
    Private _strName As String
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String
    ''' <summary>
    ''' Updates the data.
    ''' </summary>
    Sub UpdateData()
        Try

            Dim lst As List(Of WishlistList) = WishList.List(DatabasePath, Convert.ToInt32(ItemId), _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            For Each l As WishlistList In lst
                txtManu.Text = l.Manufacturer
                txtModel.Text = l.Model
                txtSS.Text = l.PlacetoBuy
                txtQty.Text = l.Qty
                txtValue.Text = l.Value
                txtNotes.Text = l.Notes
            Next
        Catch ex As Exception
            Call LogError(Name, "UpdateData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmEditWishlist control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditWishlist_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            If Len(ItemId) = 0 Then End
            _strName = WishList.GetName(DatabasePath, Convert.ToInt32(ItemId), _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            Text = _strName
        Catch ex As Exception
            Call LogError(Name, "frmEditWishlist_Load", Err.Number, ex.Message.ToString)
        End Try
        Call UpdateData()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnEdit control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        Try
            Dim strManu As String = FluffContent(txtManu.Text)
            Dim strModel As String = FluffContent(txtModel.Text)
            Dim strSs As String = FluffContent(txtSS.Text)
            Dim strQty As String = txtQty.Text
            Dim strValue As String = FluffContent(txtValue.Text)
            Dim strNotes As String = FluffContent(txtNotes.Text)

            If Not Helpers.IsRequired(strManu, "Manufacturer", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(strModel, "Model", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(strQty, "Qty", Text, _errOut) Then Exit Sub
            If Not Helpers.IsRequired(strValue, "Value", Text, _errOut) Then Exit Sub
            
            If Not WishList.Update(DatabaseName, ItemId, strManu, strModel, strSs, strQty, strValue,strNotes, _errOut) Then Throw New Exception(_errOut)
        Catch ex As Exception
            Call LogError(Name, "btnEdit.Click", Err.Number, ex.Message.ToString)
        End Try
        Close()
    End Sub
End Class