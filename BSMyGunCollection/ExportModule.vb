Module ExportModule

    Private Function OS(ByVal Word As String) As String
        Try
            Dim i As Integer = Word.IndexOf(".")
            While i > -1
                Word = Word.Remove(i, 1)
                i = Word.IndexOf(".")
            End While
        Catch ex As Exception
            Dim strform As String = "ExportModule"
            Dim strProcedure As String = "OS"
            Dim ObjFS As New BSMyGunCollection.MGC.BSFileSystem
            Dim sMessage As String = strform & "." & strProcedure & "::" & Err.Number & "::" & ex.Message.ToString()
            ObjFS.LogFile(MyLogFile, sMessage)
        End Try
        Return Word
    End Function

    Public Sub ExportExcel(ByVal Table As DataTable, ByVal Location As String)
        Try
            If My.Computer.FileSystem.FileExists(Location) Then My.Computer.FileSystem.DeleteFile(Location)
            Dim CreateString As String = ""
            Dim Columns As String = ""
            Dim Mark As String = ""
            Dim MyTable As String
            Using Connection As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Location & ";Extended Properties=""Excel 8.0;HDR=YES;IMEX=0""")
                Connection.Open()
                If Len(Table.TableName) = 0 Then
                    MyTable = "Table1"
                Else
                    MyTable = Table.TableName
                End If
                CreateString = "CREATE TABLE [" & MyTable & "] ("
                Columns = "("
                Mark = "("
                For Each Column As DataColumn In Table.Columns
                    CreateString &= OS(Replace(Column.ColumnName, " ", ""))
                    Select Case Column.DataType.Name
                        Case "SByte", "Byte", "Int16", "Int32", "Int64", "Decimal", "Double", "Single"
                            CreateString &= " Number, "
                        Case "Boolean"
                            CreateString &= " Bit, "
                        Case "Char", "String"
                            CreateString &= " Memo, "
                        Case "DateTime"
                            CreateString &= " DateTime, "
                        Case Else
                            CreateString &= " Text, "
                    End Select
                    Columns &= OS(Column.ColumnName) & ", "
                    Mark &= "?,"
                Next
                CreateString = CreateString.Remove(CreateString.Length - 2, 2)
                CreateString &= ")"
                Columns = Columns.Remove(Columns.Length - 2, 2)
                Columns &= ")"
                Mark = Mark.Remove(Mark.Length - 1, 1)
                Mark &= ")"
                Using Command As New OleDb.OleDbCommand(CreateString.ToString, Connection)
                    Command.ExecuteNonQuery()
                End Using
                Using Adapter As New OleDb.OleDbDataAdapter("SELECT * FROM [" & MyTable & "$]", Connection)
                    Using ExcelDataset As New DataSet
                        Adapter.Fill(ExcelDataset, MyTable)
                        Dim MySQL As String = "INSERT INTO [" & MyTable & "] " & Replace(Columns.ToString, " ", "") & " VALUES " & Mark.ToString
                        Adapter.InsertCommand = New OleDb.OleDbCommand(MySQL, Connection)
                        Dim ColName As String = ""
                        For Each Column As DataColumn In Table.Columns
                            ColName = Replace(Column.ColumnName, " ", "")
                            Select Case Column.DataType.Name
                                Case "SByte", "Byte", "Int16", "Int32", "Int64", "Decimal", "Double", "Single"
                                    Adapter.InsertCommand.Parameters.Add("@" & OS(ColName), OleDb.OleDbType.Numeric, 100, OS(ColName))
                                Case "Boolean"
                                    Adapter.InsertCommand.Parameters.Add("@" & OS(ColName), OleDb.OleDbType.Boolean, 100, OS(ColName))
                                Case "Char", "String"
                                    Adapter.InsertCommand.Parameters.Add("@" & OS(ColName), OleDb.OleDbType.Char, 65536, OS(ColName))
                                Case "DateTime"
                                    Adapter.InsertCommand.Parameters.Add("@" & OS(ColName), OleDb.OleDbType.DBTimeStamp, 100, OS(ColName))
                                Case Else
                                    Adapter.InsertCommand.Parameters.Add("@" & OS(ColName), OleDb.OleDbType.Char, 65536, OS(ColName))
                            End Select
                        Next
                        For Each Row As DataRow In Table.Rows
                            If Row.RowState <> DataRowState.Deleted Then
                                Dim ExcelRow As DataRow = ExcelDataset.Tables(MyTable).NewRow
                                For i As Integer = 0 To Table.Columns.Count - 1
                                    ExcelRow.Item(i) = Row.Item(i)
                                Next
                                ExcelDataset.Tables(MyTable).Rows.Add(ExcelRow)
                            End If
                        Next
                        Adapter.Update(ExcelDataset, MyTable)
                    End Using
                End Using
            End Using
            MsgBox("The Report was Exported to Excel!")
        Catch ex As Exception
            Dim strform As String = "ExportModule"
            Dim strProcedure As String = "ExportExcel"
            Dim ObjFS As New BSMyGunCollection.MGC.BSFileSystem
            Dim sMessage As String = strform & "." & strProcedure & "::" & Err.Number & "::" & ex.Message.ToString()
            ObjFS.LogFile(MyLogFile, sMessage)
        End Try
    End Sub

    Public Sub ExportXML(ByVal Table As DataTable, ByVal Location As String)
        Try
            Using Writer As New System.Xml.XmlTextWriter(Location, System.Text.Encoding.UTF8)
                Writer.WriteStartDocument()
                Table.WriteXml(Writer, XmlWriteMode.WriteSchema)
                Writer.WriteEndDocument()
                Writer.Close()
            End Using
            MsgBox("The Report was Exported to XML!")
        Catch ex As Exception
            Dim strform As String = "ExportModule"
            Dim strProcedure As String = "ExportXML"
            Dim ObjFS As New BSMyGunCollection.MGC.BSFileSystem
            Dim sMessage As String = strform & "." & strProcedure & "::" & Err.Number & "::" & ex.Message.ToString()
            ObjFS.LogFile(MyLogFile, sMessage)
        End Try
    End Sub

    Public Sub ExportHTML(ByVal Table As DataTable, ByVal Location As String)
        Try
            Using Writer As New System.IO.StreamWriter(Location)
                Writer.WriteLine("<HTML>")
                Writer.WriteLine(" <HEAD>")
                Writer.WriteLine("  <meta http-equiv='Content-Type' content='text/html; charset=utf-8'>")
                Writer.WriteLine(" </HEAD>")
                Writer.WriteLine(" <BODY>")
                Writer.WriteLine("<TABLE border='1'>")
                Writer.WriteLine(" <TR>")
                For Each Column As DataColumn In Table.Columns
                    Writer.WriteLine("  <TD>" & Column.ColumnName & "</td>")
                Next
                Writer.WriteLine(" </TR>")
                For Each Row As DataRow In Table.Rows
                    Writer.WriteLine(" <TR>")
                    For Each Column As DataColumn In Table.Columns
                        Writer.WriteLine("  <TD>" & Row.Item(Column).ToString & "</TD>")
                    Next
                    Writer.WriteLine(" </TR>")
                Next
                Writer.WriteLine("</TABLE>")
                Writer.WriteLine(" </BODY>")
                Writer.WriteLine("</HTML>")
            End Using
            MsgBox("The Report was Exported to HTML!")
        Catch ex As Exception
            Dim strform As String = "ExportModule"
            Dim strProcedure As String = "ExportHTML"
            Dim ObjFS As New BSMyGunCollection.MGC.BSFileSystem
            Dim sMessage As String = strform & "." & strProcedure & "::" & Err.Number & "::" & ex.Message.ToString()
            ObjFS.LogFile(MyLogFile, sMessage)
        End Try
    End Sub

    Public Sub ExportText(ByVal Table As DataTable, ByVal Location As String)
        Try
            Using Writer As New System.IO.StreamWriter(Location)
                Writer.WriteLine("Executed: " + DateTime.Now.ToString)
                For i As Integer = 0 To 99
                    Writer.Write("*")
                Next
                Writer.WriteLine("")
                For Each Column As DataColumn In Table.Columns
                    Writer.WriteLine("")
                    Writer.WriteLine(Column.ColumnName)
                    For i As Integer = 0 To 99
                        Writer.Write("-")
                    Next
                    Writer.WriteLine("")
                    For Each Row As DataRow In Table.Rows
                        Writer.WriteLine(Row(Column).ToString)
                    Next
                Next
                For i As Integer = 0 To 99
                    Writer.Write("*")
                Next
                Writer.Close()
            End Using
            MsgBox("The Report was Exported to Text!")
        Catch ex As Exception
            Dim strform As String = "ExportModule"
            Dim strProcedure As String = "ExportText"
            Dim ObjFS As New BSMyGunCollection.MGC.BSFileSystem
            Dim sMessage As String = strform & "." & strProcedure & "::" & Err.Number & "::" & ex.Message.ToString()
            ObjFS.LogFile(MyLogFile, sMessage)
        End Try
    End Sub

    Public Sub ExportCSV(ByVal Table As DataTable, ByVal Location As String)
        Try
            Using Writer As New System.IO.StreamWriter(Location)
                For Each Row As DataRow In Table.Rows
                    For Each Column As DataColumn In Table.Columns
                        If Row.Item(Column).GetType Is GetType(DateTime) Then
                            Writer.Write(CType(Row.Item(Column), DateTime).ToString(My.Computer.Info.InstalledUICulture.DateTimeFormat.SortableDateTimePattern))
                        Else
                            Dim Value As String = Row.Item(Column).ToString
                            If Value.Contains(Chr(13)) Then
                                Writer.Write(Chr(34) & Row.Item(Column).ToString & Chr(34))
                            Else
                                Writer.Write(Row.Item(Column).ToString)
                            End If
                        End If
                        If Column.Ordinal + 1 < Table.Columns.Count Then Writer.Write(";")
                    Next
                    Writer.WriteLine()
                Next
                Writer.Close()
            End Using
            MsgBox("The Report was Exported to CSV!")
        Catch ex As Exception
            Dim strform As String = "ExportModule"
            Dim strProcedure As String = "ExportCSV"
            Dim ObjFS As New BSMyGunCollection.MGC.BSFileSystem
            Dim sMessage As String = strform & "." & strProcedure & "::" & Err.Number & "::" & ex.Message.ToString()
            ObjFS.LogFile(MyLogFile, sMessage)
        End Try
    End Sub
End Module