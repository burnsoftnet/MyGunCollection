Imports BurnSoft.Applications.MGC.Firearms

Public Class frmLinkDocToFirearm
    ''' <summary>
    ''' The document identifier
    ''' </summary>
    Public DocId As Long
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut As String
    ''' <summary>
    ''' Handles the Load event of the frmLinkDocToFirearm control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmLinkDocToFirearm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Gun_CollectionTableAdapter.Fill(MGCDataSet.Gun_Collection)
    End Sub

    ''' <summary>
    ''' Handles the Click event of the btnAttach control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
        Try
            Dim strFireArmId As String = ComboBox1.SelectedValue.ToString
            Dim strFireArmName As String = ComboBox1.Text

            If Documents.PerformDocLink(DatabasePath, Convert.ToInt32(strFireArmId),DocId, _errOut) Then
                Dim strMsg As String = "Document was copied to " & strFireArmName
                Dim sAns As String = MsgBox(strMsg & Chr(10) & "Do you want to link it to another firearm?", MsgBoxStyle.YesNo, Text)
                If sAns = vbNo Then Close()
                Else 
                    MsgBox("Was unable to link document, see error log for more details", MsgBoxStyle.Critical, Text)
                    Throw New Exception(_errOut)
            End If
            
        Catch ex As Exception
            Call LogError(Name, "btnAttach.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class