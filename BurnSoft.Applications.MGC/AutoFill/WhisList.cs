using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BurnSoft.Applications.MGC.AutoFill
{
    /// <summary>
    /// Class WhisList autofill functions
    /// </summary>
    public class WhisList
    {
        /// <summary>
        /// Gets the unique names of all the Manufacturers listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Manufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "Wishlist", out errOut);
        }

        /// <summary>
        /// Gets the unique names of all the Models listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Model(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Model", "Wishlist", out errOut);
        }

        /// <summary>
        /// Gets the unique names of all the Shops listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Shops(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "PlacetoBuy", "Wishlist", out errOut);
        }

        /// <summary>
        /// Gets the unique names of all the Price listed in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Price(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Value", "Wishlist", out errOut);
        }
    }
}
