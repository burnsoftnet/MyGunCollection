Imports BurnSoft.Applications.MGC.AutoFill
Imports BurnSoft.Applications.MGC.Firearms

''' <summary>
''' Class frmAddModel.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddModel
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String = ""
    ''' <summary>
    ''' Handles the Load event of the frmAddModel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddModel_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            txtManufacturer.AutoCompleteCustomSource = Gun.Manufacturer(DatabasePath, _errOut)
            txtModel.AutoCompleteCustomSource = Gun.Model(DatabasePath, _errOut)
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
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
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim strMan As String = Trim(Replace(txtManufacturer.Text, "'", "''"))
            Dim strModel As String = Trim(Replace(txtModel.Text, "'", "''"))
            If Len(strMan) = 0 Then MsgBox("Please Fill in the Manufacturer!", MsgBoxStyle.Critical, Text) : Exit Sub
            If Len(strModel) = 0 Then MsgBox("Please Fill in the Model!", MsgBoxStyle.Critical, Text) : Exit Sub
            Dim manId As Long = Manufacturers.GetId(DatabasePath, strMan, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)

            If Not Models.Exists(DatabasePath,strModel, Convert.ToInt32(manId), _errOut) Then
                If Not Models.Add(DatabasePath, strModel, manId, _errOut) Then Throw New Exception(_errOut)
                lblMsg.Text = strMan & $" " & strModel & $" was added!"
            Else 
                lblMsg.Text = strMan & $" " & strModel & $" already exists!"
            End If

            txtModel.Text = ""
        Catch ex As Exception
            Call LogError(Name, "btnAdd.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Converts to p_checkedchanged.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub chkKTop_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkKTop.CheckedChanged
        TopMost = chkKTop.Checked
    End Sub
End Class