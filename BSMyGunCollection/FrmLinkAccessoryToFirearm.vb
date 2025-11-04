Imports BurnSoft.Applications.MGC.Firearms

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
        Gun_CollectionTableAdapter.Fill(MGCDataSet.Gun_Collection)
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

        Catch ex As Exception
            Call LogError(Name, "btnAttach.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class