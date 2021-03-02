using System;
using System.Windows.Forms;
// ReSharper disable UnusedMember.Local

namespace BurnSoft.Applications.MGC.AutoFill
{
    /// <summary>
    /// Class Gun for auto fill
    /// </summary>
    public class Gun
    {
        #region "Exception Error Handling"        
        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MGC.AutoFill.Gun";
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
        /// Guns the manufacturer.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Manufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Brand", "Gun_Manufacturer", out errOut);
        }
        /// <summary>
        /// Guns the cal.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Cal(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Cal", "Gun_Cal", out errOut);
        }
        /// <summary>
        /// Guns the nationality.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Nationality(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Country", "Gun_Nationality", out errOut);
        }
        /// <summary>
        /// Guns the model.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Model(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Model", "Gun_Model", out errOut);
        }
        /// <summary>
        /// Guns the model by man.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="strMan">The string man.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        /// <exception cref="Exception"></exception>
        public static AutoCompleteStringCollection ModelByManufacturer(string databasePath, string strMan, out string errOut)
        {
            AutoCompleteStringCollection iCol = new AutoCompleteStringCollection();
            errOut = @"";
            try
            {
                long id = Firearms.Manufacturers.GetId(databasePath, strMan, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                string sql = $"SELECT Model from Gun_Model where GMID={id} order by Model ASC";
                iCol = General.MainCollection(databasePath, "Model", "", out errOut, sql);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Gun_Model_ByMan", e);
            }

            return iCol;
        }
        
        /// <summary>
        /// Guns the type of the grip.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection GripType(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "grip", "Gun_GripType", out errOut);
        }
        /// <summary>
        /// Guns the shop details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection ShopDetails(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Name", "Gun_Shop_Details", out errOut);
        }
        /// <summary>
        /// Guns the type.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Type(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Type", "Gun_Type", out errOut);
        }
    }
}
