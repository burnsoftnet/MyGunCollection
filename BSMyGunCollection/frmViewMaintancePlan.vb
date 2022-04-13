Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class FrmViewMaintancePlan.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmViewMaintancePlan
    ''' <summary>
    ''' The identifier
    ''' </summary>
    Public Id As String
    ''' <summary>
    ''' The error out
    ''' </summary>
    Private errOut as String
    ''' <summary>
    ''' Gets the data.
    ''' </summary>
    Sub GetData()
        Try

            Dim lst as List(Of MaintancePlansList) = BurnSoft.Applications.MGC.Firearms.MaintancePlans.Lists(DatabasePath, Id, errOut)
            If errOut.Length > 0 Then Throw New Exception(errOut)

            For Each l As MaintancePlansList In lst
                txtName.Text = l.Name
                txtOD.Text = l.OperationDetails
                nudIID.Value = l.IntervalsInDays
                nudIIRF.Value = l.IntervalInRoundsFired
                txtNotes.Text = l.Notes
            Next


            'Dim obj As New BsDatabase
            'Call obj.ConnectDb()
            'Dim sql As String = "SELECT * from Maintance_Plans where ID=" & Id
            'Dim cmd As New OdbcCommand(sql, obj.Conn)
            'Dim rs As OdbcDataReader
            'rs = cmd.ExecuteReader
            'While (rs.Read())
            '    If Not IsDBNull(rs("Name")) Then txtName.Text = rs("Name")
            '    If Not IsDBNull(rs("OD")) Then txtOD.Text = rs("OD")
            '    If Not IsDBNull(rs("iid")) Then nudIID.Value = rs("iid")
            '    If Not IsDBNull(rs("iirf")) Then nudIIRF.Value = rs("iirf")
            '    If Not IsDBNull(rs("Notes")) Then txtNotes.Text = rs("Notes")
            'End While
            'rs.Close()
            'obj.CloseDb()


        Catch ex As Exception
            Call LogError(Name, "GetData", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmViewMaintancePlan control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmViewMaintancePlan_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Len(Id) > 0 Then
            Call GetData()
        Else
            Close()
        End If
    End Sub
    ''' <summary>
    ''' Handles the Click event of the brnCancel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub brnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles brnCancel.Click
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnEdit control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        Text = $"Edit Maintenance Plan"
        btnEdit.Visible = False
        btnUpdate.Visible = True
        txtName.ReadOnly = False
        txtOD.ReadOnly = False
        nudIID.ReadOnly = False
        nudIIRF.ReadOnly = False
        txtNotes.ReadOnly = False
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnUpdate control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Try
            Dim strName As String = FluffContent(txtName.Text)
            Dim strOd As String = FluffContent(txtOD.Text)
            Dim intIid As Integer = nudIID.Value
            Dim intIirf As Integer = nudIIRF.Value
            Dim strNotes As String = FluffContent(txtNotes.Text)
            Dim sql As String = "UPDATE Maintance_Plans set Name='" & strName & "',OD='" & strOd & _
                        "',iid=" & intIid & ",iirf=" & intIirf & ",Notes='" & strNotes & "' where ID=" & Id
            Dim obj As New BsDatabase
            obj.ConnExec(sql)
            btnEdit.Visible = True
            btnUpdate.Visible = False
            txtName.ReadOnly = True
            txtOD.ReadOnly = True
            nudIID.ReadOnly = True
            nudIIRF.ReadOnly = True
            txtNotes.ReadOnly = True
            Text = $"View Maintenance Plan"
        Catch ex As Exception
            Call LogError(Name, "btnUpdate_Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class