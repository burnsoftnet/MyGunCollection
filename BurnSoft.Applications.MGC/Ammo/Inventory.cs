using System;

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
        public static long GetId(string databasePath, )
    }
}
