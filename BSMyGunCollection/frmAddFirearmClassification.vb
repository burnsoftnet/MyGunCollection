Imports BSMyGunCollection.MGC

''' <summary>
''' Class frmAddFirearmClassification.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddFirearmClassification
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim strClass As String = FluffContent(txtClass.Text)
            If Not IsRequired(strClass, "Classification Type", Text) Then Exit Sub
            'Dim objGf As New GlobalFunctions
            'If Not objGf.ObjectExistsinDB(strClass, "myclass", "Gun_Collection_Classification") Then
            '    Dim obj As New BSDatabase
            '    Dim sql As String = "INSERT INTO Gun_Collection_Classification(myclass,sync_lastupdate) VALUES('" & strClass & "',Now())"
            '    obj.ConnExec(sql)
            '    MsgBox(strClass & " was added to the database!", MsgBoxStyle.Information, Text)
            '    txtClass.Text = ""
            '    If Not chkKeepOpen.Checked Then
            '        Close()
            '    End If
            'Else
            '    MsgBox(strClass & " already existed in the database!", MsgBoxStyle.Critical, Text)
            '    txtClass.Text = ""
            'End If
            '' TODO: #43 Clean up old code
            Dim errOut as String
            If Not BurnSoft.Applications.MGC.Firearms.Classification.Exists(DatabasePath, strClass, errOut) Then
                If Not BurnSoft.Applications.MGC.Firearms.Classification.Add(DatabasePath, strClass, errOut) Then Throw New Exception(errOut)
                Else 
                    MsgBox(strClass & " already existed in the database!", MsgBoxStyle.Critical, Text)
                    txtClass.Text = ""
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class