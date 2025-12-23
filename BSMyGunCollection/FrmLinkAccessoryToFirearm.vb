Imports BurnSoft.Applications.MGC.Other

Public Class FrmLinkAccessoryToFirearm
    ''' <summary>
    ''' The document identifier
    ''' </summary>
    Public AccessoryId As Long
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut As String

    Public MoveMode as Boolean
    ''' <summary>
    ''' Handles the Load event of the FrmLinkAccessoryToFirearm control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub FrmLinkAccessoryToFirearm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If MoveMode Then
                Label1.Text = "Select the firearm listed below to move this Accessory to:"
                Me.Text = "Move Accessory to Firearm"
            End If
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
            If MoveMode Then
                If GeneralAccessories.Move(DatabasePath, AccessoryId, CLng(strFireArmId), _errOut) Then
                    Dim strMsg As String = "Accessory was moved to " & strFireArmName
                    MsgBox(strMsg, MsgBoxStyle.Information, Text)
                    Me.Close()
                Else 
                    MsgBox("Was unable to Move Accessory, see error log for more details", MsgBoxStyle.Critical, Text)
                    Throw New Exception(_errOut)
                End If
            Else 
                If GeneralAccessoriesLinking.AttachToFirearm(DatabasePath, AccessoryId, CLng(strFireArmId), _errOut) Then
                    Dim strMsg As String = "Accessory was copied to " & strFireArmName
                    Dim sAns As String = MsgBox(strMsg & Chr(10) & "Do you want to link it to another firearm?", MsgBoxStyle.YesNo, Text)
                    If sAns = vbNo Then Close()
                Else 
                    MsgBox("Was unable to link Accessory, see error log for more details", MsgBoxStyle.Critical, Text)
                    Throw New Exception(_errOut)
                End If
            End If
            
        Catch ex As Exception
            Call LogError(Name, "btnAttach.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class