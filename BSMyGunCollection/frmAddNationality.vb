Imports BSMyGunCollection.MGC
''' <summary>
''' Class frmAddNationality.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmAddNationality
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim strName As String = FluffContent(txtName.Text)
            If Not IsRequired(strName, "Region", Me.Text) Then Exit Sub
            Dim ObjGF As New GlobalFunctions
            If Not ObjGF.ObjectExistsinDB(strName, "Country", "Gun_Nationality") Then
                Dim Obj As New BSDatabase
                Dim SQL As String = "INSERT INTO Gun_Nationality(Country,sync_lastupdate) VALUES('" & strName & "',Now())"
                Obj.ConnExec(SQL)
                lblMsg.Text = strName & " was added to the database!"
            Else
                lblMsg.Text = strName & " already exists in the database!"
            End If
            txtName.Text = ""
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmAddNationality control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmAddNationality_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            Dim ObjAF As New AutoFillCollections
            txtName.AutoCompleteCustomSource = ObjAF.Gun_Nationality
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class