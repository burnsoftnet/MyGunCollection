
namespace BurnSoft.Applications.MGC.Types
{
    /// <summary>
    /// Class DocumentList container
    /// </summary>
    public class DocumentList
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the document.
        /// </summary>
        /// <value>The name of the document.</value>
        public string DocName { get; set; }
        /// <summary>
        /// Gets or sets the document description.
        /// </summary>
        /// <value>The document description.</value>
        public string DocDescription { get; set; }
        /// <summary>
        /// Gets or sets the document filename.
        /// </summary>
        /// <value>The document filename.</value>
        public string DocFilename { get; set; }
        /// <summary>
        /// Gets or sets the dta.
        /// </summary>
        /// <value>The dta.</value>
        public string Dta { get; set; }
        /// <summary>
        /// Gets or sets the data file.
        /// </summary>
        /// <value>The data file.</value>
        public object DataFile { get; set; }
        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>The length.</value>
        public long Length { get; set; }
        /// <summary>
        /// Gets or sets the data file thumb.
        /// </summary>
        /// <value>The data file thumb.</value>
        public object DataFileThumb { get; set; }
        /// <summary>
        /// Gets or sets the document ext.
        /// </summary>
        /// <value>The document ext.</value>
        public string DocExt { get; set; }
        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
        public string Category { get; set; }
        /// <summary>
        /// Gets or sets the synchronize last update.
        /// </summary>
        /// <value>The synchronize last update.</value>
        public string SyncLastUpdate { get; set; }
    }
}
