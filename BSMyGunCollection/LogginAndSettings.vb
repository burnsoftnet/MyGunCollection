Imports System.IO
Imports System.Text
Imports BSMyGunCollection.My

Namespace LogginAndSettings

    ''' <summary>
    ''' Class BSFileSystem.
    ''' </summary>
    Public Class BsFileSystem
        ''' <summary>
        ''' Logs the file.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        ''' <param name="strMessage">The string message.</param>
        Public Sub LogFile(ByVal strPath As String, ByVal strMessage As String)
            Dim sendMessage As String = DateTime.Now & vbTab & strMessage
            Call AppendToFile(strPath, sendMessage)
            MDIParent1.tsslErrorsFound.Visible = True
            MDIParent1.tsslErrorsFound.Enabled = True
        End Sub
        ''' <summary>
        ''' Logs the debug file.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        ''' <param name="strMessage">The string message.</param>
        Public Sub LogDebugFile(ByVal strPath As String, ByVal strMessage As String)
            Dim sendMessage As String = DateTime.Now & vbTab & strMessage
            Call AppendToFile(strPath, sendMessage)
        End Sub

        ''' <summary>
        ''' Files the exists.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        ''' <returns>System.Object.</returns>
        Public Function FileExists(ByVal strPath As String)
            Return File.Exists(strPath)
        End Function
        ''' <summary>
        ''' Creates the file.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        Private Sub CreateFile(ByVal strPath As String)
            If File.Exists(strPath) = False Then
                Dim fs As New FileStream(strPath, FileMode.Append, FileAccess.Write, FileShare.Write)
                fs.Close()
            End If
        End Sub
        ''' <summary>
        ''' Converts to file.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        ''' <param name="strNewLine">Creates new line.</param>
        Private Sub AppendToFile(ByVal strPath As String, ByVal strNewLine As String)
            If File.Exists(strPath) = False Then Call CreateFile(strPath)
            Dim sw As New StreamWriter(strPath, True, Encoding.ASCII)
            sw.WriteLine(strNewLine)
            sw.Close()
        End Sub
        ''' <summary>
        ''' Directories the exists.
        ''' </summary>
        ''' <param name="strPath">The string path.</param>
        ''' <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        Public Function DirectoryExists(ByVal strPath As String) As Boolean
            Return Directory.Exists(strPath)
        End Function
    End Class
    ''' <summary>
    ''' Class ViewSizeSettings.
    ''' </summary>
    Public Class ViewSizeSettings
        ''' <summary>
        ''' Loads the view collection details.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="location">The location.</param>
' ReSharper disable once RedundantAssignment
        Sub LoadViewCollectionDetails(ByRef height As Long, ByRef width As Long, ByVal location As Point)
            If Settings.ViewCollectionDetails_Width.Length > 0 And Settings.ViewCollectionDetails_Height.Length > 0 Then
                height = Settings.ViewCollectionDetails_Height
                width = Settings.ViewCollectionDetails_Width
            End If
            If Settings.ViewCollectionDetails_X.Length > 0 And Settings.ViewCollectionDetails_Y.Length > 0 Then
' ReSharper disable once RedundantAssignment
                location = New Point(Settings.ViewCollectionDetails_X, Settings.ViewCollectionDetails_Y)
            End If
        End Sub
        ''' <summary>
        ''' Saves the view collection details.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="x">The x.</param>
        ''' <param name="y">The y.</param>
        Sub SaveViewCollectionDetails(ByVal height As Long, ByVal width As Long, ByVal x As Long, ByVal y As Long)
            Settings.ViewCollectionDetails_Height = height
            Settings.ViewCollectionDetails_Width = width
            Settings.ViewCollectionDetails_X = x
            Settings.ViewCollectionDetails_Y = y
            Settings.Save()
        End Sub
        ''' <summary>
        ''' Loads the view view picture.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="location">The location.</param>
        Sub LoadViewViewPicture(ByRef height As Long, ByRef width As Long, ByVal location As Point)
            If Settings.ViewPicture_Width.Length > 0 And Settings.ViewPicture_Height.Length > 0 Then
                height = Settings.ViewPicture_Height
                width = Settings.ViewPicture_Width
            End If
            If Settings.ViewPicture_X.Length > 0 And Settings.ViewPicture_Y.Length > 0 Then
                location = New Point(Settings.ViewPicture_X, Settings.ViewPicture_Y)
            End If
        End Sub
        ''' <summary>
        ''' Saves the view picture.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="x">The x.</param>
        ''' <param name="y">The y.</param>
        Sub SaveViewPicture(ByVal height As Long, ByVal width As Long, ByVal x As Long, ByVal y As Long)
            Settings.ViewPicture_Height = height
            Settings.ViewPicture_Width = width
            Settings.ViewPicture_X = x
            Settings.ViewPicture_Y = y
            Settings.Save()
        End Sub
        ''' <summary>
        ''' Loads the view ammo inv.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="location">The location.</param>
        Sub LoadViewAmmoInv(ByRef height As Long, ByRef width As Long, ByVal location As Point)
            If Settings.ViewAmmoInv_Width.Length > 0 And Settings.ViewAmmoInv_Height.Length > 0 Then
                height = Settings.ViewAmmoInv_Height
                width = Settings.ViewAmmoInv_Width
            End If
            If Settings.ViewAmmoInv_X.Length > 0 And Settings.ViewAmmoInv_Y.Length > 0 Then
                location = New Point(Settings.ViewAmmoInv_X, Settings.ViewAmmoInv_Y)
            End If
        End Sub
        ''' <summary>
        ''' Saves the view ammo inv.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="x">The x.</param>
        ''' <param name="y">The y.</param>
        Sub SaveViewAmmoInv(ByVal height As Long, ByVal width As Long, ByVal x As Long, ByVal y As Long)
            Settings.ViewAmmoInv_Height = height
            Settings.ViewAmmoInv_Width = width
            Settings.ViewAmmoInv_X = x
            Settings.ViewAmmoInv_Y = y
            Settings.Save()
        End Sub
        ''' <summary>
        ''' Loads the view general accessories.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="location">The location.</param>
        ''' <example>
        ''' Dim objVs As New ViewSizeSettings
        ''' objVs.LoadViewGeneralAccessories(Height, Width, Location)
        ''' </example>
        Sub LoadViewGeneralAccessories(ByRef height As Long, ByRef width As Long, ByVal location As Point)
            If Settings.frmViewGeneralAccessories_Width.Length > 0 And Settings.frmViewGeneralAccessories_Height.Length > 0 Then
                height = Settings.frmViewGeneralAccessories_Height
                width = Settings.frmViewGeneralAccessories_Width
            End If
            If Settings.frmViewGeneralAccessories_X.Length > 0 And Settings.frmViewGeneralAccessories_Y.Length > 0 Then
                location = New Point(Settings.frmViewGeneralAccessories_X, Settings.frmViewGeneralAccessories_Y)
            End If
        End Sub
        ''' <summary>
        ''' Saves the view general accessories.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="x">The x.</param>
        ''' <param name="y">The y.</param>
        ''' <example>
        ''' Dim objVs As New ViewSizeSettings
        ''' objVs.SaveViewGeneralAccessories(Height, Width, Location.X, Location.Y)
        ''' </example>
        Sub SaveViewGeneralAccessories(ByVal height As Long, ByVal width As Long, ByVal x As Long, ByVal y As Long)
            Settings.frmViewGeneralAccessories_Height = height
            Settings.frmViewGeneralAccessories_Width = width
            Settings.frmViewGeneralAccessories_X = x
            Settings.frmViewGeneralAccessories_Y = y
            Settings.Save()
        End Sub

        ''' <summary>
        ''' Loads the view wish list.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="location">The location.</param>
        ''' <example>
        ''' Dim objVs As New ViewSizeSettings
        ''' objVs.LoadViewWishList(Height, Width, Location)
        ''' </example>
        Sub LoadViewWishList(ByRef height As Long, ByRef width As Long, ByVal location As Point)
            If Settings.FrmViewWishList_Width.Length > 0 And Settings.FrmViewWishList_Height.Length > 0 Then
                height = Settings.FrmViewWishList_Height
                width = Settings.FrmViewWishList_Width
            End If
            If Settings.FrmViewWishList_X.Length > 0 And Settings.FrmViewWishList_Y.Length > 0 Then
                location = New Point(Settings.FrmViewWishList_X, Settings.FrmViewWishList_Y)
            End If
        End Sub

        ''' <summary>
        ''' Saves the view wish list.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="x">The x.</param>
        ''' <param name="y">The y.</param>
        ''' <example>
        ''' Dim objVs As New ViewSizeSettings
        ''' objVs.SaveViewWishList(Height, Width, Location.X, Location.Y)
        ''' </example>
        Sub SaveViewWishList(ByVal height As Long, ByVal width As Long, ByVal x As Long, ByVal y As Long)
            Settings.FrmViewWishList_Height = height
            Settings.FrmViewWishList_Width = width
            Settings.FrmViewWishList_X = x
            Settings.FrmViewWishList_Y = y
            Settings.Save()
        End Sub

        ''' <summary>
        ''' Loads the view documents.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="location">The location.</param>
        ''' <example>
        ''' Dim objVs As New ViewSizeSettings
        ''' objVs.LoadViewDocuments(Height, Width, Location)
        ''' </example>
        Sub LoadViewDocuments(ByRef height As Long, ByRef width As Long, ByVal location As Point)
            If Settings.frmViewDocuments_Width.Length > 0 And Settings.frmViewDocuments_Height.Length > 0 Then
                height = Settings.frmViewDocuments_Height
                width = Settings.frmViewDocuments_Width
            End If
            If Settings.frmViewDocuments_X.Length > 0 And Settings.frmViewDocuments_Y.Length > 0 Then
                location = New Point(Settings.frmViewDocuments_X, Settings.frmViewDocuments_Y)
            End If
        End Sub

        ''' <summary>
        ''' Saves the view documents.
        ''' </summary>
        ''' <param name="height">The height.</param>
        ''' <param name="width">The width.</param>
        ''' <param name="x">The x.</param>
        ''' <param name="y">The y.</param>
        ''' <example>
        ''' Dim objVs As New ViewSizeSettings
        ''' objVs.SaveViewDocuments(Height, Width, Location.X, Location.Y)
        ''' </example>
        Sub SaveViewDocuments(ByVal height As Long, ByVal width As Long, ByVal x As Long, ByVal y As Long)
            Settings.frmViewDocuments_Height = height
            Settings.frmViewDocuments_Width = width
            Settings.frmViewDocuments_X = x
            Settings.frmViewDocuments_Y = y
            Settings.Save()
        End Sub
    End Class
    ''' <summary>
    ''' Class FormData.
    ''' </summary>
    Public Class FormData
        ''' <summary>
        ''' Loads the filter list.
        ''' </summary>
        ''' <returns>System.String().</returns>
        Public Function LoadFilterList() As String()
           Dim source As String = Settings.FirearmDropDownFilter
           Dim delimiters() As Char = {","c} 
           return source.Split(delimiters)
       End Function
        ''' <summary>
        ''' Saves the filter list.
        ''' </summary>
        ''' <param name="value">The value.</param>
        Public Sub SaveFilterList(value As String)
           Settings.FirearmDropDownFilter = value
           Settings.Save()
       End Sub
        ''' <summary>
        ''' Generates the drop down list.
        ''' </summary>
        ''' <returns>System.String().</returns>
        public Function GenerateDropDownList() As String()
           Return {"ALL", 
                   "In Stock", 
                   "In Stock - By Date Purchased", 
                   "In Stock - Rating", 
                   "In Stock - Lethal", 
                   "In Stock - Lethal Rating", 
                   "In Stock - Non-Lethal", 
                   "In Stock - Non-Lethal Rating", 
                   "Competition", 
                   "Gunsmith Prjects", 
                   "Class III", 
                   "C & R", 
                   "Collecting Only", 
                   "Non C & R", 
                   "Cust. Catalog #", 
                   "Ready To Sell", 
                   "Sold/Stolen", 
                   "Sold/Stolen - By Date"}
       End Function

    End Class
End Namespace
