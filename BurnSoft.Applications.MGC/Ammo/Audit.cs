using System;
// ReSharper disable UnusedMember.Local
// ReSharper disable ConditionIsAlwaysTrueOrFalse


namespace BurnSoft.Applications.MGC.Ammo
{
    /// <summary>
    /// Class Audit that contains the functions for the ammo audit section
    /// </summary>
    public class Audit
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MGC.Ammo.Audit";

        /// <summary>
        /// Errors the message for regular Exceptions
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, Exception e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message for access violations
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, AccessViolationException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message for invalid cast exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, InvalidCastException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message argument exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message for argument null exception.
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentNullException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        #endregion

        /// <summary>
        /// Adds the specified ammo to the audit table
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="ammoId">The ammo identifier.</param>
        /// <param name="datePurchased">The date purchased.</param>
        /// <param name="currentQty"></param>
        /// <param name="qty">The qty.</param>
        /// <param name="price">The price.</param>
        /// <param name="store">The store.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, long ammoId, string datePurchased, long currentQty,  int qty, double price,
            string store,
            out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                if (!Inventory.UpdateQty(databasePath, ammoId, currentQty,qty, out errOut)) throw new Exception(errOut);

                double pricePerBullet = Math.Truncate(price / qty);
                string sql =
                    $"INSERT INTO Gun_Collection_Ammo_PriceAudit (AID,DTA,Qty,PricePaid,PPB,store,sync_lastupdate) VALUES(" +
                    $"{ammoId},'{datePurchased}',{qty},{price},{pricePerBullet},'{store}',Now())";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Add", e);
            }

            return bAns;
        }

        /// <summary>
        /// Adds the specified ammo to the audit table, over ride if you bought more than one box
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="ammoId">The ammo identifier.</param>
        /// <param name="datePurchased">The date purchased.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="price">The price.</param>
        /// <param name="store">The store.</param>
        /// <param name="numberOfBoxes">The number of boxes.</param>
        /// <param name="currentQty"></param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="Exception"></exception>
        public static bool Add(string databasePath, long ammoId, string datePurchased, int qty, double price, string store,int numberOfBoxes,long currentQty, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                if (numberOfBoxes == 1)
                {
                    bAns = Add(databasePath, ammoId, datePurchased,currentQty, qty, price, store, out errOut);
                    if (errOut?.Length > 0) throw new Exception(errOut);
                }
                else if (numberOfBoxes > 1)
                {
                    for (int i = 1; i > numberOfBoxes; i++)
                    {
                        bAns = Add(databasePath, ammoId, datePurchased,currentQty, qty, price, store, out errOut);
                        currentQty += qty;
                        if (errOut?.Length > 0) throw new Exception(errOut);
                    }
                }
            }
            catch

                (Exception e)
            {
                errOut = ErrorMessage("Add", e);
            }

            return bAns;
        }
    }
}
