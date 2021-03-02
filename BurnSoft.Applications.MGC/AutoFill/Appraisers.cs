using System.Windows.Forms;

namespace BurnSoft.Applications.MGC.AutoFill
{
    /// <summary>
    /// Class for Appraisers autofill.
    /// </summary>
    public class Appraisers
    {
        /// <summary>
        /// Gets the unique names of all the Appraisers listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Name(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "aName", "Appriaser_Contact_Details", out errOut);
        }
    }
}
