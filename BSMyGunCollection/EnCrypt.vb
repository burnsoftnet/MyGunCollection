Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Public Class oEncrypt
    Public Shared Function EncryptMD5(ByVal cleanString As String) As String
        Dim clearBytes As [Byte]()
        clearBytes = New UnicodeEncoding().GetBytes(cleanString)
        Dim hashedBytes As [Byte]() = CType(CryptoConfig.CreateFromName("MD5"), HashAlgorithm).ComputeHash(clearBytes)
        Dim hashedText As String = BitConverter.ToString(hashedBytes)
        Return hashedText
    End Function
    Public Shared Function EncryptSHA(ByVal Data As String) As String
        Dim shaM As New SHA1Managed
        Convert.ToBase64String(shaM.ComputeHash(Encoding.ASCII.GetBytes(Data)))
        Dim eNC_data() As Byte = ASCIIEncoding.ASCII.GetBytes(Data)
        Dim eNC_str As String = Convert.ToBase64String(eNC_data)
        EncryptSHA = eNC_str
    End Function
    Public Shared Function DecryptSHA(ByVal Data As String) As String
        Try
            Dim dEC_data() As Byte = Convert.FromBase64String(Trim(Data))
            Dim dEC_Str As String = ASCIIEncoding.ASCII.GetString(dEC_data)
            DecryptSHA = dEC_Str
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function EncryptURL(ByVal strUrl As String, ByVal strSessionID As String) As String
        Dim strReturn As String = strSessionID & "|" & Trim(strUrl) & "|" & Now.Ticks.ToString
        Return EncryptSHA(Trim(strReturn))

    End Function
    Public Function DecryptURL(ByVal strUrl As String, ByVal strSessionID As String) As String
        Dim pageEncrypt As String
        pageEncrypt = DecryptSHA(strUrl)
        Return pageEncrypt

    End Function


End Class
