Imports BSMyGunCollection.MGC
''' <summary>
''' Class frmAddModel.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddModel
    ''' <summary>
    ''' Handles the Load event of the frmAddModel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddModel_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim ObjAF As New AutoFillCollections
            txtManufacturer.AutoCompleteCustomSource = ObjAF.Gun_Manufacturer
            txtModel.AutoCompleteCustomSource = ObjAF.Gun_Model
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
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
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim ObjGF As New GlobalFunctions
            Dim Obj As New BSDatabase
            Dim strTableName As String = "Gun_Model"
            Dim strFieldName As String = "Model"
            Dim strMan As String = Trim(Replace(txtManufacturer.Text, "'", "''"))
            Dim strModel As String = Trim(Replace(txtModel.Text, "'", "''"))
            If Len(strMan) = 0 Then MsgBox("Please Fill in the Manufacturer!", MsgBoxStyle.Critical, Me.Text) : Exit Sub
            If Len(strModel) = 0 Then MsgBox("Please Fill in the Model!", MsgBoxStyle.Critical, Me.Text) : Exit Sub
            If Not ObjGF.ObjectExistsinDB(strMan, strFieldName, strTableName) Then
                Dim ManID As Long = ObjGF.GetManufacturersID(strMan)
                Dim SQL As String = "INSERT INTO Gun_Model(GMID,Model,sync_lastupdate) VALUES(" & ManID & ",'" & strModel & "',Now())"
                Obj.ConnExec(SQL)
                lblMsg.Text = strMan & " " & strModel & " was added!"
            Else
                lblMsg.Text = strMan & " " & strModel & " already exists!"
            End If
            txtModel.Text = ""
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Converts to p_checkedchanged.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub chkKTop_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkKTop.CheckedChanged
        Me.TopMost = chkKTop.Checked
    End Sub
End Class