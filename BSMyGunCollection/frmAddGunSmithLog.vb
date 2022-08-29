
Imports BurnSoft.Applications.MGC.Global

''' <summary>
''' Class frmAddGunSmithLog.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddGunSmithLog
    ''' <summary>
    ''' The gun id
    ''' </summary>
    Public Gid As String
    ''' <summary>
    ''' The error out
    ''' </summary>
    Private _errOut As String
    ''' <summary>
    ''' Handles the Load event of the frmAddGunSmithLog control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddGunSmithLog_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            txtGS.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.GunSmith.Name(DatabasePath, _errOut)
        Catch ex As Exception
            Call LogError(Name, "Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim strSmith As String = FluffContent(txtGS.Text)
            Dim strShip As String = DateTimePicker1.Value
            Dim strReturn As String = DateTimePicker2.Value
            Dim strOd As String = FluffContent(txtOD.Text)
            Dim strNotes As String = FluffContent(txtNotes.Text)
            Dim errOut As String =""

            If Not Helpers.IsRequired(strSmith, "Gun Smith Name", Text, errOut) Then Exit Sub
            If Not Helpers.IsRequired(strOd, "Operation Details", Text, errOut) Then Exit Sub

            If Not BurnSoft.Applications.MGC.PeopleAndPlaces.GunSmiths.Exists(DatabasePath, strSmith, errOut) Then 
                BurnSoft.Applications.MGC.PeopleAndPlaces.GunSmiths.Add(DatabasePath, strSmith, errOut)
            End If

            Dim gsid As Long = BurnSoft.Applications.MGC.PeopleAndPlaces.GunSmiths.GetId(DatabasePath, strSmith, errOut)

            If Not BurnSoft.Applications.MGC.Firearms.GunSmithDetails.Add(DatabasePath, Gid, strSmith, gsid, strOd, strNotes, strShip, strReturn, errOut) Then
                Throw New Exception(errOut)
            End If

            MsgBox("Details where added to the Gun Smith Log", MsgBoxStyle.Information, Text)
            Close()
        Catch ex As Exception
            Call LogError(Name, "btnAdd.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class