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
        public static List<BarrelSystems> GeCurrentBarrelDetailstList(string databasePath,long id, out string errOut)
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
    }
}
