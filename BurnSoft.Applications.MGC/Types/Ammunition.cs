

namespace BurnSoft.Applications.MGC.Types
{
    /// <summary>
    /// Class Ammunition list container for the Gun_Collection_Ammo table
    /// </summary>
    public class Ammunition
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the manufacturer.
        /// </summary>
        /// <value>The manufacturer.</value>
        public string Manufacturer { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the caliber.
        /// </summary>
        /// <value>The cal.</value>
        public string Cal { get; set; }
        /// <summary>
        /// Gets or sets the grain.
        /// </summary>
        /// <value>The grain.</value>
        public string Grain { get; set; }
        /// <summary>
        /// Gets or sets the jacket.
        /// </summary>
        /// <value>The jacket.</value>
        public string Jacket { get; set; }
        /// <summary>
        /// Gets or sets the qty.
        /// </summary>
        /// <value>The qty.</value>
        public long Qty { get; set; }
        /// <summary>
        /// Gets or sets the double value of the caliber
        /// </summary>
        /// <value>The dcal.</value>
        public double Dcal { get; set; }
        /// <summary>
        /// Gets or sets the velocity in text
        /// </summary>
        /// <value>The vel t.</value>
        public string Vel_t { get; set; }
        /// <summary>
        /// Gets or sets the velocity number value.
        /// </summary>
        /// <value>The vel n.</value>
        public long Vel_n { get; set; }
        /// <summary>
        /// Gets or sets the synchronize lastupdate.
        /// </summary>
        /// <value>The synchronize lastupdate.</value>
        public string Sync_lastupdate { get; set; }
    }
}
