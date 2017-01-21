Imports System.IO
Imports BSMyGunCollection.MGC
Imports System.Data
Imports System.Data.Odbc
Imports ADODB
Public Class frmAddDocument

    Private Sub frmAddDocument_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Try
            OpenFileDialog1.FilterIndex = 3
            OpenFileDialog1.Filter = "PDF Files(*.pdf)|*.pdf|Text Files(*.txt)|*.txt|Jpg Files(*.jpg)|*.jpg"
            'If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then Label1.Text = OpenFileDialog1.FileName
        Catch ex As Exception
            Dim sSubFunc As String = "btnBrowse.Click"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

    End Sub
End Class