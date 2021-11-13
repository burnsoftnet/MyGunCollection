Imports BSMyGunCollection.MGC
Imports BurnSoft.Applications.MGC.Types


''' <summary>
''' Class frmEditGunSmithLog.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmEditGunSmithLog
    ''' <summary>
    ''' The identifier
    ''' </summary>
    Public Id As Long
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String = ""
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim errOut as String = ""

    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    ''' <exception cref="System.Exception"></exception>
    Sub LoadData()
        Try
            Dim lst As List(Of GunSmithWorkDone) = BurnSoft.Applications.MGC.Firearms.GunSmithDetails.Lists(DatabasePath, id, _errOut)
            If _errOut.Length > 0 Then Throw New Exception(_errOut)
            For Each o As GunSmithWorkDone In lst
                txtGS.Text = o.GunSmithName
                DateTimePicker1.Value = CDate(o.StartDate)
                DateTimePicker2.Value = CDate(o.ReturnDate)
                txtOD.Text = o.Notes
            Next
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmEditGunSmithLog control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditGunSmithLog_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            txtGS.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.GunSmith.Name(DatabasePath, _errOut)
            Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnUpdate control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Try
            Dim strSmith As String = FluffContent(txtGS.Text)
            Dim strShip As String = DateTimePicker1.Value
            Dim strReturn As String = DateTimePicker2.Value
            Dim strOd As String = FluffContent(txtOD.Text)
            Dim strNotes As String = FluffContent(txtNotes.Text)

            If Not IsRequired(strSmith, "Gun Smith Name", Text) Then Exit Sub
            If Not IsRequired(strOd, "Operation Details", Text) Then Exit Sub

            Dim gsId as Long = BurnSoft.Applications.MGC.PeopleAndPlaces.GunSmiths.GetId(DatabasePath, strSmith, _errOut)
            if Not BurnSoft.Applications.MGC.Firearms.GunSmithDetails.Update(DatabasePath, Id, strSmith, gsId, strOd, strNotes, strShip, strReturn, _errOut ) Then Throw New Exception(_errOut)
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnUpdate_Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
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
End Class