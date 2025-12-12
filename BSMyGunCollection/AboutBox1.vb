Imports System.IO
Imports BurnSoft.Applications.MGC.Global

''' <summary>
''' Class AboutBox1. This class cannot be inherited.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public NotInheritable Class AboutBox1
    ''' <summary>
    ''' Handles the Load event of the AboutBox1 control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub AboutBox1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim applicationTitle As String
        If My.Application.Info.Title <> "" Then
            applicationTitle = My.Application.Info.Title
        Else
            applicationTitle = Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Dim mainDllVersion as FileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BurnSoft.Applications.MGC.dll"))
        Dim AppVersion As String = $"App Version: {Application.ProductVersion}"
        Dim dbVersion as String = String.Format("DB Version: {0}", DatabaseRelated.GetDatabaseVersion(DatabasePath, errOut := ""))
        Dim dllVersion As String = $"Library Version: {mainDllVersion.FileVersion}"
        Text = String.Format("About {0}", applicationTitle)
        LabelProductName.Text = My.Application.Info.ProductName
        LabelVersion.Text = $"{AppVersion}, {dbVersion} {Environment.NewLine}{dllVersion}"
        LabelCopyright.Text = My.Application.Info.Copyright
        LabelCompanyName.Text = My.Application.Info.CompanyName
        TextBoxDescription.Text = My.Application.Info.Description
    End Sub
    ''' <summary>
    ''' Handles the Click event of the OKButton control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub OKButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OKButton.Click
        Close()
    End Sub
End Class
