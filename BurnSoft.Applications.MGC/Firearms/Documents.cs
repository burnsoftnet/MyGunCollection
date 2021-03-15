using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BurnSoft.Applications.MGC.Types;

namespace BurnSoft.Applications.MGC.Firearms
{
    /// <summary>
    /// Class Documents to manage the doucments section, upload, edit assisgn, and delete
    /// </summary>
    public class Documents
    {
        #region "Exception Error Handling"        
        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MGC.Firearms.Documents";
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
        /// Gets the last identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="Exception"></exception>
        public static long GetLastId(string databasePath, out string errOut)
        {
            long lAns = 0;
            errOut = @"";
            try
            {
                string sql = "select top 1 id from Gun_Collection_Docs order by ID DESC";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw  new Exception(errOut);
                List<DocumentList> lst = MyList(dt, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (DocumentList d in lst)
                {
                    lAns = d.Id;
                }

            }
            catch (Exception e)
            {
                errOut = ErrorMessage("", e);
            }

            return lAns;
        }

        /// <summary>
        /// Mies the list.
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;BarrelSystems&gt;.</returns>
        internal static List<DocumentList> MyList(DataTable dt, out string errOut)
        {
            List<DocumentList> lst = new List<DocumentList>();
            errOut = @"";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new DocumentList()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        DocName = d["doc_name"].ToString(),
                        DocDescription = d["doc_description"].ToString(),
                        DocFilename = d["doc_filename"].ToString(),
                        Dta = d["dta"].ToString(),
                        DataFile = d["doc_file"],
                        Length = Convert.ToInt32(d["length"]),
                        DataFileThumb = d["doc_thumb"],
                        DocExt = d["doc_ext"].ToString(),
                        Category = d["doc_cat"].ToString(),
                        SyncLastUpdate = d["sync_lastupdate"].ToString()

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
