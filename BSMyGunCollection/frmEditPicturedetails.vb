Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
''' <summary>
''' Class FrmEditPicturedetails.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmEditPicturedetails
    ''' <summary>
    ''' The picture id
    ''' </summary>
    Public Pid As Long
    ''' <summary>
    ''' Handles the Click event of the btnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim obj As New BsDatabase
            obj.ConnectDb()
            Dim sql As String = "SELECT pd_name,pd_note from Gun_Collection_Pictures where ID=" & Pid
            Dim cmd As New OdbcCommand(sql, obj.Conn)
            Dim rs As OdbcDataReader
            rs = cmd.ExecuteReader
            While rs.Read
                If Not IsDBNull(rs("pd_name")) Then txtName.Text = rs("pd_name")
                If Not IsDBNull(rs("pd_note")) Then txtNotes.Text = rs("pd_note")
            End While
            rs.Close()

            obj.CloseDb()
        Catch ex As Exception
            Call LogError(Name, "LoadData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnUpdate control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Try
            Dim sTitle As String = FluffContent(txtName.Text)
            Dim sNotes As String = FluffContent(txtNotes.Text)
            Dim sql As String = "UPDATE Gun_Collection_Pictures set pd_name='" & _
                                sTitle & "', pd_note='" & sNotes & "',sync_lastupdate=Now() where ID=" & Pid
            Dim obj As New BsDatabase
            obj.ConnExec(sql)
            Close()
        Catch ex As Exception
            Call LogError(Name, "btnUpdate.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmEditPicturedetails control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditPicturedetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Call LoadData()
    End Sub
End Class