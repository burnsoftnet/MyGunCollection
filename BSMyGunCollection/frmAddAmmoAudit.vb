Imports BSMyGunCollection.MGC
''' <summary>
''' Class frmAddAmmoAudit.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
' ReSharper disable InconsistentNaming
Public Class frmAddAmmoAudit
' ReSharper restore InconsistentNaming
    ''' <summary>
    ''' The aid
    ''' </summary>
    Public Aid As Long
    ''' <summary>
    ''' The current count
    ''' </summary>
    Public CurrentCount As String
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
            Dim iQty As Integer = nudQty.Value
            Dim dPrice As Double = FluffContent(txtPrice.Text, 0.0)
            Dim sDate As String = dtpPurchased.Value
            Dim store As String = FluffContent(txtStore.Text, "")
            Dim sql As String = ""
            Dim obj As New BSDatabase
            Dim i As Integer = 0
            Dim lTotal As Long = 0
            Dim iNumBox As Integer = nudNumBox.Value
            Dim PPB As Double = FormatNumber(dPrice / iQty, 2)
            If Len(iQty) > 0 Then
                If iNumBox = 1 Then
                    lTotal = CLng(CurrentCount) + CLng(iQty)
                    sql = "UPDATE Gun_Collection_Ammo set Qty=" & lTotal & " where id=" & Aid
                    obj.ConnExec(sql)
                    sql = "INSERT INTO Gun_Collection_Ammo_PriceAudit (AID,DTA,Qty,PricePaid,PPB,store,sync_lastupdate) " &
                                    "VALUES(" & Aid & ",'" & sDate & "'," & iQty & "," & dPrice & "," & PPB &
                                    ",'" & store & "',Now())"
                    obj.ConnExec(sql)
                ElseIf iNumBox > 1 Then
                    lTotal = CLng(CurrentCount) + CLng((iQty * iNumBox))
                    sql = "UPDATE Gun_Collection_Ammo set Qty=" & lTotal & " where id=" & Aid
                    obj.ConnExec(sql)
                    For i = 1 To iNumBox
                        sql = "INSERT INTO Gun_Collection_Ammo_PriceAudit (AID,DTA,Qty,PricePaid,PPB,store,sync_lastupdate) " &
                                    "VALUES(" & Aid & ",'" & sDate & "'," & iQty & "," & dPrice & "," & PPB &
                                    ",'" & store & "',Now())"
                        obj.ConnExec(sql)
                    Next i
                End If
                MsgBox("The Information was added!", MsgBoxStyle.Information, Me.Text)
            End If
            Call frmViewAmmoInventory.LoadData()
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd_Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class