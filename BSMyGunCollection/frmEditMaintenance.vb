Imports BSMyGunCollection.MGC
Imports System.Data.Odbc
''' <summary>
''' Class frmEditMaintenance.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class frmEditMaintenance
    ''' <summary>
    ''' The gid
    ''' </summary>
    Public GID As String
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
    Public BSID As String
    ''' <summary>
    ''' The mid
    ''' </summary>
    Public MID As Long
    ''' <summary>
    ''' Loads the data.
    ''' </summary>
    Sub LoadData()
        Try
            Dim Obj As New BSDatabase
            Obj.ConnectDB()
            Dim SQL As String = "SELECT * from Maintance_Details where ID=" & MID
            Dim CMD As New OdbcCommand(SQL, Obj.Conn)
            Dim RS As OdbcDataReader
            RS = CMD.ExecuteReader
            Dim DC As Integer = 0
            Dim MaintID As Long
            While RS.Read
                MaintID = RS("mpid")
                GID = RS("gid")
                ComboBox1.SelectedValue = MaintID
                DateTimePicker1.Value = RS("opDate")
                DateTimePicker2.Value = RS("OpDueDate")
                NumericUpDown1.Value = RS("RndFired")
                txtNotes.Text = RS("notes")
                If Not IsDBNull(RS("au")) Then txtAmmoUsed.Text = RS("au")
                If Not IsDBNull(RS("bsid")) Then BSID = RS("bsid")
                If Not IsDBNull(RS("dc")) Then DC = RS("dc")
                If DC = 1 Then
                    chkInAVG.Checked = True
                Else
                    chkInAVG.Checked = False
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
    ''' Handles the Load event of the frmEditMaintenance control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub frmEditMaintenance_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.Maintance_PlansTableAdapter.Fill(Me.MGCDataSet.Maintance_Plans)
            Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnViewPlans control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnViewPlans_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnViewPlans.Click
        Try
            frmViewMaintancePlan.MdiParent = Me.MdiParent
            Dim strID As String = ComboBox1.SelectedValue
            frmViewMaintancePlan.ID = strID
            frmViewMaintancePlan.Show()
        Catch ex As Exception
            Dim sSubFunc As String = "btnViewPlans_Click"
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
    ''' Handles the Click event of the btnAdd control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Dim strID As String = ComboBox1.SelectedValue
            Dim strName As String = FluffContent(ComboBox1.Text)
            Dim strOD As String = DateTimePicker1.Value
            Dim strODDue As String = DateTimePicker2.Value
            Dim strODRF As String = NumericUpDown1.Value
            Dim strNotes As String = FluffContent(txtNotes.Text)
            Dim InAvg As Boolean = chkInAVG.Checked
            Dim sAU As String = FluffContent(txtAmmoUsed.Text)
            Dim iAvg As Integer = 0
            If InAvg Then iAvg = 1
            If Not IsRequired(strName, "Maintenance Plan", Me.Text) Then Exit Sub
            Dim SQL As String = "UPDATE Maintance_Details set gid=" & GID & ",mpid=" & strID &
                                ",Name='" & strName & "',OpDate='" & strOD & "',OpDueDate='" &
                                strODDue & "',RndFired='" & strODRF & "',Notes='" & strNotes &
                                "',au='" & sAU & "',BSID=" & BSID & ",DC=" & iAvg & ",sync_lastupdate=Now() where ID=" &
                                MID
            Dim Obj As New BSDatabase
            Obj.ConnExec(SQL)
            Me.Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the Button1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        frmAmmoCalc.MdiParent = Me.MdiParent
        frmAmmoCalc.AmmoType = AmmoType
        frmAmmoCalc.AmmoTypePet = AmmoTypePet
        frmAmmoCalc.Show()
    End Sub
End Class