Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
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
    ''' Updates the data.
    ''' </summary>
    Sub UpdateData()
        Try
            Dim obj As New BSDatabase
            obj.ConnectDB()
            Dim sql As String = "SELECT * from Wishlist where ID=" & ItemId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            While (rs.Read)
                txtManu.Text = Trim(rs("Manufacturer"))
                txtModel.Text = Trim(rs("Model"))
                txtSS.Text = Trim(rs("PlacetoBuy"))
                txtQty.Text = Trim(rs("Qty"))
                txtValue.Text = Trim(rs("Value"))
                txtNotes.Text = Trim(rs("Notes"))
            End While
            rs.Close()
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "UpdateData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmEditWishlist control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditWishlist_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Len(ItemId) = 0 Then End
        Dim objG As New GlobalFunctions
        _strName = objG.GetWishListName(ItemId)
        Text = _strName
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
            Dim obj As New BSDatabase
            Dim strManu As String = FluffContent(txtManu.Text)
            Dim strModel As String = FluffContent(txtModel.Text)
            Dim strSs As String = FluffContent(txtSS.Text)
            Dim strQty As String = txtQty.Text
            Dim strValue As String = FluffContent(txtValue.Text)
            Dim strNotes As String = FluffContent(txtNotes.Text)
            Dim sql As String 
            If Not IsRequired(strManu, "Manufacturer", Text) Then Exit Sub
            If Not IsRequired(strModel, "Model", Text) Then Exit Sub
            If Not IsRequired(strQty, "Qty", Text) Then Exit Sub
            If Not IsRequired(strValue, "Value", Text) Then Exit Sub
            sql = "UPDATE Wishlist set Manufacturer='" & strManu & "',Model='" & strModel & _
                    "',PlacetoBuy='" & strSs & "',Qty='" & strQty & "',[Value]='" & strValue & _
                    "',Notes='" & strNotes & "',sync_lastupdate=Now() where id=" & ItemId
            obj.ConnExec(sql)
        Catch ex As Exception
            Dim sSubFunc As String = "btnEdit.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Close()
    End Sub
End Class