Imports BurnSoft.Applications.MGC.Firearms

''' <summary>
''' Class FrmEditModelTypes.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmEditModelTypes
    ''' <summary>
    ''' The manufacturers identifier
    ''' </summary>
    Public ManufacturersId As Long
    ''' <summary>
    ''' The manufacturers name
    ''' </summary>
    Public ManufacturersName As String
    ''' <summary>
    ''' The model identifier
    ''' </summary>
    Public ModelId As Long
    ''' <summary>
    ''' The model name
    ''' </summary>
    Public ModelName As String
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmEditModelTypes control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditModelTypes_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try 
            txtManufacturer.Text = ManufacturersName
            txtModel.Text = ModelName
            Dim errOut as String = ""
            ManufacturersId = Manufacturers.GetId(DatabasePath, ManufacturersName,errOut)
            If errOut.Length > 0 Then Throw New Exception(errOut)
            If ManufacturersId = 0 Then Manufacturers.Add(DatabasePath, ManufacturersName, errOut)
            If errOut.Length > 0 Then Throw New Exception(errOut)
        Catch ex As Exception
            Call LogError(Name, "frmEditModelTypes_Load", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim errOut as String = ""
            If Not Models.Update(DatabasePath, ModelId, txtModel.Text, errOut) Then Throw New Exception(errOut)
            If Not Manufacturers.Update(DatabasePath, ManufacturersId, txtManufacturer.Text, errOut) Then Throw New Exception(errOut)
        Catch ex As Exception
            Call LogError(Name, "btnAdd.Click", Err.Number, ex.Message.ToString)
        End Try
        frmEditModel.LoadData()
        Close()
    End Sub
End Class