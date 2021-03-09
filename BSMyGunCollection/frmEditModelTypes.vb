Imports BSMyGunCollection.MGC
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
        txtManufacturer.Text = ManufacturersName
        txtModel.Text = ModelName
        Dim obj As New GlobalFunctions
        ManufacturersId = obj.GetManufacturersID(ManufacturersName)
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim manu As String = txtManufacturer.Text
            Dim model As String = txtModel.Text
            Dim objDb As New BSDatabase
            Dim sql As String = "UPDATE Gun_Model set [Model]='" & model & "',sync_lastupdate=Now() where ID=" & ModelId
            objDb.ConnExec(sql)
            sql = "UPDATE Gun_Manufacturer set Brand='" & manu & "',sync_lastupdate=Now() where ID=" & ManufacturersId
            objDb.ConnExec(sql)
            frmEditModel.LoadData()
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class