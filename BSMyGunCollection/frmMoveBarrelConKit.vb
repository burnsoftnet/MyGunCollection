''' <summary>
''' Class FrmMoveBarrelConKit.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmMoveBarrelConKit
    ''' <summary>
    ''' The barrel identifier
    ''' </summary>
    Public BarrelId As Long
    ''' <summary>
    ''' Handles the Load event of the frmMoveBarrelConKit control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub frmMoveBarrelConKit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Gun_CollectionTableAdapter.Fill(MGCDataSet.Gun_Collection)
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnAttach control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
        Try
            Dim gid As Long = cmbFirearm.SelectedValue
            Dim fullName As String = cmbFirearm.SelectedText
            Dim errOut As String = ""
            If Not BurnSoft.Applications.MGC.Firearms.ExtraBarrelConvoKits.Move(DatabasePath, GID, BarrelId, errOut) Then Throw New Exception(errOut)
            MsgBox("Barrel/Conversion Kit was moved to " & fullName)
            Close()
        Catch ex As Exception
            Call LogError(Name, "btnAttach_Click", Err.Number, ex.Message.ToString)
        End Try

    End Sub
End Class