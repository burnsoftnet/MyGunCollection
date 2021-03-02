using System.Windows.Forms;

namespace BurnSoft.Applications.MGC.AutoFill
{
    /// <summary>
    /// Class Ammo Auto fill functions
    /// </summary>
    public class Ammo
    {
        /// <summary>
        /// Ammoes the manufacturer.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Manufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "Gun_Collection_Ammo", out errOut);
        }
        /// <summary>
        /// Names the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Name(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Name", "Gun_Collection_Ammo", out errOut);
        }
        /// <summary>
        /// Calibers the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Caliber(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Cal", "Gun_Collection_Ammo", out errOut);
        }
        /// <summary>
        /// Ammoes the grain.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Grain(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Grain", "Gun_Collection_Ammo", out errOut);
        }
        /// <summary>
        /// Ammoes the jacket.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Jacket(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Jacket", "Gun_Collection_Ammo", out errOut);
        }
    }
}
