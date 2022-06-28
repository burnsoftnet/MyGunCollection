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
        ' Set the title of the form.
        Dim applicationTitle As String
        If My.Application.Info.Title <> "" Then
            applicationTitle = My.Application.Info.Title
        Else
            applicationTitle = Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Text = String.Format("About {0}", applicationTitle)
        LabelProductName.Text = My.Application.Info.ProductName
        LabelVersion.Text = String.Format("App Version {0}", Application.ProductVersion.ToString) & $"  ,  " & String.Format("DB Version {0}", DatabaseRelated.GetDatabaseVersion(DatabasePath, errOut := ""))
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
