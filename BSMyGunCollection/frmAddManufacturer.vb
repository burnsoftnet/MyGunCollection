Imports BurnSoft.Applications.MGC.Firearms
Imports BurnSoft.Applications.MGC.Global

''' <summary>
''' Class frmAddManufacturer.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddManufacturer
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut as String = ""
    ''' <summary>
    ''' Handles the Click event of the Button2 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim strMan As String = FluffContent(txtMan.Text)
            If Not Helpers.IsRequired(strMan, "Manufacturer's Name", Text, _errOut) Then Exit Sub

            If Not Manufacturers.Exists(DatabasePath, strMan, _errOut) Then
                If Not Manufacturers.Add(DatabasePath, strMan, _errOut) Then Throw New Exception(_errOut)
                MsgBox(strMan & " was added to the database!", MsgBoxStyle.Information, Text)
            Else 
                MsgBox(strMan & " already existed in the database!", MsgBoxStyle.Critical, Text)
            End If
            txtMan.Text = ""
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmAddManufacturer control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddManufacturer_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            txtMan.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Gun.Manufacturer(DatabasePath, _errOut)
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Converts to check changed box.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub chkKTop_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkKTop.CheckedChanged
        TopMost = chkKTop.Checked
        MdiParent = Nothing
    End Sub
End Class