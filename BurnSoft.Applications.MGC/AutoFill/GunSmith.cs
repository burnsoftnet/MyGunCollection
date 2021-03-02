using System.Windows.Forms;

namespace BurnSoft.Applications.MGC.AutoFill
{
    /// <summary>
    /// Class GunSmith for gun smith auto fill
    /// </summary>
    public class GunSmith
    {
        /// <summary>
        /// Gets the unique name of all the Gunsmiths listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Name(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "gName", "GunSmith_Contact_Details", out errOut);
        }
    }
}
