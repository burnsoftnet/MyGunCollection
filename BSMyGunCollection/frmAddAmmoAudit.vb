Imports BurnSoft.Applications.MGC.Ammo


''' <summary>
''' Class frmAddAmmoAudit.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddAmmoAudit
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
            Dim iQty As Integer = nudQty.Value
            Dim dPrice As Double = FluffContent(txtPrice.Text, 0.0)
            Dim sDate As String = dtpPurchased.Value
            Dim store As String = FluffContent(txtStore.Text, "")
            Dim errOut as String = ""

            Dim iNumBox As Integer = nudNumBox.Value

            If Len(iQty) > 0 Then
                If Not Audit.Add(DatabasePath, Aid,sDate,iQty, dPrice,store,iNumBox,CLng(CurrentCount), errOut) Then Throw New Exception(errOut)
                MsgBox("The Information was added!", MsgBoxStyle.Information, Text)
            End If
            Call frmViewAmmoInventory.LoadData()
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd_Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class