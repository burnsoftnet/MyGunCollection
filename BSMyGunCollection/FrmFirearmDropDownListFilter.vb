Imports BSMyGunCollection.LogginAndSettings

Public Class FrmFirearmDropDownListFilter

    Public Dim CurrentFilter As String()
    Private Sub FrmFirearmDropDownListFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj As New FormData
        ChkLstBxItems.DataSource = obj.GenerateDropDownList
    End Sub
End Class