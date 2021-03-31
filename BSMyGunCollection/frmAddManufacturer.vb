Imports BSMyGunCollection.MGC

''TODO: Replace code from FrmAddManufacturer #4
''TODO: #43 Clean up unsued code.
''' <summary>
''' Class frmAddManufacturer.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmAddManufacturer
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
            If Not IsRequired(strMan, "Manufacturer's Name", Text) Then Exit Sub
            Dim errOut as String = ""
            If Not BurnSoft.Applications.MGC.Firearms.Manufacturers.Exists(DatabasePath, strMan, errOut) Then
                If Not BurnSoft.Applications.MGC.Firearms.Manufacturers.Add(DatabasePath, strMan, errOut) Then 
                    Throw New Exception(errOut)
                End If
                MsgBox(strMan & " was added to the database!", MsgBoxStyle.Information, Text)
                txtMan.Text = ""
            Else 
                MsgBox(strMan & " already existed in the database!", MsgBoxStyle.Critical, Text)
                txtMan.Text = ""
            End If

            'Dim objGf As New GlobalFunctions
            'If Not objGf.ObjectExistsinDB(strMan, "Brand", "Gun_Manufacturer") Then
            '    Dim obj As New BSDatabase
            '    Dim sql As String = "INSERT INTO Gun_Manufacturer(Brand,sync_lastupdate) VALUES('" & strMan & "',Now())"
            '    obj.ConnExec(sql)
            '    MsgBox(strMan & " was added to the database!", MsgBoxStyle.Information, Text)
            '    txtMan.Text = ""
            '    'Close()
            'Else
            '    MsgBox(strMan & " already existed in the database!", MsgBoxStyle.Critical, Text)
            '    txtMan.Text = ""
            'End If
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
            'Dim objAf As New AutoFillCollections
            'txtMan.AutoCompleteCustomSource = objAf.Gun_Manufacturer()
            Dim errOut as String = ""
            txtMan.AutoCompleteCustomSource = BurnSoft.Applications.MGC.AutoFill.Gun.Manufacturer(DatabasePath, errOut)
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