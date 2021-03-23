using System;

namespace BurnSoft.Applications.MGC.Types
{
    /// <summary>
    /// Class GunSmithWorkDone.  Stores the information for the work that was done to a firearm from a gun smith that is stored in the GunSmith_Details table.
    /// </summary>
    [Serializable]
    public class GunSmithWorkDone
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the gun identifier.  Table field name is GID
        /// </summary>
        /// <value>The gun identifier.</value>
        public long GunId { get; set; }
        /// <summary>
        /// Gets or sets the name of the gun smith, field name is gsmith
        /// </summary>
        /// <value>The name of the gun smith.</value>
        public string GunSmithName { get; set; }
        /// <summary>
        /// Gets or sets the gun smith identifier. GSID  in the database
        /// </summary>
        /// <value>The gun smith identifier.</value>
        public long GunSmithId { get; set; }
        /// <summary>
        /// Gets or sets the other work done.  od in the database
        /// </summary>
        /// <value>The other work done.</value>
        public string OtherWorkDone { get; set; }
        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>The notes.</value>
        public string Notes { get; set; }
        /// <summary>
        /// Gets or sets the start date. sdate in teh database
        /// </summary>
        /// <value>The start date.</value>
        public string StartDate { get; set; }
        /// <summary>
        /// Gets or sets the return date. rdate in the database
        /// </summary>
        /// <value>The return date.</value>
        public string ReturnDate { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize.  sync_lastupdate in the database
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
