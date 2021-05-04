Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
Imports BurnSoft.Applications.MGC.Types

''' <summary>
''' Class frmEditMaintenance.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmEditMaintenance
    ''' <summary>
    ''' The gid
    ''' </summary>
    Public Gid As String
    ''' <summary>
    ''' The ammo type
    ''' </summary>
    Public AmmoType As String
    ''' <summary>
    ''' The ammo type pet
    ''' </summary>
    Public AmmoTypePet As String
    ''' <summary>
    ''' The bsid
    ''' </summary>
    Public Bsid As String
    ''' <summary>
    ''' The mid
    ''' </summary>
    Public Mid As Long
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim errOut as String = ""
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            'Dim obj As New BSDatabase
            'obj.ConnectDB()
            'Dim sql As String = "SELECT * from Maintance_Details where ID=" & Mid
            'Dim cmd As New OdbcCommand(sql, obj.Conn)
            'Dim rs As OdbcDataReader
            'rs = cmd.ExecuteReader
            'Dim dc As Integer = 0
            Dim maintId As Long
            'While rs.Read
            '    maintId = rs("mpid")
            '    Gid = rs("gid")
            '    ComboBox1.SelectedValue = maintId
            '    DateTimePicker1.Value = rs("opDate")
            '    DateTimePicker2.Value = rs("OpDueDate")
            '    NumericUpDown1.Value = rs("RndFired")
            '    txtNotes.Text = rs("notes")
            '    If Not IsDBNull(rs("au")) Then txtAmmoUsed.Text = rs("au")
            '    If Not IsDBNull(rs("bsid")) Then Bsid = rs("bsid")
            '    If Not IsDBNull(rs("dc")) Then dc = rs("dc")
            '    If dc = 1 Then
            '        chkInAVG.Checked = True
            '    Else
            '        chkInAVG.Checked = False
            '    End If
            'End While
            'rs.Close()
            'obj.CloseDB()
            Dim lst As List(Of MaintanceDetailsList) = BurnSoft.Applications.MGC.Firearms.MaintanceDetails.Lists(DatabasePath, Mid, errOut)
            If errOut.Length > 0 Then Throw New Exception(errOut)
            For Each o As MaintanceDetailsList In lst 
                maintId = o.Id
                Gid = o.GunId
                'ComboBox1.SelectedValue =
            Next
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Load event of the frmEditMaintenance control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditMaintenance_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Maintance_PlansTableAdapter.Fill(MGCDataSet.Maintance_Plans)
            Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnViewPlans control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnViewPlans_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnViewPlans.Click
        Try
            frmViewMaintancePlan.MdiParent = MdiParent
            Dim strId As String = ComboBox1.SelectedValue
            frmViewMaintancePlan.Id = strId
            frmViewMaintancePlan.Show()
        Catch ex As Exception
            Dim sSubFunc As String = "btnViewPlans_Click"
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
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim strId As String = ComboBox1.SelectedValue
            Dim strName As String = FluffContent(ComboBox1.Text)
            Dim strOd As String = DateTimePicker1.Value
            Dim strOdDue As String = DateTimePicker2.Value
            Dim strOdrf As String = NumericUpDown1.Value
            Dim strNotes As String = FluffContent(txtNotes.Text)
            Dim inAvg As Boolean = chkInAVG.Checked
            Dim sAu As String = FluffContent(txtAmmoUsed.Text)
            Dim iAvg As Integer = 0
            If inAvg Then iAvg = 1
            If Not IsRequired(strName, "Maintenance Plan", Text) Then Exit Sub
            Dim sql As String = "UPDATE Maintance_Details set gid=" & Gid & ",mpid=" & strId &
                                ",Name='" & strName & "',OpDate='" & strOd & "',OpDueDate='" &
                                strOdDue & "',RndFired='" & strOdrf & "',Notes='" & strNotes &
                                "',au='" & sAu & "',BSID=" & Bsid & ",DC=" & iAvg & ",sync_lastupdate=Now() where ID=" &
                                Mid
            Dim obj As New BSDatabase
            obj.ConnExec(sql)
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the Button1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        frmAmmoCalc.MdiParent = MdiParent
        frmAmmoCalc.AmmoType = AmmoType
        frmAmmoCalc.AmmoTypePet = AmmoTypePet
        frmAmmoCalc.Show()
    End Sub
End Class