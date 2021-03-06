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

        public static List<BarrelSystems> GetAll(string databasePath, out string errOut)
        {
            List<BarrelSystems> lst = new List<BarrelSystems>();
            errOut = @"";
            try
            {
                string sql = $"select * from Gun_Collection";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);

                foreach (DataRow d in  dt.Rows)
                {
                    lst.Add(new BarrelSystems()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        FullName = d["FullName"].ToString(),
                        BarrelLength = d["BarrelLength"].ToString(),
                        Finish = d["Finish"].ToString(),
                        Height = d["Height"].ToString(),
                        Action = d["Action"].ToString(),
                        FeedSystem = d["FeedSystem"].ToString(),
                        Sights = d["Sights"].ToString(),
                        PetLoads = d["PetLoads"].ToString(),
                        PurchasedFrom = d["PurchasedFrom"].ToString(),
                        PurchasedPrice = d["PurchasedPrice"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetAll", e);
            }
            return lst;
        }

        public static List<BarrelSystems> GetList(string databasePath,long id, out string errOut)
        {
            List<BarrelSystems> lst = new List<BarrelSystems>();
            errOut = @"";
            try
            {
                string sql = $"select * from Gun_Collection";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);

                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new BarrelSystems()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        FullName = d["FullName"].ToString(),
                        BarrelLength = d["BarrelLength"].ToString(),
                        Finish = d["Finish"].ToString(),
                        Height = d["Height"].ToString(),
                        Action = d["Action"].ToString(),
                        FeedSystem = d["FeedSystem"].ToString(),
                        Sights = d["Sights"].ToString(),
                        PetLoads = d["PetLoads"].ToString(),
                        PurchasedFrom = d["PurchasedFrom"].ToString(),
                        PurchasedPrice = d["PurchasedPrice"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetAll", e);
            }
            return lst;
        }
    }
}
