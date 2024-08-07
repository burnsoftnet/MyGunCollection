Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
''' <summary>
''' Class frmEditAccessory.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmEditAccessory
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemId As String
    ''' <summary>
    ''' The is shot gun
    ''' </summary>
    Public IsShotGun As Boolean
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim sql As String = "SELECT * from Gun_Collection_Accessories where ID=" & ItemId
            Dim obj As New BSDatabase
            Call obj.ConnectDB()
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            Dim iCiv As Integer
            Dim iIc As Integer
            While rs.Read
                txtMan.Text = Trim(rs("Manufacturer"))
                txtModel.Text = Trim(rs("Model"))
                txtSerial.Text = Trim(rs("SerialNumber"))
                cmdCondition.Text = Trim(rs("Condition"))
                txtUse.Text = Trim(rs("Use"))
                txtPurVal.Text = Trim(rs("PurValue"))
                txtNotes.Text = Trim(rs("Notes"))
                txtAppValue.Text = rs("AppValue")
                iCiv = rs("CIV")
                If iCiv = 1 Then
                    chkCIV.Checked = True
                Else
                    chkCIV.Checked = False
                End If
                If IsShotGun Then
                    iIc = rs("IC")
                    If iIc = 1 Then
                        chkIsChoke.Checked = True
                    Else
                        chkIsChoke.Checked = False
                    End If
                End If
            End While
            rs.Close()
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmEditAccessory control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditAccessory_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Label10.Visible = IsShotGun
            chkIsChoke.Visible = IsShotGun
            Dim objAf As New AutoFillCollections
            txtMan.AutoCompleteCustomSource = objAf.Accessory_Manufacturer
            txtModel.AutoCompleteCustomSource = objAf.Accessory_Model
            txtUse.AutoCompleteCustomSource = objAf.Accessory_Use
            txtPurVal.AutoCompleteCustomSource = objAf.Accessory_PurValue
            Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
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
    ''' <summary>
    ''' Handles the Click event of the btnEdit control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        Try
            Dim strMan As String = FluffContent(txtMan.Text)
            Dim strModel As String = FluffContent(txtModel.Text)
            Dim strSerial As String = FluffContent(txtSerial.Text)
            Dim strCondition As String = cmdCondition.SelectedItem.ToString
            Dim strUse As String = FluffContent(txtUse.Text)
            Dim strPurVal As String = FluffContent(txtPurVal.Text)
            Dim strNotes As String = FluffContent(txtNotes.Text)
            Dim dAppValue As Double = FluffContent(txtAppValue.Text, 0.0)
            Dim iCiv As Integer = 0
            Dim iIc As Integer = 0
            If chkCIV.Checked Then iCiv = 1
            If chkIsChoke.Checked Then iIc = 1
            If Not IsRequired(strMan, "Manufacturer", Text) Then Exit Sub
            If Not IsRequired(strModel, "Model", Text) Then Exit Sub
            Dim obj As New BSDatabase
            Dim sql As String = "UPDATE Gun_Collection_Accessories set Manufacturer='" & strMan &
                                "',Model='" & strModel & "',SerialNumber='" & strSerial & "',Condition='" &
                                strCondition & "',Notes='" & strNotes & "',Use='" & strUse & "',PurValue='" & strPurVal &
                                "', AppValue=" & dAppValue & ",CIV=" & iCiv & ",IC=" & iIc & ",sync_lastupdate=Now() where ID=" & ItemId
            obj.ConnExec(sql)
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnEdit.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class