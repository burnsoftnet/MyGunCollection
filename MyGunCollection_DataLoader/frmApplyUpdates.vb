Imports MyGunCollection_DataLoader.GlobalFunctions
Imports System.Data.Odbc
Imports System.Data
Imports System.IO
Imports System.Xml
Imports System.Diagnostics
Public Class frmApplyUpdates
    'Read the Manufactures XML file and insert it into the database
    Sub GetManu()
        Try
            Dim MyPath As String = APPLICATION_PATH_DATA & "\"
            Dim StrID As String = ""
            Dim SQL As String = ""
            Dim strBrand As String = ""
            Dim MyAppVersion As String = ""
            Dim obj As New MyGlobalFunctions
            Dim ObjDB As New BSDatabase
            Dim doc As New XmlDocument
            doc.Load(MyPath & DL_MANU)
            Dim elemList As XmlNodeList = doc.GetElementsByTagName("Gun_Manufacturer")
            Dim i As Integer
            Dim MaxCount As Long = elemList.Count
            ProgressBar2.Minimum = 0
            ProgressBar2.Maximum = MaxCount
            ProgressBar2.Value = 0
            ProgressBar2.Refresh()
            For i = 0 To MaxCount - 1
                StrID = obj.GetXMLNode(elemList(i).Item("ID"))
                strBrand = obj.GetXMLNode(elemList(i).Item("Brand"))
                If Not obj.ObjectExistsinDB(strBrand, "Brand", "Gun_Manufacturer") Then
                    SQL = "INSERT INTO Gun_Manufacturer(Brand,sync_lastupdate) VALUES('" & strBrand & "',Now())"
                    ObjDB.ConnExec(SQL)
                End If
                lblTXTStatus.Text = "Processing " & i & " out of " & MaxCount & " records."
                lblTXTStatus.Refresh()
                ProgressBar2.Value = i
                ProgressBar2.Refresh()
                Me.Refresh()
            Next i
            doc = Nothing
            elemList = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "GetManu"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Read the Gun Models XML file and insert it into the database
    Sub GetMOD()
        Try
            Dim MyPath As String = APPLICATION_PATH_DATA & "\"
            Dim StrID As String = ""
            Dim SQL As String = ""
            Dim strModel As String = ""
            Dim strBrand As String = ""
            Dim GMID As String = ""
            Dim obj As New MyGlobalFunctions
            Dim ObjDB As New BSDatabase
            Dim doc As New XmlDocument
            doc.Load(MyPath & DL_MOD)
            Dim elemList As XmlNodeList = doc.GetElementsByTagName("Gun_Model")
            Dim i As Long
            Dim o As Long = 100
            Dim MaxCount As Long = elemList.Count
            ProgressBar2.Minimum = 0
            ProgressBar2.Maximum = MaxCount
            ProgressBar2.Value = 0
            ProgressBar2.Refresh()
            For i = 0 To MaxCount - 1
                'System.Windows.Forms.Application.DoEvents()
                'InitializeComponent()
                StrID = obj.GetXMLNode(elemList(i).Item("ID"))
                strModel = obj.GetXMLNode(elemList(i).Item("Model"))
                strBrand = obj.GetXMLNode(elemList(i).Item("Brand"))
                GMID = obj.GetXMLNode(elemList(i).Item("GMID"))
                SQL = "SELECT g.ID, g.GMID,g.Model,gm.Brand from Gun_Model g inner join Gun_Manufacturer gm on gm.id=g.GMID where g.Model='" & strModel & "' and gm.Brand='" & strBrand & "'"
                If Not obj.ObjectExistsinDBSQL(SQL) Then
                    GMID = obj.GetID("SELECT * from Gun_Manufacturer where Brand='" & strBrand & "'")
                    SQL = "INSERT INTO Gun_Model(GMID,Model,sync_lastupdate) VALUES(" & GMID & ",'" & strModel & "',Now())"
                    ObjDB.ConnExec(SQL)
                End If
                lblTXTStatus.Text = "Processing " & i & " out of " & MaxCount & " records."
                lblTXTStatus.Refresh()
                'System.Threading.Thread.Sleep(5000)
                ProgressBar2.Maximum = MaxCount
                ProgressBar2.Value = i
                ProgressBar2.Refresh()
                Me.Refresh()
                System.Windows.Forms.Application.DoEvents()
            Next i
            doc = Nothing
            elemList = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "GetManu"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Read the Ammo XML file and insert it into the database
    Sub GetAmmo()
        Try
            Dim MyPath As String = APPLICATION_PATH_DATA & "\"
            Dim StrID As String = ""
            Dim SQL As String = ""
            Dim strBrand As String = ""
            Dim MyAppVersion As String = ""
            Dim obj As New MyGlobalFunctions
            Dim ObjDB As New BSDatabase
            Dim doc As New XmlDocument
            doc.Load(MyPath & DL_AMMO)
            Dim elemList As XmlNodeList = doc.GetElementsByTagName("Gun_Cal")
            Dim i As Integer
            Dim MaxCount As Long = elemList.Count
            ProgressBar2.Minimum = 0
            ProgressBar2.Maximum = MaxCount
            ProgressBar2.Value = 0
            ProgressBar2.Refresh()
            For i = 0 To MaxCount - 1
                StrID = obj.GetXMLNode(elemList(i).Item("ID"))
                strBrand = obj.GetXMLNode(elemList(i).Item("Cal"))
                If Not obj.ObjectExistsinDB(strBrand, "Cal", "Gun_Cal") Then
                    SQL = "INSERT INTO Gun_Cal(Cal,sync_lastupdate) VALUES('" & strBrand & "',Now())"
                    ObjDB.ConnExec(SQL)
                End If
                lblTXTStatus.Text = "Processing " & i & " out of " & MaxCount & " records."
                lblTXTStatus.Refresh()
                ProgressBar2.Value = i
                ProgressBar2.Refresh()
            Next i
            doc = Nothing
            elemList = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "GetAmmo"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Read the Grip Types XML file and insert it into the database
    Sub GetGripTypes()
        Try
            Dim MyPath As String = APPLICATION_PATH_DATA & "\"
            Dim StrID As String = ""
            Dim SQL As String = ""
            Dim strBrand As String = ""
            Dim MyAppVersion As String = ""
            Dim obj As New MyGlobalFunctions
            Dim ObjDB As New BSDatabase
            Dim doc As New XmlDocument
            doc.Load(MyPath & DL_GRIPS)
            Dim elemList As XmlNodeList = doc.GetElementsByTagName("Gun_GripType")
            Dim i As Integer
            Dim MaxCount As Long = elemList.Count
            ProgressBar2.Minimum = 0
            ProgressBar2.Maximum = MaxCount
            ProgressBar2.Value = 0
            ProgressBar2.Refresh()
            For i = 0 To MaxCount - 1
                StrID = obj.GetXMLNode(elemList(i).Item("ID"))
                strBrand = obj.GetXMLNode(elemList(i).Item("grip"))
                If Not obj.ObjectExistsinDB(strBrand, "grip", "Gun_GripType") Then
                    SQL = "INSERT INTO Gun_GripType(grip,sync_lastupdate) VALUES('" & strBrand & "',Now())"
                    ObjDB.ConnExec(SQL)
                End If
                lblTXTStatus.Text = "Processing " & i & " out of " & MaxCount & " records."
                lblTXTStatus.Refresh()
                ProgressBar2.Value = i
                ProgressBar2.Refresh()
            Next i
            doc = Nothing
            elemList = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "GetGripTypes"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Read the Maintenance Plans XML file and insert it into the database
    Sub GetMaintPlans()
        Try
            Dim MyPath As String = APPLICATION_PATH_DATA & "\"
            Dim StrID As String = ""
            Dim SQL As String = ""
            Dim strName As String = ""
            Dim strOD As String = ""
            Dim strIID As String = ""
            Dim strIIRF As String = ""
            Dim strNotes As String = ""
            Dim MyAppVersion As String = ""
            Dim obj As New MyGlobalFunctions
            Dim ObjDB As New BSDatabase
            Dim doc As New XmlDocument
            doc.Load(MyPath & DL_MAINT)
            Dim elemList As XmlNodeList = doc.GetElementsByTagName("Maintance_Plans")
            Dim i As Integer
            Dim MaxCount As Long = elemList.Count
            ProgressBar2.Minimum = 0
            ProgressBar2.Maximum = MaxCount
            ProgressBar2.Value = 0
            ProgressBar2.Refresh()
            For i = 0 To MaxCount - 1
                StrID = obj.GetXMLNode(elemList(i).Item("ID"))
                strName = FluffContent(obj.GetXMLNode(elemList(i).Item("Name")))
                strOD = FluffContent(obj.GetXMLNode(elemList(i).Item("OD")))
                strIID = FluffContent(obj.GetXMLNode(elemList(i).Item("iid")))
                strIIRF = FluffContent(obj.GetXMLNode(elemList(i).Item("iirf")))
                strNotes = FluffContent(obj.GetXMLNode(elemList(i).Item("Notes")))
                If Not obj.ObjectExistsinDB(strName, "Name", "Maintance_Plans") Then
                    SQL = "INSERT INTO Maintance_Plans(Name,OD,iid,iirf,Notes,sync_lastupdate) VALUES('" & _
                            strName & "','" & strOD & "','" & strIID & "','" & _
                            strIIRF & "','" & strNotes & "',Now())"
                    ObjDB.ConnExec(SQL)
                End If
                lblTXTStatus.Text = "Processing " & i & " out of " & MaxCount & " records."
                lblTXTStatus.Refresh()
                ProgressBar2.Value = i
                ProgressBar2.Refresh()
            Next i
            doc = Nothing
            elemList = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "GetMaintPlans"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Read the Nationalities XML file and insert it into the database
    Sub GetNat()
        Try
            Dim MyPath As String = APPLICATION_PATH_DATA & "\"
            Dim StrID As String = ""
            Dim SQL As String = ""
            Dim strBrand As String = ""
            Dim MyAppVersion As String = ""
            Dim obj As New MyGlobalFunctions
            Dim ObjDB As New BSDatabase
            Dim doc As New XmlDocument
            doc.Load(MyPath & DL_NAT)
            Dim elemList As XmlNodeList = doc.GetElementsByTagName("Gun_Nationality")
            Dim i As Integer
            Dim MaxCount As Long = elemList.Count
            ProgressBar2.Minimum = 0
            ProgressBar2.Maximum = MaxCount
            ProgressBar2.Value = 0
            ProgressBar2.Refresh()
            For i = 0 To MaxCount - 1
                StrID = obj.GetXMLNode(elemList(i).Item("ID"))
                strBrand = obj.GetXMLNode(elemList(i).Item("Country"))
                If Not obj.ObjectExistsinDB(strBrand, "Country", "Gun_Nationality") Then
                    SQL = "INSERT INTO Gun_Nationality(Country,sync_lastupdate) VALUES('" & strBrand & "',Now())"
                    ObjDB.ConnExec(SQL)
                End If
                lblTXTStatus.Text = "Processing " & i & " out of " & MaxCount & " records."
                lblTXTStatus.Refresh()
                ProgressBar2.Value = i
                ProgressBar2.Refresh()
            Next i
            doc = Nothing
            elemList = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "GetNat"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Read the Firearm Types XML file and insert it into the database
    Sub GetFirearmTypes()
        Try
            Dim MyPath As String = APPLICATION_PATH_DATA & "\"
            Dim StrID As String = ""
            Dim SQL As String = ""
            Dim strBrand As String = ""
            Dim MyAppVersion As String = ""
            Dim obj As New MyGlobalFunctions
            Dim ObjDB As New BSDatabase
            Dim doc As New XmlDocument
            doc.Load(MyPath & DL_TYPES)
            Dim elemList As XmlNodeList = doc.GetElementsByTagName("Gun_Type")
            Dim i As Integer
            Dim MaxCount As Long = elemList.Count
            ProgressBar2.Minimum = 0
            ProgressBar2.Maximum = MaxCount
            ProgressBar2.Value = 0
            ProgressBar2.Refresh()
            For i = 0 To MaxCount - 1
                StrID = obj.GetXMLNode(elemList(i).Item("ID"))
                strBrand = obj.GetXMLNode(elemList(i).Item("Type"))
                If Not obj.ObjectExistsinDB(strBrand, "Type", "Gun_Type") Then
                    SQL = "INSERT INTO Gun_Type(Type,sync_lastupdate) VALUES('" & strBrand & "',Now())"
                    ObjDB.ConnExec(SQL)
                End If
                lblTXTStatus.Text = "Processing " & i & " out of " & MaxCount & " records."
                lblTXTStatus.Refresh()
                ProgressBar2.Value = i
                ProgressBar2.Refresh()
            Next i
            doc = Nothing
            elemList = Nothing
        Catch ex As Exception
            Dim sSubFunc As String = "GetFirearmTypes"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Start the insert process and increment the progress bar to show the user the current status
    Sub DoInserts()
        Try
            Timer1.Enabled = False
            Dim i As Integer = 0
            Dim iMax As Integer = 7
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = iMax
            ProgressBar1.Value = 0
            ProgressBar1.Refresh()
            Me.Refresh()
            lblStatusMsg.Text = "Applying Caliber Types"
            lblStatusMsg.Refresh()
            If bAmmo Then Call GetAmmo()
            i = i + 1
            ProgressBar1.Value = i
            ProgressBar1.Refresh()
            Me.Refresh()
            lblStatusMsg.Text = "Applying Grip Type"
            lblStatusMsg.Refresh()
            If bGripType Then Call GetGripTypes()
            i = i + 1
            ProgressBar1.Value = i
            ProgressBar1.Refresh()
            Me.Refresh()
            lblStatusMsg.Text = "Apply Maintanence Plans"
            lblStatusMsg.Refresh()
            If BMaintPlan Then Call GetMaintPlans()
            i = i + 1
            ProgressBar1.Value = i
            ProgressBar1.Refresh()
            Me.Refresh()
            lblStatusMsg.Text = "Apply Nationalities"
            lblStatusMsg.Refresh()
            If BNationality Then Call GetNat()
            i = i + 1
            ProgressBar1.Value = i
            ProgressBar1.Refresh()
            Me.Refresh()
            lblStatusMsg.Text = "Updating Firearm Types"
            lblStatusMsg.Refresh()
            If bType Then Call GetFirearmTypes()
            i = i + 1
            ProgressBar1.Value = i
            ProgressBar1.Refresh()
            Me.Refresh()
            lblStatusMsg.Text = "Updating Manufacturers"
            lblStatusMsg.Refresh()
            If bManufacturer Then Call GetManu()
            i = i + 1
            ProgressBar1.Value = i
            ProgressBar1.Refresh()
            Me.Refresh()
            lblStatusMsg.Text = "Updating Models"
            lblStatusMsg.Refresh()
            If bModel Then Call GetMOD()
            i = i + 1
            ProgressBar1.Value = i
            ProgressBar1.Refresh()
            Me.Refresh()
            lblStatusMsg.Text = ""
            lblStatusMsg.Refresh()
        Catch ex As Exception
            Dim sSubFunc As String = "DoInserts"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    'Start the timer to check the updates of the status
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Cursor = Cursors.WaitCursor
        Call DoInserts()
        Timer1.Enabled = False
        Me.Cursor = Cursors.Arrow
        frmFinish.Show()
        Me.Close()
    End Sub
    'Action for when the applied button is clicked
    Private Sub frmApplyUpdates_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblTitle.Text = Application.ProductName
        Me.Text = Application.ProductName
        Timer1.Enabled = True
    End Sub
End Class