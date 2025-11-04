Imports BurnSoft.Applications.MGC

Public Class FrmLinkAccessoryToFirearm
    ''' <summary>
    ''' The document identifier
    ''' </summary>
    Public AccessoryId As Long
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut As String
    ''' <summary>
    ''' Handles the Load event of the FrmLinkAccessoryToFirearm control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub FrmLinkAccessoryToFirearm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Gun_CollectionTableAdapter.Fill(MGCDataSet.Gun_Collection)
        Catch ex As Exception
            Call LogError(Name, "FrmLinkAccessoryToFirearm_Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAttach control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
        Try
            Dim strFireArmId As String = ComboBox1.SelectedValue.ToString
            Dim strFireArmName As String = ComboBox1.Text
            If Other.GeneralAccessoriesLinking.AttachToFirearm(DatabasePath, AccessoryId, CLng(strFireArmId), _errOut) Then
                Dim strMsg As String = "Accessory was copied to " & strFireArmName
                Dim sAns As String = MsgBox(strMsg & Chr(10) & "Do you want to link it to another firearm?", MsgBoxStyle.YesNo, Text)
                If sAns = vbNo Then Close()
            Else 
                MsgBox("Was unable to link Accessory, see error log for more details", MsgBoxStyle.Critical, Text)
                Throw New Exception(_errOut)
            End If
        Catch ex As Exception
            Call LogError(Name, "btnAttach.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class