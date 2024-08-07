Imports System.IO
Imports BSMyGunCollection.MGC

''' <summary>
''' Class AboutBox1. This class cannot be inherited.
''' Implements the <see cref="System.Windows.Forms.Form" />
''' </summary>
''' <seealso cref="System.Windows.Forms.Form" />
Public NotInheritable Class AboutBox1
    'When the form Loads, populate the fields
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
        Dim objGf As New GlobalFunctions
        LabelVersion.Text = String.Format("App Version {0}", Application.ProductVersion.ToString) & $"  ,  " & String.Format("DB Version {0}", objGf.DatabaseVersion)
        LabelCopyright.Text = My.Application.Info.Copyright
        LabelCompanyName.Text = My.Application.Info.CompanyName
        TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OKButton.Click
        Close()
    End Sub
End Class
