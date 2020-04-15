Imports BSMyGunCollection.MGC
Imports Microsoft.Reporting.WinForms
Public Class frmViewReport_WishList
    'Private Sub DoFit()
    '    If Me.Height <> 0 Then
    '         Me.ReportViewer1.Height = Me.Height - (46 + 15)
    '        Me.ReportViewer1.Width = Me.Width - 5
    '    End If
    'End Sub
    Private Sub frmViewReport_WishList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WishlistTableAdapter.Fill(Me.MGCDataSet.Wishlist)
        'Call DoFit()
        Try
            If PersonalMark Then
                Dim parmList As New Generic.List(Of ReportParameter)
                parmList.Add(New ReportParameter("UserName", OwnerName))
                parmList.Add(New ReportParameter("ReportTitle", OwnerName & " Wish List"))
                Me.ReportViewer1.LocalReport.SetParameters(parmList)
            End If
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmViewReport_WishList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ' Call DoFit()
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            Select Case LCase(UCase(ToolStripComboBox1.SelectedItem.ToString))
                Case LCase("Place To Buy")
                    Me.WishlistTableAdapter.FillByPlacetoBuy(Me.MGCDataSet.Wishlist)
                Case LCase("Qty.")
                    Me.WishlistTableAdapter.FillByQty(Me.MGCDataSet.Wishlist)
                Case LCase("Manufacturer")
                    Me.WishlistTableAdapter.FillByManufacturer(Me.MGCDataSet.Wishlist)
                Case LCase("Value")
                    Me.WishlistTableAdapter.FillByPrice(Me.MGCDataSet.Wishlist)
                Case Else
                    Me.WishlistTableAdapter.Fill(Me.MGCDataSet.Wishlist)
            End Select
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripComboBox1_SelectedIndexChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class