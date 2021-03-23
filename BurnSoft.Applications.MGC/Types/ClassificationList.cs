
using System;

namespace BurnSoft.Applications.MGC.Types
{
    /// <summary>
    /// Class ClassificationList, container for classification list data
    /// </summary>
    [Serializable]
    public class ClassificationList
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize.
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
