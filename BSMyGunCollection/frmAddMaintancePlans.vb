Imports BSMyGunCollection.MGC
Public Class frmAddMaintancePlans

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
            Dim SQL As String = "INSERT INTO Maintance_Plans(Name,OD,iid,iirf,Notes,sync_lastupdate) VALUES('" & _
                        strName & "','" & strOD & "','" & strIID & "','" & strIIRF & "','" & _
                        strNotes & "',Now())"
            Obj.ConnExec(SQL)
            MsgBox(strName & " was added to the Maintance Plans!", MsgBoxStyle.Information, Me.Text)
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub brnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnCancel.Click
        Me.Close()
    End Sub
End Class