Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
''TODO: Convert code from FrmCopyAccessory #11
''' <summary>
''' Class frmCopyAccessory.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmCopyAccessory
    ''' <summary>
    ''' The item identifier
    ''' </summary>
    Public ItemId As String ' Accessory ID    
    ''' <summary>
    ''' The full name
    ''' </summary>
    Private _fullName As String ' Full Name    
    ''' <summary>
    ''' Get the Accessory Manufacture and Model for the form details
    ''' </summary>
    ''' <param name="strId">The string identifier.</param>
    ''' <returns>System.String.</returns>
    Function GetFullName(ByVal strId As String) As String
        Dim sAns As String = ""
        Try
            Dim obj As New BSDatabase
            obj.ConnectDB()
            Dim sql As String = "SELECT * from Gun_Collection_Accessories where ID=" & ItemId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            While rs.Read
                sAns = Trim(rs("Manufacturer")) & " " & Trim(rs("Model"))
            End While
            rs.Close()
            obj.CloseDB()
        Catch ex As Exception
            Dim sSubFunc As String = "GetFullName"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        Return sAns
    End Function
    ''' <summary>
    ''' Perform the Copy Action and copy the accessory back into the same database but associate with the selected firearm.
    ''' </summary>
    ''' <param name="strId">The string identifier.</param>
    Sub DoCopy(ByVal strId As String)
        Try
            Dim obj As New BSDatabase
            obj.ConnectDB()
            Dim sql As String = "SELECT * from Gun_Collection_Accessories where ID=" & ItemId
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            Dim strMan As String = ""
            Dim strModel As String = ""
            Dim strSerial As String = ""
            Dim strCondition As String = ""
            Dim strUse As String = ""
            Dim strPurVal As String = ""
            Dim strNotes As String = ""
            Dim strAppVal As String = "0"
            Dim iCiv As Integer = 0
            Dim ic As Integer = 0

            While rs.Read
                strMan = rs("Manufacturer")
                strModel = rs("Model")
                strSerial = rs("SerialNumber")
                strCondition = rs("Condition")
                strUse = rs("Use")
                strPurVal = rs("PurValue")
                strNotes = rs("Notes")
                If Not IsDBNull(rs("AppValue")) Then strAppVal = rs("AppValue")
                If Not IsDBNull(rs("CIV")) Then iCiv = rs("CIV")
                If Not IsDBNull(rs("IC")) Then ic = rs("IC")
            End While
            rs.Close()

            sql = "INSERT INTO Gun_Collection_Accessories(GID,Manufacturer,Model,SerialNumber,Condition,Notes,Use,PurValue,sync_lastupdate,AppValue,CIV,IC) VALUES(" &
                        strId & ",'" & strMan & "','" & strModel & "','" & strSerial & "','" & strCondition & "','" &
                        strNotes & "','" & strUse & "','" & strPurVal & "',Now(),'" & strAppVal & "'," & iCiv & "," & ic & ")"
            Call obj.ConnExec(sql)
        Catch ex As Exception
            Dim sSubFunc As String = "DoCopy"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' When Load Forms, populate the drop down box
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmCopyAccessory_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            QryGunCollectionDetailsTableAdapter.FillBy_Default(MGCDataSet.qryGunCollectionDetails)
            _fullName = GetFullName(ItemId)
            Label1.Text &= _fullName
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' When the Copy button is selected
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnCopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCopy.Click
        Try
            Dim strFireArmId As String = ComboBox1.SelectedValue.ToString
            Dim strFireArmName As String = ComboBox1.Text
            Call DoCopy(strFireArmId)
            Dim strMsg As String = _fullName & " was copied to " & strFireArmName
            Dim sAns As String = MsgBox(strMsg & Chr(10) & "Do you want to copy it to another item?", MsgBoxStyle.YesNo, Text)
            If sAns = vbNo Then Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnCopy.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class