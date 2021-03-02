using System.Windows.Forms;

namespace BurnSoft.Applications.MGC.AutoFill
{
    /// <summary>
    /// Class GunCollection for auto fill
    /// </summary>
    public class GunCollection
    {
        /// <summary>
        /// Gets the unique names of all the Action listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Action(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Action", "Gun_Collection", out errOut);
        }

        /// <summary>
        /// Gets the unique names of all the Feedsystem listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Feedsystem(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Feedsystem", "Gun_Collection", out errOut);
        }

        /// <summary>
        /// Gets the unique names of all the StorageLocation listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection StorageLocation(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "StorageLocation", "Gun_Collection", out errOut);
        }

        /// <summary>
        /// Gets the unique names of all the CustomID listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection CustomId(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "CustomID", "Gun_Collection", out errOut);
        }

        /// <summary>
        /// Gets the unique names of all the Finish listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Finish(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Finish", "Gun_Collection", out errOut);
        }
        /// <summary>
        /// Gets the unique names of all the Sights listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Sights(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Sights", "Gun_Collection", out errOut);
        }
        /// <summary>
        /// Gets the unique names of all the PetLoads listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection PetLoads(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "PetLoads", "Gun_Collection", out errOut);
        }

        /// <summary>
        /// Gets the unique names of all the Importer listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Importer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Importer", "Gun_Collection", out errOut);
        }
        /// <summary>
        /// Gets the unique names of all the ClassIII_owner listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection ClassIII_owner(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "ClassIII_owner", "Gun_Collection", out errOut);
        }
        /// <summary>
        /// Gets the unique names of all the BarrelSysTypes listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection BarrelSysTypes(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Name", "Gun_Collection_BarrelSysTypes", out errOut);
        }

    }
}
