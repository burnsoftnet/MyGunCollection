''' <summary>
''' Export the results from a report to a files in varies formats
''' </summary>
Module ExportModule
    ''' <summary>
    ''' Uses the specified word.
    ''' </summary>
    ''' <param name="word">The word.</param>
    ''' <returns>System.String.</returns>
    Private Function Os(ByVal word As String) As String
        Try
            Dim i As Integer = word.IndexOf(".", StringComparison.Ordinal)
            While i > -1
                word = word.Remove(i, 1)
                i = word.IndexOf(".", StringComparison.Ordinal)
            End While
        Catch ex As Exception
            Dim strform As String = "ExportModule"
            Dim strProcedure As String = "OS"
            'TODO #43 Clean up Code
            'Dim objFs As New MGC.BSFileSystem
            'Dim sMessage As String = strform & "." & strProcedure & "::" & Err.Number & "::" & ex.Message.ToString()
            'objFs.LogFile(MyLogFile, sMessage)
            Call LogError(strform, strProcedure, Err.Number, ex.Message.ToString())
        End Try
        Return word
    End Function
    ''' <summary>
    ''' Exports the excel.
    ''' </summary>
    ''' <param name="table">The table.</param>
    ''' <param name="location">The location.</param>
    Public Sub ExportExcel(ByVal table As DataTable, ByVal location As String)
        Try
            If My.Computer.FileSystem.FileExists(location) Then My.Computer.FileSystem.DeleteFile(location)
' ReSharper disable RedundantAssignment
            Dim createString As String = ""
' ReSharper disable once RedundantAssignment
            Dim columns As String = ""
            Dim mark As String = ""
            Dim myTable As String
            Using connection As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & location & ";Extended Properties=""Excel 8.0;HDR=YES;IMEX=0""")
                connection.Open()
                If Len(table.TableName) = 0 Then
                    myTable = "Table1"
                Else
                    myTable = table.TableName
                End If
                createString = "CREATE TABLE [" & myTable & "] ("
                columns = "("
                mark = "("
                For Each column As DataColumn In table.Columns
                    createString &= Os(Replace(column.ColumnName, " ", ""))
                    Select Case column.DataType.Name
                        Case "SByte", "Byte", "Int16", "Int32", "Int64", "Decimal", "Double", "Single"
                            createString &= " Number, "
                        Case "Boolean"
                            createString &= " Bit, "
                        Case "Char", "String"
                            createString &= " Memo, "
                        Case "DateTime"
                            createString &= " DateTime, "
                        Case Else
                            createString &= " Text, "
                    End Select
                    columns &= Os(column.ColumnName) & ", "
                    mark &= "?,"
                Next
                createString = createString.Remove(createString.Length - 2, 2)
                createString &= ")"
                columns = columns.Remove(columns.Length - 2, 2)
                columns &= ")"
                mark = mark.Remove(mark.Length - 1, 1)
                mark &= ")"
                Using command As New OleDb.OleDbCommand(createString.ToString, connection)
                    command.ExecuteNonQuery()
                End Using
                Using adapter As New OleDb.OleDbDataAdapter("SELECT * FROM [" & myTable & "$]", connection)
                    Using excelDataset As New DataSet
                        adapter.Fill(excelDataset, myTable)
                        Dim mySql As String = "INSERT INTO [" & myTable & "] " & Replace(columns.ToString, " ", "") & " VALUES " & mark.ToString
                        adapter.InsertCommand = New OleDb.OleDbCommand(mySql, connection)
                        Dim colName As String = ""
                        For Each column As DataColumn In table.Columns
                            colName = Replace(column.ColumnName, " ", "")
                            Select Case column.DataType.Name
                                Case "SByte", "Byte", "Int16", "Int32", "Int64", "Decimal", "Double", "Single"
                                    adapter.InsertCommand.Parameters.Add("@" & Os(colName), OleDb.OleDbType.Numeric, 100, Os(colName))
                                Case "Boolean"
                                    adapter.InsertCommand.Parameters.Add("@" & Os(colName), OleDb.OleDbType.Boolean, 100, Os(colName))
                                Case "Char", "String"
                                    adapter.InsertCommand.Parameters.Add("@" & Os(colName), OleDb.OleDbType.Char, 65536, Os(colName))
                                Case "DateTime"
                                    adapter.InsertCommand.Parameters.Add("@" & Os(colName), OleDb.OleDbType.DBTimeStamp, 100, Os(colName))
                                Case Else
                                    adapter.InsertCommand.Parameters.Add("@" & Os(colName), OleDb.OleDbType.Char, 65536, Os(colName))
                            End Select
                        Next
                        For Each row As DataRow In table.Rows
                            If row.RowState <> DataRowState.Deleted Then
                                Dim excelRow As DataRow = excelDataset.Tables(myTable).NewRow
                                For i As Integer = 0 To table.Columns.Count - 1
                                    excelRow.Item(i) = row.Item(i)
                                Next
                                excelDataset.Tables(myTable).Rows.Add(excelRow)
                            End If
                        Next
                        adapter.Update(excelDataset, myTable)
                    End Using
                End Using
            End Using
            MsgBox("The Report was Exported to Excel!")
        Catch ex As Exception
            Dim strform As String = "ExportModule"
            Dim strProcedure As String = "ExportExcel"
            'Dim ObjFS As New BSMyGunCollection.MGC.BSFileSystem
            'Dim sMessage As String = strform & "." & strProcedure & "::" & Err.Number & "::" & ex.Message.ToString()
            'ObjFS.LogFile(MyLogFile, sMessage)
            Call LogError(strform, strProcedure, Err.Number, ex.Message.ToString())
        End Try
    End Sub
    ''' <summary>
    ''' Exports the XML.
    ''' </summary>
    ''' <param name="table">The table.</param>
    ''' <param name="location">The location.</param>
    Public Sub ExportXml(ByVal table As DataTable, ByVal location As String)
        Try
            Using writer As New Xml.XmlTextWriter(location, Text.Encoding.UTF8)
                writer.WriteStartDocument()
                table.WriteXml(writer, XmlWriteMode.WriteSchema)
                writer.WriteEndDocument()
                writer.Close()
            End Using
            MsgBox("The Report was Exported to XML!")
        Catch ex As Exception
            Dim strform As String = "ExportModule"
            Dim strProcedure As String = "ExportXML"
            'Dim ObjFS As New BSMyGunCollection.MGC.BSFileSystem
            'Dim sMessage As String = strform & "." & strProcedure & "::" & Err.Number & "::" & ex.Message.ToString()
            'ObjFS.LogFile(MyLogFile, sMessage)
            Call LogError(strform, strProcedure, Err.Number, ex.Message.ToString())
        End Try
    End Sub
    ''' <summary>
    ''' Exports the HTML.
    ''' </summary>
    ''' <param name="table">The table.</param>
    ''' <param name="location">The location.</param>
    Public Sub ExportHtml(ByVal table As DataTable, ByVal location As String)
        Try
            Using writer As New IO.StreamWriter(location)
                writer.WriteLine("<HTML>")
                writer.WriteLine(" <HEAD>")
                writer.WriteLine("  <meta http-equiv='Content-Type' content='text/html; charset=utf-8'>")
                writer.WriteLine(" </HEAD>")
                writer.WriteLine(" <BODY>")
                writer.WriteLine("<TABLE border='1'>")
                writer.WriteLine(" <TR>")
                For Each column As DataColumn In table.Columns
                    writer.WriteLine("  <TD>" & column.ColumnName & "</td>")
                Next
                writer.WriteLine(" </TR>")
                For Each row As DataRow In table.Rows
                    writer.WriteLine(" <TR>")
                    For Each column As DataColumn In table.Columns
                        writer.WriteLine("  <TD>" & row.Item(column).ToString & "</TD>")
                    Next
                    writer.WriteLine(" </TR>")
                Next
                writer.WriteLine("</TABLE>")
                writer.WriteLine(" </BODY>")
                writer.WriteLine("</HTML>")
            End Using
            MsgBox("The Report was Exported to HTML!")
        Catch ex As Exception
            Dim strform As String = "ExportModule"
            Dim strProcedure As String = "ExportHTML"
            'Dim ObjFS As New BSMyGunCollection.MGC.BSFileSystem
            'Dim sMessage As String = strform & "." & strProcedure & "::" & Err.Number & "::" & ex.Message.ToString()
            'ObjFS.LogFile(MyLogFile, sMessage)
            Call LogError(strform, strProcedure, Err.Number, ex.Message.ToString())
        End Try
    End Sub
    ''' <summary>
    ''' Exports the text.
    ''' </summary>
    ''' <param name="table">The table.</param>
    ''' <param name="location">The location.</param>
    Public Sub ExportText(ByVal table As DataTable, ByVal location As String)
        Try
            Using writer As New IO.StreamWriter(location)
                writer.WriteLine("Executed: " + DateTime.Now.ToString)
                For i As Integer = 0 To 99
                    writer.Write("*")
                Next
                writer.WriteLine("")
                For Each column As DataColumn In table.Columns
                    writer.WriteLine("")
                    writer.WriteLine(column.ColumnName)
                    For i As Integer = 0 To 99
                        writer.Write("-")
                    Next
                    writer.WriteLine("")
                    For Each row As DataRow In table.Rows
                        writer.WriteLine(row(column).ToString)
                    Next
                Next
                For i As Integer = 0 To 99
                    writer.Write("*")
                Next
                writer.Close()
            End Using
            MsgBox("The Report was Exported to Text!")
        Catch ex As Exception
            Dim strform As String = "ExportModule"
            Dim strProcedure As String = "ExportText"
            'Dim ObjFS As New BSMyGunCollection.MGC.BSFileSystem
            'Dim sMessage As String = strform & "." & strProcedure & "::" & Err.Number & "::" & ex.Message.ToString()
            'ObjFS.LogFile(MyLogFile, sMessage)
            Call LogError(strform, strProcedure, Err.Number, ex.Message.ToString())
        End Try
    End Sub
    ''' <summary>
    ''' Exports the CSV.
    ''' </summary>
    ''' <param name="table">The table.</param>
    ''' <param name="location">The location.</param>
    Public Sub ExportCsv(ByVal table As DataTable, ByVal location As String)
        Try
            Using writer As New IO.StreamWriter(location)
                For Each row As DataRow In table.Rows
                    For Each column As DataColumn In table.Columns
                        If row.Item(column).GetType Is GetType(DateTime) Then
                            writer.Write(CType(row.Item(column), DateTime).ToString(My.Computer.Info.InstalledUICulture.DateTimeFormat.SortableDateTimePattern))
                        Else
                            Dim value As String = row.Item(column).ToString
                            If value.Contains(Chr(13)) Then
                                writer.Write(Chr(34) & row.Item(column).ToString & Chr(34))
                            Else
                                writer.Write(row.Item(column).ToString)
                            End If
                        End If
                        If column.Ordinal + 1 < table.Columns.Count Then writer.Write(";")
                    Next
                    writer.WriteLine()
                Next
                writer.Close()
            End Using
            MsgBox("The Report was Exported to CSV!")
        Catch ex As Exception
            Dim strform As String = "ExportModule"
            Dim strProcedure As String = "ExportCSV"
            'Dim ObjFS As New BSMyGunCollection.MGC.BSFileSystem
            'Dim sMessage As String = strform & "." & strProcedure & "::" & Err.Number & "::" & ex.Message.ToString()
            'ObjFS.LogFile(MyLogFile, sMessage)
            Call LogError(strform, strProcedure, Err.Number, ex.Message.ToString())
        End Try
    End Sub
End Module