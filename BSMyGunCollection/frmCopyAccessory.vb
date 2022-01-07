Imports BurnSoft.Applications.MGC.Firearms
''' <summary>
''' Class frmCopyAccessory.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmCopyAccessory
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemId As String ' Accessory ID    
    ''' <summary>
    ''' The full name
    ''' </summary>
    Private _fullName As String ' Full Name    
    ''' <summary>
    ''' Error Out string for all new function
    ''' </summary>
    Private _errOut As String

    ''' <summary>
    ''' When Load Forms, populate the drop down box
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmCopyAccessory_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            QryGunCollectionDetailsTableAdapter.FillBy_Default(MGCDataSet.qryGunCollectionDetails)
            _fullName = Accessories.GetFullName(DatabasePath, Convert.ToInt32(ItemId), _errOut)
            Label1.Text &= _fullName
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' When the Copy button is selected
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCopy.Click
        Try
            Dim strFireArmId As String = ComboBox1.SelectedValue.ToString
            Dim strFireArmName As String = ComboBox1.Text
            If Not Accessories.Copy(DatabasePath, Convert.ToInt32(ItemId), Convert.ToInt32(strFireArmId), _errOut) Then Throw New Exception(_errOut)
            Dim strMsg As String = _fullName & " was copied to " & strFireArmName
            Dim sAns As String = MsgBox(strMsg & Chr(10) & "Do you want to copy it to another item?", MsgBoxStyle.YesNo, Text)
            If sAns = vbNo Then Close()
        Catch ex As Exception
            Call LogError(Name, "btnCopy.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class