using System.Windows.Forms;

namespace BurnSoft.Applications.MGC.AutoFill
{
    /// <summary>
    /// Class Accessory section for auto fill operations
    /// </summary>
    public class Accessory
    {
        /// <summary>
        /// Accessories the manufacturer.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Manufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "Gun_Collection_Accessories", out errOut);
        }
        /// <summary>
        /// Accessories the model.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Model(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Model", "Gun_Collection_Accessories", out errOut);
        }
        /// <summary>
        /// Accessories the use.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Use(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Use", "Gun_Collection_Accessories", out errOut);
        }
        /// <summary>
        /// Accessories the purchase value.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection PurchaseValue(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "PurValue", "Gun_Collection_Accessories", out errOut);
        }
    }
}
