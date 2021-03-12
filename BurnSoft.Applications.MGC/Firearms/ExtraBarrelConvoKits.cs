using System;
using System.Collections.Generic;
using System.Data;
using BurnSoft.Applications.MGC.Types;

// ReSharper disable UnusedMember.Local

namespace BurnSoft.Applications.MGC.Firearms
{
    /// <summary>
    /// Class ExtraBarrelConvoKits functions to manage the barrels or conversion kits for a firearm.
    /// </summary>
    public class ExtraBarrelConvoKits
    {
        #region "Exception Error Handling"        
        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MGC.Firearms.ExtraBarrelConvoKits";
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
        /// Ges the current barrel detailst list.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;BarrelSystems&gt;.</returns>
        /// <exception cref="Exception"></exception>
        public static List<BarrelSystems> GetCurrentBarrelDetailstList(string databasePath,long id, out string errOut)
        {
            List<BarrelSystems> lst = new List<BarrelSystems>();
            errOut = @"";
            try
            {
                List<GunCollectionList> gunList = MyCollection.GetList(databasePath, id, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);

                foreach (GunCollectionList d in gunList)
                {
                    lst.Add(new BarrelSystems()
                    {
                        Id = d.Id,
                        FullName = d.FullName,
                        BarrelLength = d.BarrelLength,
                        Finish = d.Finish,
                        Height = d.Height,
                        Action = d.Action,
                        FeedSystem = d.FeedSystem,
                        Sights = d.Sights,
                        PetLoads = d.PetLoads,
                        PurchasedFrom = d.PurchaseFrom,
                        PurchasedPrice = d.PurchasePrice,
                    });
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetAll", e);
            }
            return lst;
        }
        /// <summary>
        /// Adds the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="gunId">The gun identifier.</param>
        /// <param name="modelName">Name of the model.</param>
        /// <param name="caliber">The caliber.</param>
        /// <param name="finish">The finish.</param>
        /// <param name="barrelLength">Length of the barrel.</param>
        /// <param name="petLoads">The pet loads.</param>
        /// <param name="action">The action.</param>
        /// <param name="feedSystem">The feed system.</param>
        /// <param name="sights">The sights.</param>
        /// <param name="purchasePrice">The purchase price.</param>
        /// <param name="purchasedFrom">The purchased from.</param>
        /// <param name="height">The height.</param>
        /// <param name="type">The type.</param>
        /// <param name="isDefault">if set to <c>true</c> [is default].</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, long gunId, string modelName, string caliber, string finish,
            string barrelLength, string petLoads, string action, string feedSystem, string sights, string purchasePrice,
            string purchasedFrom, string height, string type, bool isDefault, out string errOut)
        {
            int iDefault = isDefault ? 1 : 0;
            string sql = $"INSERT INTO Gun_Collection_Ext(GID, ModelName, Caliber, Finish, BarrelLength, PetLoads, Action,Feedsystem,Sights,PurchasedPrice,PurchasedFrom,dtp,Height,Type,IsDefault,sync_lastupdate) VALUES(" +
                $"{gunId},'{modelName}',','{caliber}','{finish}','{barrelLength}','{petLoads}','{action}','{feedSystem}','{sights}'," +
                $"'{purchasePrice}','{purchasedFrom}',DATE().'{height}','{type}',{iDefault},Now())";
            return Database.Execute(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Adds the link.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="barrelId">The barrel identifier.</param>
        /// <param name="gunId">The gun identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool AddLink(string databasePath, long barrelId, long gunId, out string errOut)
        {
            string sql = $"INSERT INTO Gun_Collection_Ext_Links(BSID,GID,sync_lastupdate) VALUES({barrelId},{gunId},Now())";
            return Database.Execute(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the barrel identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="gunId">The gun identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <param name="useDefault">if set to <c>true</c> [use default].</param>
        /// <param name="barrelId">The barrel identifier.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="Exception"></exception>
        public static long GetBarrelId(string databasePath, long gunId, out string errOut, bool useDefault = false,
            long barrelId = 0)
        {
            long lAns = 0;
            errOut = @"";
            try
            {
                int lDefault = useDefault ? 1 : 0;
                string sql = $"SELECT TOP 1 * from Gun_Collection_Ext where GID={gunId} and IsDefault={lDefault}";
                if (barrelId > 0) sql += $" and id={barrelId}";
                List<BarrelSystems> lst = GetList(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
                foreach (BarrelSystems b in lst)
                {
                    lAns = b.Id;
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetBarrelId", e);
            }
            return lAns;
        }
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="barrelId">The barrel identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;BarrelSystems&gt;.</returns>
        /// <exception cref="Exception"></exception>
        public static List<BarrelSystems> GetList(string databasePath, long barrelId, out string errOut)
        {
            List<BarrelSystems> lst = new List<BarrelSystems>();
            errOut = @"";
            try
            {
                string sql = $"select * from Gun_Collection_Ext where id={barrelId}";
                lst = GetList(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
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
        /// <returns>List&lt;BarrelSystems&gt;.</returns>
        /// <exception cref="Exception"></exception>
        public static List<BarrelSystems> GetList(string databasePath, out string errOut)
        {
            List<BarrelSystems> lst = new List<BarrelSystems>();
            errOut = @"";
            try
            {
                string sql = $"select * from Gun_Collection_Ext";
                lst = GetList(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
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
        /// <param name="sql">The SQL.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;BarrelSystems&gt;.</returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="Exception"></exception>
        internal static List<BarrelSystems> GetList(string databasePath, string sql, out string errOut)
        {
            List<BarrelSystems> lst = new List<BarrelSystems>();
            errOut = @"";
            try
            {
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
                lst = MyList(dt, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
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
        /// <returns>List&lt;BarrelSystems&gt;.</returns>
        internal static List<BarrelSystems> MyList(DataTable dt, out string errOut)
        {
            List<BarrelSystems> lst = new List<BarrelSystems>();
            errOut = @"";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    string fullName = @"";
                    try
                    {
                        fullName = d["FullName"].ToString();
                    }
                    catch
                    {

                    }
                    lst.Add(new BarrelSystems()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        GunId = Convert.ToInt32(d["gid"]),
                        IsDefault = Convert.ToInt32(d["IsDefault"]) == 1,
                        FullName = fullName,
                        ModelName = d["ModelName"].ToString(),
                        Caliber = d["Caliber"].ToString(),
                        PetLoads = d["PetLoads"].ToString(),
                        Finish = d["Finish"].ToString(),
                        FeedSystem = d["FeedSystem"].ToString(),
                        BarrelLength = d["BarrelLength"].ToString(),
                        Height = d["Height"].ToString(),
                        Action = d["Action"].ToString(),
                        Sights = d["Sights"].ToString(),
                        LastUpdated = d["sync_lastupdate"].ToString()

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
