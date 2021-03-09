' ***********************************************************************
' Assembly         : BSMyGunCollection
' Author           : burnsoft
' Created          : 02-25-2021
'
' Last Modified By : burnsoft
' Last Modified On : 02-25-2021
' ***********************************************************************
' <copyright file="frmLinkDocToFirearm.vb" company="BurnSoft">
'     Copyright © Burnsoft. 2007 - 2017
' </copyright>
' <summary></summary>
' ***********************************************************************

Imports BSMyGunCollection.MGC
Public Class FrmLinkDocToFirearm
    ''' <summary>
    ''' The document identifier
    ''' </summary>
    Public DocId As Long
    ''' <summary>
    ''' Handles the Load event of the frmLinkDocToFirearm control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmLinkDocToFirearm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Gun_CollectionTableAdapter.Fill(MGCDataSet.Gun_Collection)
    End Sub
    ''' <summary>
    ''' Links the document to firearm.
    ''' </summary>
    ''' <param name="gid">The gid.</param>
    Sub LinkDocToFirearm(gid As String)
        Try
            Dim obj As New BSDatabase
            Dim sql As String = "INSERT INTO Gun_Collection_Docs_Links (GID,DID) VALUES(" & gid & "," & DocId & ")"
            obj.ConnExec(sql)
        Catch ex As Exception
            Dim sSubFunc As String = "LinkDocToFirearm"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
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
            Call LinkDocToFirearm(strFireArmId)
            Dim strMsg As String = "Document was copied to " & strFireArmName
            Dim sAns As String = MsgBox(strMsg & Chr(10) & "Do you want to link it to another firearm?", MsgBoxStyle.YesNo, Text)
            If sAns = vbNo Then Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAttach.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class