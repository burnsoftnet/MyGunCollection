Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
''' <summary>
''' Class frmEditAccessory.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmEditAccessory
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemID As String
    ''' <summary>
    ''' The is shot gun
    ''' </summary>
    Public IsShotGun As Boolean
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim SQL As String = "SELECT * from Gun_Collection_Accessories where ID=" & ItemID
            Dim Obj As New BSDatabase
            Call Obj.ConnectDB()
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            Dim iCIV As Integer
            Dim iIC As Integer
            While RS.Read
                txtMan.Text = Trim(RS("Manufacturer"))
                txtModel.Text = Trim(RS("Model"))
                txtSerial.Text = Trim(RS("SerialNumber"))
                cmdCondition.Text = Trim(RS("Condition"))
                txtUse.Text = Trim(RS("Use"))
                txtPurVal.Text = Trim(RS("PurValue"))
                txtNotes.Text = Trim(RS("Notes"))
                txtAppValue.Text = RS("AppValue")
                iCIV = RS("CIV")
                If iCIV = 1 Then
                    chkCIV.Checked = True
                Else
                    chkCIV.Checked = False
                End If
                If IsShotGun Then
                    iIC = RS("IC")
                    If iIC = 1 Then
                        chkIsChoke.Checked = True
                    Else
                        chkIsChoke.Checked = False
                    End If
                End If
            End While
            RS.Close()
            RS = Nothing
            CMD = Nothing
            Obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
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
            Dim ObjAF As New AutoFillCollections
            txtMan.AutoCompleteCustomSource = ObjAF.Accessory_Manufacturer
            txtModel.AutoCompleteCustomSource = ObjAF.Accessory_Model
            txtUse.AutoCompleteCustomSource = ObjAF.Accessory_Use
            txtPurVal.AutoCompleteCustomSource = ObjAF.Accessory_PurValue
            Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
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
            Dim iCIV As Integer = 0
            Dim iIC As Integer = 0
            If chkCIV.Checked Then iCIV = 1
            If chkIsChoke.Checked Then iIC = 1
            If Not IsRequired(strMan, "Manufacturer", Me.Text) Then Exit Sub
            If Not IsRequired(strModel, "Model", Me.Text) Then Exit Sub
            Dim Obj As New BSDatabase
            Dim SQL As String = "UPDATE Gun_Collection_Accessories set Manufacturer='" & strMan &
                                "',Model='" & strModel & "',SerialNumber='" & strSerial & "',Condition='" &
                                strCondition & "',Notes='" & strNotes & "',Use='" & strUse & "',PurValue='" & strPurVal &
                                "', AppValue=" & dAppValue & ",CIV=" & iCIV & ",IC=" & iIC & ",sync_lastupdate=Now() where ID=" & ItemID
            Obj.ConnExec(SQL)
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnEdit.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class