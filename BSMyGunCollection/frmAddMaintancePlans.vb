Imports BSMyGunCollection.MGC
''' <summary>
''' Class Add Maintenance Plans form.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
' ReSharper disable InconsistentNaming
Public Class frmAddMaintancePlans
' ReSharper restore InconsistentNaming
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim strName As String = FluffContent(txtName.Text)
            Dim strOD As String = FluffContent(txtOD.Text)
            Dim strIID As String = nudIID.Value
            Dim strIIRF As String = nudIIRF.Value
            Dim strNotes As String = FluffContent(txtNotes.Text)

            If Not IsRequired(strName, "Name", Me.Text) Then Exit Sub
            If Not IsRequired(strOD, "Operation Description", Me.Text) Then Exit Sub
            Dim Obj As New BSDatabase
            Dim SQL As String = "INSERT INTO Maintance_Plans(Name,OD,iid,iirf,Notes,sync_lastupdate) VALUES('" &
                        strName & "','" & strOD & "','" & strIID & "','" & strIIRF & "','" &
                        strNotes & "',Now())"
            Obj.ConnExec(SQL)
            MsgBox(strName & " was added to the Maintenance Plans!", MsgBoxStyle.Information, Me.Text)
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the brnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub brnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnCancel.Click
        Me.Close()
    End Sub
End Class