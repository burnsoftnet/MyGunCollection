Imports BSMyGunCollection.LogginAndSettings

Public Class FrmFirearmDropDownListFilter
    ''' <summary>
    ''' The current filter
    ''' </summary>
    Public Dim CurrentFilter As String()
    ''' <summary>
    ''' Handles the Load event of the FrmFirearmDropDownListFilter control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub FrmFirearmDropDownListFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj As New FormData
        ChkLstBxItems.DataSource = obj.GenerateDropDownList
        LoadCurrentlyUsed()
    End Sub
    ''' <summary>
    ''' Loads the currently used.
    ''' </summary>
    Private Sub LoadCurrentlyUsed()
        Dim Item As Object
        For i As Integer = 0 To ChkLstBxItems.Items.Count - 1
            Item = ChkLstBxItems.Items(i)
            
            If IsInCurrent(item.ToString()) Then
                ChkLstBxItems.SetItemChecked(i, True)
            Else
                ChkLstBxItems.SetItemChecked(i, False)
            End If
        Next
    End Sub
    ''' <summary>
    ''' Determines whether [is in current] [the specified value].
    ''' </summary>
    ''' <param name="value">The value.</param>
    ''' <returns><c>true</c> if [is in current] [the specified value]; otherwise, <c>false</c>.</returns>
    Private Function IsInCurrent(value As string) As Boolean
        Dim bAns As Boolean = False
        For Each item As String In CurrentFilter
            If value.Equals(item) Then
                bAns = True
                Exit For
            End If
        Next
        Return bAns
    End Function
    ''' <summary>
    ''' Handles the Click event of the BtnSave control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ChkLstBxItems.CheckedItems.Count <> 0 Then
            Dim selectedLists As String = ""
            Dim obj As New FormData
            For Each itemChecked As Object In ChkLstBxItems.CheckedItems
                selectedLists += itemChecked.ToString() + ","
            Next
            Dim charsToTrim() As Char = {","c}
            obj.SaveFilterList(selectedLists.TrimEnd(charsToTrim))
        Else 
            MessageBox.Show("You Must select as 1 Item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub
End Class