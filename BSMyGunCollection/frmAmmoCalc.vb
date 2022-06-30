''' <summary>
''' Class frmAmmoCalc.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAmmoCalc
    ''' <summary>
    ''' The ammo type
    ''' </summary>
    Public AmmoType As String
    ''' <summary>
    ''' The ammo type pet
    ''' </summary>
    Public AmmoTypePet As String
    ''' <summary>
    ''' The ammo type cal3
    ''' </summary>
    Public AmmoTypeCal3 As String
    ''' <summary>
    ''' The ammo used
    ''' </summary>
    Public AmmoUsed As String
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String
    ''' <summary>
    ''' Handles the Click event of the Button1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFinish.Click
        If chkbxUI.Checked Then Call UpdateInventory()
        frmAddMaintance.NumericUpDown1.Value = CInt(lblTotal.Text)
        frmAddMaintance.txtAmmoUsed.Text = AmmoUsed
        Close()
    End Sub

    '''' <summary>
    ''' Updates the inventory.
    ''' </summary>
    Sub UpdateInventory()
        Try
            Dim i As Integer
            Dim intItemCount As Integer = ListView1.Items.Count
            Dim intId As Integer
            Dim intQty As Integer
            Dim intCurQty As Integer
            AmmoUsed = ""
            For i = 0 To intItemCount - 1
                intQty = CInt(ListView1.Items(i).SubItems(2).Text)
                intId = CInt(ListView1.Items(i).SubItems(0).Text)
                intCurQty = BurnSoft.Applications.MGC.Ammo.Inventory.GetQty(DatabasePath, intId, _errOut)
                If Len(AmmoUsed) = 0 Then
                    AmmoUsed = $"{ListView1.Items(i).SubItems(1).Text} ( {intQty} )"
                Else
                    AmmoUsed &= $", {ListView1.Items(i).SubItems(1).Text} ( {intQty} )"
                End If
                If Not BurnSoft.Applications.MGC.Ammo.Inventory.UpdateQty(DatabasePath, intId, intCurQty, intQty, _errOut) Then Throw New Exception(_errOut)
            Next
        Catch ex As Exception
            Call LogError(Name, "UpdateInventory", Err.Number, ex.Message.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Converts to tal.
    ''' </summary>
    ''' <returns>System.Int32.</returns>
    Function EndingTotal() As Integer
        Dim iAns As Integer = 0
        Try
            Dim i As Integer
            Dim intItemCount As Integer = ListView1.Items.Count

            For i = 0 To intItemCount - 1
                iAns += CInt(ListView1.Items(i).SubItems(2).Text)
            Next
        Catch ex As Exception
            Call LogError(Name, "EndingTotal", Err.Number, ex.Message.ToString)
        End Try
        Return iAns
    End Function
    ''' <summary>
    ''' Handles the Load event of the frmAmmoCalc control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAmmoCalc_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            If Len(AmmoTypePet) = 0 And Len(AmmoTypeCal3) = 0 Then
                Gun_Collection_AmmoTableAdapter.FillBy(MGCDataSet.Gun_Collection_Ammo, AmmoType)
            ElseIf Len(AmmoTypePet) > 0 And Len(AmmoTypeCal3) = 0 Then
                Gun_Collection_AmmoTableAdapter.FillByCal_wPet(MGCDataSet.Gun_Collection_Ammo, AmmoType, AmmoTypePet)
            ElseIf Len(AmmoTypePet) > 0 And Len(AmmoTypeCal3) > 0 Then
                Gun_Collection_AmmoTableAdapter.FillByCal_wPet3(MGCDataSet.Gun_Collection_Ammo, AmmoType, AmmoTypePet, AmmoTypeCal3)
            End If

            txtCurQty.Text = BurnSoft.Applications.MGC.Ammo.Inventory.GetQty(DatabasePath, ComboBox1.SelectedValue, _errOut).ToString()
        Catch ex As Exception
            Call LogError(Name,  "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the Button2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim intCurInv As Integer = CInt(txtCurQty.Text)
            If intCurInv <> 0 Then
                Dim strName As String = ComboBox1.Text
                Dim strId As String = CStr(ComboBox1.SelectedValue)
                Dim intQty As Integer = NumericUpDown1.Value
                
                If intQty <= intCurInv Then
                    Dim xitem As ListViewItem = ListView1.Items.Add(strId)
                    xitem.SubItems.Add(strName)
                    xitem.SubItems.Add(intQty)
                    lblTotal.Text = CStr(EndingTotal())
                ElseIf intQty >= intCurInv Then
                    MsgBox("Your saying that you shot more then what is in stock." & Chr(13) & "Please update inventory and try again or " & Chr(13) & "select another ammunition type.")
                End If
            Else
                MsgBox("This ammunition is out of stock!" & Chr(13) & "Please update inventory and try again or " & Chr(13) & "select another ammunition type.")
            End If
            NumericUpDown1.Value = 0
        Catch ex As Exception
            Call LogError(Name, "Button2_Click", Err.Number, ex.Message.ToString)
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
    ''' Handles the SelectedIndexChanged event of the ComboBox1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        txtCurQty.Text = BurnSoft.Applications.MGC.Ammo.Inventory.GetQty(DatabasePath, ComboBox1.SelectedValue, _errOut).ToString()
    End Sub
End Class