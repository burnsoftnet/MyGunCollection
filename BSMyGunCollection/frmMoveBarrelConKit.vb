Imports BSMyGunCollection.MGC
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
            Dim obj As New BSDatabase
            Dim sql As String = "Update Gun_Collection_Ext set GID=" & gid & " where id=" & BarrelId
            obj.ConnExec(sql)
            sql = "update Gun_Collection_Ext_Links set gid=" & gid & " where bsid=" & BarrelId
            obj.ConnExec(sql)
            sql = "UPDATE Maintance_Details set GID=" & gid & " where BSID=" & BarrelId
            obj.ConnExec(sql)
            MsgBox("Barrel/Conversion Kit was moved to " & fullName)
            Close()
        Catch ex As Exception
            Dim sSubFunc As String = "btnAttach_Click"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try

    End Sub
End Class