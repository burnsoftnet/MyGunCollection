Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Public Class frmEditWishlist
    Public ItemID As String
    Private strName As String
    Sub UpdateData()
        Try
            Dim Obj As New BSDatabase
            Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Wishlist where ID=" & ItemID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While (RS.Read)
                txtManu.Text = Trim(RS("Manufacturer"))
                txtModel.Text = Trim(RS("Model"))
                txtSS.Text = Trim(RS("PlacetoBuy"))
                txtQty.Text = Trim(RS("Qty"))
                txtValue.Text = Trim(RS("Value"))
                txtNotes.Text = Trim(RS("Notes"))
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "UpdateData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub frmEditWishlist_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Len(ItemID) = 0 Then End
        Dim ObjG As New GlobalFunctions
        strName = ObjG.GetWishListName(ItemID)
        Me.Text = strName
        Call UpdateData()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
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
            SQL = "UPDATE Wishlist set Manufacturer='" & strManu & "',Model='" & strModel & _
                    "',PlacetoBuy='" & strSS & "',Qty='" & strQty & "',[Value]='" & strValue & _
                    "',Notes='" & strNotes & "',sync_lastupdate=Now() where id=" & ItemID
            Obj.ConnExec(SQL)
        Catch ex As Exception
            Dim sSubFunc As String = "btnEdit.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Me.Close()
    End Sub
End Class