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
    public class Inventory : IDisposable
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
        /// Adds the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="cal">The cal.</param>
        /// <param name="grain">The grain.</param>
        /// <param name="jacket">The jacket.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="dcal">The dcal.</param>
        /// <param name="velocityNumber">The velocity number.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, string manufacturer, string name, string cal, string grain, string jacket, long qty, double dcal, long velocityNumber , out string errOut)
        {
            string sql = $"INSERT INTO Gun_Collection_Ammo(Manufacturer,Name,Cal,Grain,Jacket,Qty,dcal,vel_n,sync_lastupdate) VALUES('{manufacturer}','{name}','{cal}','{grain}','{jacket}',{qty},{dcal},{velocityNumber},Now())";
            return Database.Execute(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="cal">The cal.</param>
        /// <param name="grain">The grain.</param>
        /// <param name="jacket">The jacket.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="dcal">The dcal.</param>
        /// <param name="velocityNumber">The velocity number.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        public static long GetId(string databasePath, string manufacturer, string name, string cal, string grain, string jacket, long qty, double dcal, long velocityNumber,out string errOut)
        {
            long lAns = 0;
            errOut = @"";
            try
            {
                string sql = $"SELECT Top 1 * from Gun_Collection_Ammo where Manufacturer='{manufacturer}' and Name='{name}' and Cal='{cal}' and Grain='{grain}' and Jacket='{jacket}' and Qty={qty} and dcal={dcal} and vel_n={velocityNumber} order by ID DESC";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                List<Ammunition> lst = MyList(dt, out errOut);
                foreach (Ammunition a in lst)
                {
                    lAns = a.Id;
                }

            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetId", e);
            }
            return lAns;
        }
        /// <summary>
        /// Gets the qty.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        public static long GetQty(string databasePath, long id, out string errOut)
        {
            long lAns = 0;
            errOut = @"";
            try
            {
                string sql = $"SELECT * from Gun_Collection_Ammo where id={id}";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                List<Ammunition> lst = MyList(dt, out errOut);
                foreach (Ammunition a in lst)
                {
                    lAns = a.Qty;
                }

            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetQty", e);
            }
            return lAns;
        }
        /// <summary>
        /// Updates the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="cal">The cal.</param>
        /// <param name="grain">The grain.</param>
        /// <param name="jacket">The jacket.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="dcal">The dcal.</param>
        /// <param name="velocityNumber">The velocity number.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath,long id, string manufacturer, string name, string cal, string grain, string jacket, long qty, double dcal, long velocityNumber, out string errOut)
        {
            string sql = $"UPDATE Gun_Collection_Ammo set Manufacturer='{manufacturer}', Name='{name}', Cal='{cal}', Grain='{grain}', Jacket='{jacket}', Qty={qty}, dcal={dcal}, vel_n={velocityNumber}, sync_lastupdate=Now() where id={id}";
            return Database.Execute(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Existses the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="cal">The cal.</param>
        /// <param name="grain">The grain.</param>
        /// <param name="jacket">The jacket.</param>
        /// <param name="dcal">The dcal.</param>
        /// <param name="velocityNumber">The velocity number.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Exists(string databasePath,  string manufacturer, string name, string cal, string grain, string jacket, double dcal, long velocityNumber, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                string sql = $"SELECT Top 1 * from Gun_Collection_Ammo where Manufacturer='{manufacturer}' and Name='{name}' and Cal='{cal}' and Grain='{grain}' and Jacket='{jacket}' and dcal={dcal} and vel_n={velocityNumber}";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                List<Ammunition> lst = MyList(dt, out errOut);
                bAns = lst.Count > 0;

            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Exists", e);
            }
            return bAns;
        }

        /// <summary>
        /// Gets the last ammo identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        public static long GetLastAmmoId(string databasePath, out string errOut)
        {
            long lAns = 0;
            errOut = @"";
            try
            {
                string sql = $"SELECT Top 1 * from Gun_Collection_Ammo order by id desc";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                List<Ammunition> lst = MyList(dt, out errOut);
                foreach (Ammunition a in lst)
                {
                    lAns = a.Id;
                }

            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetLastAmmoId", e);
            }
            return lAns;
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
        public static List<Ammunition> GetList(string databasePath, long id, out string errOut)
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
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
        }
    }
}
