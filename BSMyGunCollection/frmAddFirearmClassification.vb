Imports BSMyGunCollection.MGC
''' <summary>
''' Class frmAddFirearmClassification.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddFirearmClassification
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim strClass As String = FluffContent(txtClass.Text)
            If Not IsRequired(strClass, "Classification Type", Me.Text) Then Exit Sub
            Dim ObjGF As New GlobalFunctions
            If Not ObjGF.ObjectExistsinDB(strClass, "myclass", "Gun_Collection_Classification") Then
                Dim Obj As New BSDatabase
                Dim SQL As String = "INSERT INTO Gun_Collection_Classification(myclass,sync_lastupdate) VALUES('" & strClass & "',Now())"
                Obj.ConnExec(SQL)
                MsgBox(strClass & " was added to the database!", MsgBoxStyle.Information, Me.Text)
                txtClass.Text = ""
                'Me.Close()
                If Not chkKeepOpen.Checked Then
                    Me.Close()
                End If
            Else
                MsgBox(strClass & " already existed in the database!", MsgBoxStyle.Critical, Me.Text)
                txtClass.Text = ""
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class