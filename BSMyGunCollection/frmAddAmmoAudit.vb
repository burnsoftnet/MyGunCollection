Imports BSMyGunCollection.MGC
''' <summary>
''' Class frmAddAmmoAudit.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddAmmoAudit
    ''' <summary>
    ''' The aid
    ''' </summary>
    Public AID As Long
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
            Dim Store As String = FluffContent(txtStore.Text, "")
            Dim SQL As String = ""
            Dim Obj As New BSDatabase
            Dim i As Integer = 0
            Dim lTotal As Long = 0
            Dim iNumBox As Integer = nudNumBox.Value
            Dim PPB As Double = FormatNumber(dPrice / iQty, 2)
            If Len(iQty) > 0 Then
                If iNumBox = 1 Then
                    lTotal = CLng(CurrentCount) + CLng(iQty)
                    SQL = "UPDATE Gun_Collection_Ammo set Qty=" & lTotal & " where id=" & AID
                    Obj.ConnExec(SQL)
                    SQL = "INSERT INTO Gun_Collection_Ammo_PriceAudit (AID,DTA,Qty,PricePaid,PPB,store,sync_lastupdate) " &
                                    "VALUES(" & AID & ",'" & sDate & "'," & iQty & "," & dPrice & "," & PPB &
                                    ",'" & Store & "',Now())"
                    Obj.ConnExec(SQL)
                ElseIf iNumBox > 1 Then
                    lTotal = CLng(CurrentCount) + CLng((iQty * iNumBox))
                    SQL = "UPDATE Gun_Collection_Ammo set Qty=" & lTotal & " where id=" & AID
                    Obj.ConnExec(SQL)
                    For i = 1 To iNumBox
                        SQL = "INSERT INTO Gun_Collection_Ammo_PriceAudit (AID,DTA,Qty,PricePaid,PPB,store,sync_lastupdate) " &
                                    "VALUES(" & AID & ",'" & sDate & "'," & iQty & "," & dPrice & "," & PPB &
                                    ",'" & Store & "',Now())"
                        Obj.ConnExec(SQL)
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