using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Odbc;
// ReSharper disable UnusedMember.Local

namespace BurnSoft.Applications.MGC
{
    public class Database
    {

        #region "Exception Error Handling"        
        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MGC.Database";
        /// <summary>
        /// Errors the message for regular Exceptions
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, Exception e) => $"{ClassLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message for access violations
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, AccessViolationException e) => $"{ClassLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message for invalid cast exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, InvalidCastException e) => $"{ClassLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message argument exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentException e) => $"{ClassLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message for argument null exception.
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentNullException e) => $"{ClassLocation}.{functionName} - {e.Message}";
        #endregion
        //End Snippet
        private OdbcConnection _conn;
        #region "Connection Strings"

        /// <summary>
        /// Connection String Format Used to Connect to MS Access Databases using the Microsoft Access Driver
        /// </summary>
        /// <param name="databasePath"></param>
        /// <param name="databaseName"></param>
        /// <param name="errOut"></param>
        /// <param name="password"></param>
        /// <returns>string</returns>
        /// <example>
        /// SEE UNIT TEST @ UnitTest_MSAccess <br/>
        /// <br/>
        /// string value = MSAccessDatabase.ConnectionString("C:\\test", "test.mdb", out errOut);
        /// <br/>
        /// <b>Results</b><br/>
        /// Driver={Microsoft Access Driver (*.mdb)};dbq=C:\test\test.mdb
        /// </example>
        public static string ConnectionString(string databasePath, string databaseName, out string errOut, string password = "14un0t2n0")
        {
            string sAns = "";
            errOut = @"";
            try
            {
                sAns = password?.Length > 0 ? $"Driver={{Microsoft Access Driver (*.mdb)}};dbq={databasePath}\\{databaseName};Pwd={password}" : $"Driver={{Microsoft Access Driver (*.mdb)}};dbq={databasePath}\\{databaseName}";
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("ConnectionString", e);
            }
            return sAns;
        }
        /// <summary>
        /// Connections the string.
        /// </summary>
        /// <param name="fullDatabasePath">The full database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <param name="password">The password.</param>
        /// <returns>System.String.</returns>
        public static string ConnectionString(string fullDatabasePath, out string errOut, string password = "")
        {
            string sAns = "";
            errOut = @"";
            try
            {
                sAns = password?.Length > 0 ? $"Driver={{Microsoft Access Driver (*.mdb)}};dbq={fullDatabasePath};Pwd={password}" : $"Driver={{Microsoft Access Driver (*.mdb)}};dbq={fullDatabasePath}";
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("ConnectionString", e);
            }
            return sAns;
        }

        /// <summary>
        /// Connections to the MS Access Database using the string OLE.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="databaseName">Name of the database.</param>
        /// <param name="errOut"></param>
        /// <param name="password">The password.</param>
        /// <returns>System.String.</returns>
        /// <example>
        /// SEE UNIT TEST @ UnitTest_MSAccess <br/>
        /// <br/>
        /// string value = MSAccessDatabase.ConnectionStringOLE("C:\\test", "test.mdb", out errOut);<br/>
        /// <br/>
        /// <b>Results</b><br/>
        /// Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source="C:\test\test.mdb";
        /// </example>
        public static string ConnectionStringOle(string databasePath, string databaseName, out string errOut, string password = "")
        {
            string sAns = "";
            errOut = @"";
            try
            {
                sAns = password?.Length > 0 ? $"Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=\"{databasePath}\\{databaseName}\";Jet OLEDB:Database Password={password};" : $"Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=\"{databasePath}\\{databaseName}\";";
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("ConnectionString", e);
            }
            return sAns;
        }
        #endregion
        #region "Base Database Commands"
        /// <summary>
        /// Connects the database using the connection string.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <example>
        /// SEE UNIT TEST @ UnitTest_MSAccess <br/>
        /// <br/>
        /// MSAccessDatabase obj = new MSAccessDatabase(); <br/>
        /// bool value = obj.ConnectDB(ConnString, out errOut); <br/>
        /// obj.Close(out errOut); <br/>
        /// </example>
        public bool ConnectDb(string connectionString, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                _conn = new OdbcConnection(connectionString);
                _conn.Open();
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("ConnectDB", e);
            }
            return bAns;
        }
        /// <summary>
        /// Closes the specified error MSG.
        /// </summary>
        /// <param name="errMsg">The error MSG.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <example>
        /// SEE UNIT TEST @ UnitTest_MSAccess <br/>
        /// <br/>
        /// MSAccessDatabase obj = new MSAccessDatabase(); <br/>
        /// obj.Close(out errOut); <br/>
        /// </example>
        public bool Close(out string errMsg)
        {
            bool bAns = false;
            errMsg = @"";
            try
            {
                if (_conn.State != ConnectionState.Closed)
                {
                    _conn.Close();
                }
                _conn = null;
                bAns = true;
            }
            catch (Exception e)
            {
                errMsg = ErrorMessage("CloseDB", e);
            }
            return bAns;
        }
        /// <summary>
        /// Connect to the database and execute the SQL statement that you passed.
        /// In this function, we set the connection object null instead of using the Close Function
        /// because you might be using that object for something else, and this will take out the connection
        /// from right under neath you, so we just set that to null instead of a hard close.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="sql">The SQL.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        /// <example>
        /// SEE UNIT TEST @ UnitTest_MSAccess <br/>
        /// <br/>
        /// string SQL = "INSERT INTO Gun_Cal(Cal) VALUES('TEST');"; <br/>
        /// MSAccessDatabase obj = new MSAccessDatabase(); <br/>
        /// bool value = obj.ConnExec(ConnString, SQL, out errOut); <br/>
        /// </example>
        public bool ConnExec(string connectionString, string sql, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                if (ConnectDb(connectionString, out errOut))
                {
                    OdbcCommand cmd = new OdbcCommand(sql, _conn);
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    _conn = null;
                    bAns = true;
                }
                else
                {
                    throw new Exception(errOut);
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("ConnExec", e);
            }
            return bAns;
        }
        /// <summary>
        /// Executes the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="sql">The SQL.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Execute(string databasePath, string sql, out string errOut)
        {
            string con = ConnectionString(databasePath, out errOut);
            Database obj = new Database();
            return obj.ConnExec(con, sql, out errOut);
        }
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="sql">The SQL.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>DataTable.</returns>
        /// <exception cref="Exception"></exception>
        /// <example>
        /// SEE UNIT TEST @ UnitTest_MSAccess <br/>
        /// <br/>
        ///  String SQL = "Select * from Gun_Cal"; <br/>
        /// MSAccessDatabase obj = new MSAccessDatabase(); <br/>
        /// DataTable table = obj.GetData(ConnString, SQL, out errOut); <br/>
        /// string TestValue = @""; <br/>
        ///    foreach(DataRow row in table.Rows) <br/>
        ///    { <br/>
        ///        TestValue += String.Format("{0}{1}",row["Cal"].ToString(),Environment.NewLine); <br/>
        ///    } <br/>
        /// </example>
        public DataTable GetData(string connectionString, string sql, out string errOut)
        {
            DataTable table = new DataTable();
            errOut = @"";
            try
            {
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                if (ConnectDb(connectionString, out errOut))
                {
                    OdbcCommand cmd = new OdbcCommand(sql, _conn);
                    OdbcDataAdapter rs = new OdbcDataAdapter { SelectCommand = cmd };
                    rs.Fill(table);
                }
                else
                {
                    throw new Exception(errOut);
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetData", e);
            }
            return table;
        }
        /// <summary>
        /// Gets the data from table.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="sql">The SQL.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>DataTable.</returns>
        public static DataTable GetDataFromTable(string databasePath, string sql, out string errOut)
        {
            string con = ConnectionString(databasePath, out errOut);
            Database obj = new Database();
            return obj.GetData(con, sql, out errOut);
        }
        #endregion
        #region "Gun Collection Related"        
        /// <summary>
        /// Updates the synchronize data tables.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="table">The table.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="Exception"></exception>
        public bool UpdateSyncDataTables(string databasePath, string table, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                string sql = $"UPDATE {table} set sync_lastupdate = Now()";
                bAns = ConnExec(ConnectionString(databasePath, out errOut), sql, out errOut);
                if (errOut?.Length >0) throw new Exception(errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("UpdateSyncDataTables", e);
            }
            return bAns;
        }
        /// <summary>
        /// Inserts the new contact.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="sValue">The s value.</param>
        /// <param name="sTable">The s table.</param>
        /// <param name="sColumn">The s column.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="Exception"></exception>
        public bool InsertNewContact(string databasePath, string sValue, string sTable, string sColumn, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                string sql = $"INSERT INTO {sTable}({sColumn},Address1,City,State,Zip,sync_lastupdate) VALUES('{sValue}','N/A','N/A','N/A','N/A',Now())";
                bAns = ConnExec(ConnectionString(databasePath, out errOut), sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("InsertNewContact", e);
            }
            return bAns;
        }

        #endregion
    }
}
