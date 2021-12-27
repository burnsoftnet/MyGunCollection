Imports BurnSoft.Applications.MGC.Firearms

''' <summary>
''' Class FrmImportFirearm.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public Class FrmImportFirearm
    ''' <summary>
    ''' The error out
    ''' </summary>
    Dim _errOut As String = ""
    ''' <summary>
    ''' Handles the Click event of the btnOpen control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
        Try
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.Filter = $"XML File(*.xml)|*.xml"
            OpenFileDialog1.Title = $"Import Firearm from XML"
            OpenFileDialog1.FileName =""
            If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
            Dim strFilePath As String = OpenFileDialog1.FileName
            lblFile.Text = strFilePath
            If Len(strFilePath) > 0 Then btnImport.Enabled = True
        Catch ex As Exception
            Call LogError(Name, "btnOpen.Click", Err.Number, ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnImport control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnImport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImport.Click
        Call ProcessXmlToDb(lblFile.Text)
    End Sub
    ''' <summary>
    ''' Updates the status label.
    ''' </summary>
    ''' <param name="sValue">The s value.</param>
    Sub UpdateStatusLabel(ByVal sValue As String)
        lblProg.Text = sValue
        lblProg.Refresh()
    End Sub
    ''' <summary>
    ''' Updates the progress bar.
    ''' </summary>
    ''' <param name="iValue">The i value.</param>
    Sub UpdateProgressBar(ByVal iValue As Long)
        ProgressBar1.Value = iValue
        ProgressBar1.Refresh()
    End Sub
    ''' <summary>
    ''' Processes the XML to database.
    ''' </summary>
    ''' <param name="strPath">The string path.</param>
    Sub ProcessXmlToDb(ByVal strPath As String)
        Try
            Dim fullName As String = ""
            Dim firearmId As Long 

            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = 5
            UseWaitCursor = True
            Dim I As Integer 

            I += 1
            Call UpdateStatusLabel("Getting Firearm Details")
            if Not XmlImport.Details(DatabasePath, strPath, OwnerId,UseNumberCatOnly, _errOut) Then Throw New Exception(_errOut)
            firearmId = MyCollection.GetLastId(DatabasePath, _errOut)
            
            Call UpdateProgressBar(I)
            I += 1
            Call UpdateStatusLabel("Getting Accessories List")
            if Not XmlImport.Accessories(DatabasePath, strPath, firearmId, _errOut) Then Throw New Exception(_errOut)
            Call UpdateProgressBar(I)
            I += 1
            Call UpdateStatusLabel("Getting Barrel/Conversion Kit details")
            if Not XmlImport.BarrelConverstionKitDetails(DatabasePath, strPath, firearmId, _errOut) Then Throw New Exception(_errOut)
            Call UpdateProgressBar(I)
            I += 1
            Call UpdateStatusLabel("Getting Maintance Details")
            if Not XmlImport.MaintanceDetails(DatabasePath, strPath, firearmId, _errOut) Then Throw New Exception(_errOut)
            Call UpdateProgressBar(I)
            I += 1
            Call UpdateStatusLabel("Getting GunSmith Details")
            if Not XmlImport.GunSmithDetails(DatabasePath, strPath, firearmId, _errOut) Then Throw New Exception(_errOut)
            Call UpdateProgressBar(I)
            UseWaitCursor = False
            MsgBox("Import of the " & fullName & " firearm is complete!")
        Catch ex As Exception
            Dim sSubFunc As String = "ProcessXMLToDB"
            Call LogError(Name, sSubFunc, Err.Number, ex.Message.ToString)
            UseWaitCursor = False
            MsgBox("Error occured while attempting to import file. See log for details.")
        End Try
        MDIParent1.RefreshCollection()
        Close()
    End Sub
    ''' <summary>
    ''' Handles the Load event of the FrmImportFirearm control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub FrmImportFirearm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFile.Text = ""
        lblProg.Text = ""
    End Sub
End Class