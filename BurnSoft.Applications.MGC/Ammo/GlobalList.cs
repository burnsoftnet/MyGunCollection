using System;
using System.Collections.Generic;
using System.Data;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Universal;
// ReSharper disable UnusedMember.Local

namespace BurnSoft.Applications.MGC.Ammo
{
    /// <summary>
    /// Class General functions for ammo handling from the global list gun_cal table
    /// </summary>
    public class GlobalList
    {
        #region "Exception Error Handling"        
        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MGC.Ammo.GlobalList";
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
        /// <summary>
        /// Adds the specified caliber to the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, string name, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                BSOtherObjects obj = new BSOtherObjects();
                name = obj.FC(name);
                string sql = $"INSERT INTO Gun_Cal(Cal,sync_lastupdate) VALUES('{name}',Now())";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Add", e);
            }

            return bAns;
        }
        /// <summary>
        /// Checks that database to see if the specific caliber already exists in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="Exception"></exception>
        public static bool Exists(string databasePath, string name, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                BSOtherObjects obj = new BSOtherObjects();
                name = obj.FC(name);
                string sql = $"Select * from Gun_Cal where Cal='{name}'";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
                bAns = dt.Rows.Count > 0;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Exists", e);
            }

            return bAns;
        }
        /// <summary>
        /// Updates the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath, long id, string name, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                BSOtherObjects obj = new BSOtherObjects();
                name = obj.FC(name);
                string sql = $"UPDATE Gun_Cal set Cal='{name}',sync_lastupdate=Now() where id={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Update", e);
            }

            return bAns;
        }
        /// <summary>
        /// Deletes the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Delete(string databasePath, long id, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                string sql = $"DELETE from Gun_Cal where id={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Deletee", e);
            }

            return bAns;
        }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="databaseName">Name of the database.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="Exception"></exception>
        public static long GetId(string databaseName, string name, out string errOut)
        {
            long lAns = 0;
            errOut = @"";
            try
            {
                BSOtherObjects obj = new BSOtherObjects();
                name = obj.FC(name);
                List<GlobalCaliberList> lst = GetList(databaseName, name, out errOut);
                if (errOut.Length > 0) throw new Exception($"{errOut}");
                foreach (GlobalCaliberList g in lst)
                {
                    lAns = g.Id;
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetId", e);
            }

            return lAns;
        }
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;GlobalCaliberList&gt;.</returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="Exception"></exception>
        public static List<GlobalCaliberList> GetList(string databasePath,  out string errOut)
        {
            List<GlobalCaliberList> lst = new List<GlobalCaliberList>();
            errOut = @"";
            try
            {
                string sql = $"Select * from Gun_Cal";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception($"{errOut}{Environment.NewLine}SQL = {sql}");
                lst = MyList(dt, out errOut);
                if (errOut.Length > 0) throw new Exception($"{errOut}{Environment.NewLine}SQL = {sql}");
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetList", e);
            }
            return lst;
        }
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;GlobalCaliberList&gt;.</returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="Exception"></exception>
        public static List<GlobalCaliberList> GetList(string databasePath, string name, out string errOut)
        {
            List<GlobalCaliberList> lst = new List<GlobalCaliberList>();
            errOut = @"";
            try
            {
                string sql = $"Select * from Gun_Cal where Cal='{name}'";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception($"{errOut}{Environment.NewLine}SQL = {sql}");
                lst = MyList(dt, out errOut);
                if (errOut.Length > 0) throw new Exception($"{errOut}{Environment.NewLine}SQL = {sql}");
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetList", e);
            }
            return lst;
        }
        /// <summary>
        /// Mies the list.
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;GlobalCaliberList&gt;.</returns>
        private static List<GlobalCaliberList> MyList(DataTable dt, out string errOut)
        {
            errOut = @"";
            List<GlobalCaliberList> lst = new List<GlobalCaliberList>();
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new GlobalCaliberList()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Name = d["Cal"].ToString(),
                        SyncLastupdate = d["sync_lastupdate"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("MyList", e);
            }
            return lst;
        }

    }


}
