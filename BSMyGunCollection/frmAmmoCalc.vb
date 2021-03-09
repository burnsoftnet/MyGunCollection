Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
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
    ''' Handles the Click event of the Button1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFinish.Click
        If chkbxUI.Checked Then Call UpdateInventory()
        frmAddMaintance.NumericUpDown1.Value = CInt(lblTotal.Text)
        frmAddMaintance.txtAmmoUsed.Text = AmmoUsed
        Me.Close()
    End Sub
    ''' <summary>
    ''' Currents the qty.
    ''' </summary>
    ''' <param name="intID">The int identifier.</param>
    ''' <returns>System.Int32.</returns>
    Function CurrentQty(ByVal intID As Integer) As Integer
        Dim iAns As Integer = 0
        Try
            Dim SQL As String = "SELECT Qty from Gun_Collection_Ammo where id=" & intID
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            While (RS.Read())
                iAns = CInt(RS("Qty"))
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "CurrentQty"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return iAns
    End Function
    ''' <summary>
    ''' Updates the inventory.
    ''' </summary>
    Sub UpdateInventory()
        Try
            Dim iAns As Integer = 0
            Dim i As Integer = 0
            Dim intItemCount As Integer = ListView1.Items.Count
            Dim intID As Integer = 0
            Dim intQty As Integer = 0
            Dim intCurQty As Integer = 0
            Dim IntNewQty As Integer = 0
            AmmoUsed = ""
            For i = 0 To intItemCount - 1
                intQty = CInt(ListView1.Items(i).SubItems(2).Text)
                intID = CInt(ListView1.Items(i).SubItems(0).Text)
                intCurQty = CurrentQty(intID)
                IntNewQty = intCurQty - intQty
                If Len(AmmoUsed) = 0 Then
                    AmmoUsed = ListView1.Items(i).SubItems(1).Text
                Else
                    AmmoUsed &= ", " & ListView1.Items(i).SubItems(1).Text
                End If
                Call UpdateQty(intID, IntNewQty)
            Next
        Catch ex As Exception
            Dim sSubFunc As String = "UpdateInventory"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Updates the qty.
    ''' </summary>
    ''' <param name="intID">The int identifier.</param>
    ''' <param name="intQty">The int qty.</param>
    Sub UpdateQty(ByVal intID As Integer, ByVal intQty As Integer)
        Try
            Dim SQL As String = "UPDATE Gun_Collection_Ammo set Qty=" & intQty & ",sync_lastupdate=Now() where id=" & intID
            Dim Obj As New BSDatabase
            Obj.ConnExec(SQL)
        Catch ex As Exception
            Dim sSubFunc As String = "UpdateQty"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Converts to tal.
    ''' </summary>
    ''' <returns>System.Int32.</returns>
    Function EndingTotal() As Integer
        Dim iAns As Integer = 0
        Try
            Dim i As Integer = 0
            Dim intItemCount As Integer = ListView1.Items.Count
            Dim intID As Integer = 0
            Dim intQty As Integer = 0
            For i = 0 To intItemCount - 1
                iAns += CInt(ListView1.Items(i).SubItems(2).Text)
            Next
        Catch ex As Exception
            Dim sSubFunc As String = "EndingTotal"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
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
                Me.Gun_Collection_AmmoTableAdapter.FillBy(Me.MGCDataSet.Gun_Collection_Ammo, AmmoType)
            ElseIf Len(AmmoTypePet) > 0 And Len(AmmoTypeCal3) = 0 Then
                Me.Gun_Collection_AmmoTableAdapter.FillByCal_wPet(Me.MGCDataSet.Gun_Collection_Ammo, AmmoType, AmmoTypePet)
            ElseIf Len(AmmoTypePet) > 0 And Len(AmmoTypeCal3) > 0 Then
                Me.Gun_Collection_AmmoTableAdapter.FillByCal_wPet3(Me.MGCDataSet.Gun_Collection_Ammo, AmmoType, AmmoTypePet, AmmoTypeCal3)
            End If
            txtCurQty.Text = CStr(CurrentQty(ComboBox1.SelectedValue))
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
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
                Dim strID As String = CStr(ComboBox1.SelectedValue)
                Dim intQTY As Integer = NumericUpDown1.Value
                Dim intItemCount As Integer = ListView1.Items.Count
                Dim i As Integer = 0
                If intQTY <= intCurInv Then
                    If intItemCount > 0 Then i = intItemCount + 1
                    Dim xitem As ListViewItem = ListView1.Items.Add(strID)
                    xitem.SubItems.Add(strName)
                    xitem.SubItems.Add(intQTY)
                    lblTotal.Text = CStr(EndingTotal())
                ElseIf intQTY >= intCurInv Then
                    MsgBox("Your saying that you shot more then what is in stock." & Chr(13) & "Please update inventory and try again or " & Chr(13) & "select another ammunition type.")
                End If
            Else
                MsgBox("This ammunition is out of stock!" & Chr(13) & "Please update inventory and try again or " & Chr(13) & "select another ammunition type.")
            End If
            NumericUpDown1.Value = 0
        Catch ex As Exception
            Dim sSubFunc As String = "Button2_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Handles the SelectedIndexChanged event of the ComboBox1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        txtCurQty.Text = CStr(CurrentQty(ComboBox1.SelectedValue))
    End Sub
End Class