using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BurnSoft.Applications.MGC
{
    public class AutoFillCollections
    {
        #region "Exception Error Handling"        
        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MGC.AutoFillCollections";
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
        /// Mains the collection.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="strColumn">The string column.</param>
        /// <param name="strTable">The string table.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        /// <exception cref="Exception"></exception>
        private static AutoCompleteStringCollection MainCollection(string databasePath, string strColumn, string strTable, out string errOut)
        {
            AutoCompleteStringCollection acscAns = new AutoCompleteStringCollection();
            errOut = @"";
            try
            {
                string sql = $"SELECT {strColumn} from {strTable} order by {strColumn} ASC";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);

                foreach (DataRow d in dt.Rows)
                {
                    if (d[strColumn].ToString() != null)
                    {
                        acscAns.Add(d[strColumn].ToString());
                    }
                }

                if (acscAns.Count == 0) acscAns.Add("N/A");
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("MainCollection", e);
            }

            return acscAns;
        }
        /// <summary>
        /// Guns the manufacturer.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Gun_Manufacturer(string databasePath, out string errOut)
        {
            return MainCollection(databasePath, "Brand", "Gun_Manufacturer", out errOut);
        }

        public static AutoCompleteStringCollection Gun_Cal(string databasePath, out string errOut)
        {
            return MainCollection(databasePath, "Cal", "Gun_Cal", out errOut);
        }

        public static AutoCompleteStringCollection Gun_Nationality(string databasePath, out string errOut)
        {
            return MainCollection(databasePath, "Country", "Gun_Nationality", out errOut);
        }

        public static AutoCompleteStringCollection Gun_Model(string databasePath, out string errOut)
        {
            return MainCollection(databasePath, "Model", "Gun_Model", out errOut);
        }

        public static AutoCompleteStringCollection Gun_Model_ByMan(string databasePath,string strMan, out string errOut)
        {
            return MainCollection(databasePath, "Model", "Gun_Model", out errOut);
        }
    }
}
