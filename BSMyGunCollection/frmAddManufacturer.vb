Imports BSMyGunCollection.MGC
''' <summary>
''' Class frmAddManufacturer.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddManufacturer
    ''' <summary>
    ''' Handles the Click event of the Button2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim strMan As String = FluffContent(txtMan.Text)
            If Not IsRequired(strMan, "Manufacturer's Name", Me.Text) Then Exit Sub
            Dim ObjGF As New GlobalFunctions
            If Not ObjGF.ObjectExistsinDB(strMan, "Brand", "Gun_Manufacturer") Then
                Dim Obj As New BSDatabase
                Dim SQL As String = "INSERT INTO Gun_Manufacturer(Brand,sync_lastupdate) VALUES('" & strMan & "',Now())"
                Obj.ConnExec(SQL)
                MsgBox(strMan & " was added to the database!", MsgBoxStyle.Information, Me.Text)
                txtMan.Text = ""
                'Me.Close()
            Else
                MsgBox(strMan & " already existed in the database!", MsgBoxStyle.Critical, Me.Text)
                txtMan.Text = ""
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmAddManufacturer control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddManufacturer_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim ObjAF As New AutoFillCollections
            txtMan.AutoCompleteCustomSource = ObjAF.Gun_Manufacturer()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Converts to check changed box.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub chkKTop_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkKTop.CheckedChanged
        Me.TopMost = chkKTop.Checked
        Me.MdiParent = Nothing
    End Sub
End Class