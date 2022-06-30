
Imports BurnSoft.Applications.MGC.Global

''' <summary>
''' Class frmAddToWishList.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddToWishList
    Dim _errOut as String
    ''' <summary>
    ''' Does the automatic fill.
    ''' </summary>
    Private Sub DoAutoFill()
        Try
            txtManu.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.WhisList.Manufacturer(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            txtModel.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.WhisList.Model(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            txtSS.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.WhisList.Shops(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            txtValue.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.WhisList.Price(DatabasePath, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)

        Catch ex As Exception
            Call LogError(Name, "DoAutoFill", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
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


            If Not BurnSoft.Applications.MGC.Other.WishList.Exists(DatabasePath, strManu, strModel, _errOut) Then
                If Not BurnSoft.Applications.MGC.Other.WishList.Add(DatabasePath, strManu, strModel, strSs, strQty, strValue, strNotes, _errOut) Then Throw new Exception(_errOut)
            End If
        Catch ex As Exception
            Call LogError(Name, "btnAdd.Click", Err.Number, ex.Message.ToString)
        End Try
        Close()
    End Sub
    ''' <summary>
    ''' Converts to wishlist_load.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddToWishList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            Call DoAutoFill()
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class