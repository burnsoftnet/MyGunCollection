using System.Windows.Forms;

namespace BurnSoft.Applications.MGC.AutoFill
{
    /// <summary>
    /// Class Documents for auto fill functions
    /// </summary>
    public class Documents
    {
        /// <summary>
        /// Documents the category.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Category(string databasePath, out string errOut)
        {
            string sql = $"select distinct(doc_cat) as cat from Gun_Collection_Docs order by doc_cat asc";
            return General.MainCollection(databasePath, "cat", "", out errOut, sql);
        }
    }
}
