using System;
using System.Collections.Generic;
using System.Data;
using BurnSoft.Applications.MGC.Types;

// ReSharper disable UnusedMember.Local

namespace BurnSoft.Applications.MGC.Ammo
{
    /// <summary>
    /// Class Inventory contains all the functions used to manage the ammo in the database
    /// </summary>
    public class Inventory
    {
        #region "Exception Error Handling"        
        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MGC.Ammo.Inventory";
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
        /// Updates the qty.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="ammoId">The ammo identifier.</param>
        /// <param name="currentQty">The current qty.</param>
        /// <param name="newQty">The new qty.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool UpdateQty(string databasePath, long ammoId, long currentQty, int newQty, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                long endTotal = currentQty + newQty;
                string sql = $"UPDATE Gun_Collection_Ammo set Qty={endTotal} where id={ammoId}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("UpdateQty", e);
            }
            return bAns;
        }
        /// <summary>
        /// Deletes the specified ammo from the database as well as the audit information
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="ammoId">The ammo identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Delete(string databasePath, long ammoId, out string errOut)
        {
            Audit.Delete(databasePath, ammoId, out errOut);
            string sql = $"Delete from Gun_Collection_Ammo where id={ammoId}";
            return Database.Execute(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="cal">The cal.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;Ammunition&gt;.</returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="Exception"></exception>
        public static List<Ammunition> GetList(string databasePath, string name, string manufacturer, string cal,
            out string errOut)
        {
            List<Ammunition> lst = new List<Ammunition>();
            errOut = @"";
            try
            {
                string sql = $"select * from Gun_Collection_Ammo where name='{name}' and Manufacturer='{manufacturer}' and Cal='{cal}'";
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
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;Ammunition&gt;.</returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="Exception"></exception>
        public static List<Ammunition> GetList(string databasePath, int id, out string errOut)
        {
            List<Ammunition> lst = new List<Ammunition>();
            errOut = @"";
            try
            {
                string sql = $"select * from Gun_Collection_Ammo where id={id}";
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
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;Ammunition&gt;.</returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="Exception"></exception>
        public static List<Ammunition> GetList(string databasePath, out string errOut)
        {
            List<Ammunition> lst = new List<Ammunition>();
            errOut = @"";
            try
            {
                string sql = $"select * from Gun_Collection_Ammo";
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
        /// <returns>List&lt;Ammunition&gt;.</returns>
        private static List<Ammunition> MyList(DataTable dt, out string errOut)
        {
            errOut = @"";
            List<Ammunition> lst = new List<Ammunition>();
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new Ammunition()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Cal = d["cal"].ToString(),
                        Dcal = Convert.ToDouble(d["dcal"]),
                        Grain = d["grain"].ToString(),
                        Jacket = d["jacket"].ToString(),
                        Manufacturer = d["Manufacturer"].ToString(),
                        Name = d["name"].ToString(),
                        Qty = Convert.ToInt32(d["qty"]),
                        Sync_lastupdate = d["Sync_lastupdate"].ToString(),
                        Vel_n = Convert.ToInt32(d["Vel_n"]),
                        Vel_t = d["Vel_t"].ToString()
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
