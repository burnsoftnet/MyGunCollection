Imports BSMyGunCollection.MGC

''' <summary>
''' Class Add Maintenance Plans form.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddMaintancePlans
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim strName As String = FluffContent(txtName.Text)
            Dim strOd As String = FluffContent(txtOD.Text)
            Dim strIid As String = nudIID.Value
            Dim strIirf As String = nudIIRF.Value
            Dim strNotes As String = FluffContent(txtNotes.Text)

            If Not IsRequired(strName, "Name", Text) Then Exit Sub
            If Not IsRequired(strOd, "Operation Description", Text) Then Exit Sub
            Dim obj As New BSDatabase
            Dim sql As String = "INSERT INTO Maintance_Plans(Name,OD,iid,iirf,Notes,sync_lastupdate) VALUES('" &
                        strName & "','" & strOd & "','" & strIid & "','" & strIirf & "','" &
                        strNotes & "',Now())"
            obj.ConnExec(sql)
            MsgBox(strName & " was added to the Maintenance Plans!", MsgBoxStyle.Information, Text)
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the brnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub brnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles brnCancel.Click
        Close()
    End Sub
End Class