
namespace BurnSoft.Applications.MGC.Types
{
    /// <summary>
    /// Class to hold the information about the Barrel System and Conversion kits for a firearm
    /// </summary>
    public class BarrelSystems
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>The full name.</value>
        public string FullName { get; set; }
        /// <summary>
        /// Gets or sets the length of the barrel.
        /// </summary>
        /// <value>The length of the barrel.</value>
        public string BarrelLength { get; set; }
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        public string Height { get; set; }
        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>The action.</value>
        public string Action { get; set; }
        /// <summary>
        /// Gets or sets the feed system.
        /// </summary>
        /// <value>The feed system.</value>
        public string FeedSystem { get; set; }
        /// <summary>
        /// Gets or sets the sights.
        /// </summary>
        /// <value>The sights.</value>
        public string Sights { get; set; }
        /// <summary>
        /// Gets or sets the pet loads.
        /// </summary>
        /// <value>The pet loads.</value>
        public string PetLoads { get; set; }
        /// <summary>
        /// Gets or sets the purchased price.
        /// </summary>
        /// <value>The purchased price.</value>
        public string PurchasedPrice { get; set; }
        /// <summary>
        /// Gets or sets the purchased from.
        /// </summary>
        /// <value>The purchased from.</value>
        public string PurchasedFrom { get; set; }
        /// <summary>
        /// Gets or sets the finish.
        /// </summary>
        /// <value>The finish.</value>
        public string Finish { get; set; }
        /// <summary>
        /// Gets or sets the gun identifier.
        /// </summary>
        /// <value>The gun identifier.</value>
        public long GunId { get; set; }
        /// <summary>
        /// Gets or sets the name of the model.
        /// </summary>
        /// <value>The name of the model.</value>
        public string ModelName { get; set; }
        /// <summary>
        /// Gets or sets the caliber.
        /// </summary>
        /// <value>The caliber.</value>
        public string Caliber { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        /// <value><c>true</c> if this instance is default; otherwise, <c>false</c>.</value>
        public bool IsDefault { get; set; }
        /// <summary>
        /// Gets or sets the last updated.
        /// </summary>
        /// <value>The last updated.</value>
        public string LastUpdated { get; set; }

    }
}
