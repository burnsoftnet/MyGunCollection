Imports BSMyGunCollection.MGC
Public Class frmAddManufacturer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim strMan As String = FluffContent(txtMan.Text)
            If Not IsRequired(strMan, "Manufacture's Name", Me.Text) Then Exit Sub
            Dim ObjGF As New GlobalFunctions
            If Not ObjGF.ObjectExistsinDB(strMan, "Brand", "Gun_Manufacturer") Then
                Dim Obj As New BSDatabase
                Dim SQL As String = "INSERT INTO Gun_Manufacturer(Brand,sync_lastupdate) VALUES('" & strMan & "',Now())"
                Obj.ConnExec(SQL)
                MsgBox(strMan & " was added to the database!", MsgBoxStyle.Information, Me.Text)
                txtMan.Text = ""
                'Me.Close()
            Else
                MsgBox(strMan & " already existed in the database!", MsgBoxStyle.Critical, Me.Text)
                txtMan.Text = ""
            End If
        Catch ex As Exception
            Dim sSubFunc As String = "btnAdd.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmAddManufacturer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ObjAF As New AutoFillCollections
            txtMan.AutoCompleteCustomSource = ObjAF.Gun_Manufacturer()
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub chkKTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKTop.CheckedChanged
        Me.TopMost = chkKTop.Checked
        Me.MdiParent = Nothing
    End Sub
End Class