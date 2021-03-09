using System;

namespace BurnSoft.Applications.MGC.Types
{
    /// <summary>
    /// Class GunCollectionList.  List container to hold the database taken from the database fort he gun collection details.
    /// </summary>
    [Serializable]
    public class GunCollectionList
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the owner id.
        /// </summary>
        /// <value>The oid.</value>
        public int Oid { get; set; }
        /// <summary>
        /// Gets or sets the manufacture id.
        /// </summary>
        /// <value>The mid.</value>
        public int Mid { get; set; }
        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>The full name.</value>
        public string FullName { get; set; }
        /// <summary>
        /// Gets or sets the name of the model.
        /// </summary>
        /// <value>The name of the model.</value>
        public string ModelName { get; set; }
        /// <summary>
        /// Gets or sets the model identifier.
        /// </summary>
        /// <value>The model identifier.</value>
        public int ModelId { get; set; }
        /// <summary>
        /// Gets or sets the serial number.
        /// </summary>
        /// <value>The serial number.</value>
        public string SerialNumber { get; set; }
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; set; }
        /// <summary>
        /// Gets or sets the caliber.
        /// </summary>
        /// <value>The caliber.</value>
        public string Caliber { get; set; }
        /// <summary>
        /// Gets or sets the finish.
        /// </summary>
        /// <value>The finish.</value>
        public string Finish { get; set; }
        /// <summary>
        /// Gets or sets the condition.
        /// </summary>
        /// <value>The condition.</value>
        public string Condition { get; set; }
        /// <summary>
        /// Gets or sets the custom identifier.
        /// </summary>
        /// <value>The custom identifier.</value>
        public string CustomId { get; set; }
        /// <summary>
        /// Gets or sets the nationality identifier.
        /// </summary>
        /// <value>The nationality identifier.</value>
        public int NationalityId { get; set; }
        /// <summary>
        /// Gets or sets the grip identifier.
        /// </summary>
        /// <value>The grip identifier.</value>
        public int GripId { get; set; }
        /// <summary>
        /// Gets or sets the qty.
        /// </summary>
        /// <value>The qty.</value>
        public int Qty { get; set; }
        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>The weight.</value>
        public string Weight { get; set; }
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        public string Height { get; set; }
        /// <summary>
        /// Gets or sets the type of the stock.
        /// </summary>
        /// <value>The type of the tock.</value>
        public string StockType { get; set; }
        /// <summary>
        /// Gets or sets the length of the barrel.
        /// </summary>
        /// <value>The length of the barrel.</value>
        public string BarrelLength { get; set; }
        /// <summary>
        /// Gets or sets the width of the barrel.
        /// </summary>
        /// <value>The width of the barrel.</value>
        public string BarrelWidth { get; set; }
        /// <summary>
        /// Gets or sets the height of the barrel.
        /// </summary>
        /// <value>The height of the barrel.</value>
        public string BarrelHeight { get; set; }
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
        /// Gets or sets the purchase price.
        /// </summary>
        /// <value>The purchase price.</value>
        public string PurchasePrice { get; set; }
        /// <summary>
        /// Gets or sets the purchase from.
        /// </summary>
        /// <value>The purchase from.</value>
        public string PurchaseFrom { get; set; }
        /// <summary>
        /// Gets or sets the appriased value.
        /// </summary>
        /// <value>The appriased value.</value>
        public string AppriasedValue { get; set; }
        /// <summary>
        /// Gets or sets the appriased by.
        /// </summary>
        /// <value>The appriased by.</value>
        public string AppriasedBy { get; set; }
        /// <summary>
        /// Gets or sets the appriaser identifier.
        /// </summary>
        /// <value>The appriaser identifier.</value>
        public int AppriaserId { get; set; }
        /// <summary>
        /// Gets or sets the insured value.
        /// </summary>
        /// <value>The insured value.</value>
        public string InsuredValue { get; set; }
        /// <summary>
        /// Gets or sets the storage location.
        /// </summary>
        /// <value>The storage location.</value>
        public string StorageLocation { get; set; }
        /// <summary>
        /// Gets or sets the condition comments.
        /// </summary>
        /// <value>The condition comments.</value>
        public string ConditionComments { get; set; }
        /// <summary>
        /// Gets or sets the additional notes.
        /// </summary>
        /// <value>The additional notes.</value>
        public string AdditionalNotes { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance has accessory.
        /// </summary>
        /// <value><c>true</c> if this instance has accessory; otherwise, <c>false</c>.</value>
        public bool HasAccessory { get; set; }
        /// <summary>
        /// Gets or sets the has accessory database value.
        /// </summary>
        /// <value>The has accessory database value.</value>
        public int HasAccessoryDbValue { get; set; }
        /// <summary>
        /// Gets or sets the date produced.
        /// </summary>
        /// <value>The date produced.</value>
        public string DateProduced { get; set; }
        /// <summary>
        /// Gets or sets the date time added in database.
        /// </summary>
        /// <value>The date time added in database.</value>
        public string DateTimeAddedInDb { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [item sold].
        /// </summary>
        /// <value><c>true</c> if [item sold]; otherwise, <c>false</c>.</value>
        public bool ItemSold { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [item sold database value].
        /// </summary>
        /// <value><c>true</c> if [item sold database value]; otherwise, <c>false</c>.</value>
        public bool ItemSoldDbValue { get; set; }
        /// <summary>
        /// Gets or sets the seller id.
        /// </summary>
        /// <value>The sid.</value>
        public int Sid { get; set; }
        /// <summary>
        /// Gets or sets the byer id.
        /// </summary>
        /// <value>The bid.</value>
        public int Bid { get; set; }
        /// <summary>
        /// Gets or sets the date sold.
        /// </summary>
        /// <value>The date sold.</value>
        public string DateSold { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is c and r.
        /// </summary>
        /// <value><c>true</c> if this instance is c and r; otherwise, <c>false</c>.</value>
        public bool IsCAndR { get; set; }
        /// <summary>
        /// Gets or sets the is c and r database value.
        /// </summary>
        /// <value>The is c and r database value.</value>
        public int IsCAndRDbValue { get; set; }
        /// <summary>
        /// Gets or sets the pet loads now mostly the second caliber.
        /// </summary>
        /// <value>The pet loads.</value>
        public string PetLoads { get; set; }
        /// <summary>
        /// Gets or sets the date time added.
        /// </summary>
        /// <value>The date time added.</value>
        public string DateTimeAdded { get; set; }
        /// <summary>
        /// Gets or sets the importer.
        /// </summary>
        /// <value>The importer.</value>
        public string Importer { get; set; }
        /// <summary>
        /// Gets or sets the remanufacture date.
        /// </summary>
        /// <value>The remanufacture date.</value>
        public string RemanufactureDate { get; set; }
        /// <summary>
        /// Gets or sets the poi.
        /// </summary>
        /// <value>The poi.</value>
        public string Poi { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance has mb.
        /// </summary>
        /// <value><c>true</c> if this instance has mb; otherwise, <c>false</c>.</value>
        public bool HasMb { get; set; }
        /// <summary>
        /// Gets or sets the database identifier.
        /// </summary>
        /// <value>The database identifier.</value>
        public int DbId { get; set; }
        /// <summary>
        /// Gets or sets the shot gun choke.
        /// </summary>
        /// <value>The shot gun choke.</value>
        public string ShotGunChoke { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is in bound book.
        /// </summary>
        /// <value><c>true</c> if this instance is in bound book; otherwise, <c>false</c>.</value>
        public bool IsInBoundBook { get; set; }
        /// <summary>
        /// Gets or sets the twist rate.
        /// </summary>
        /// <value>The twist rate.</value>
        public string TwistRate { get; set; }
        /// <summary>
        /// Gets or sets the trigger pull in punds.
        /// </summary>
        /// <value>The trigger pull in punds.</value>
        public string TriggerPullInPunds { get; set; }
        /// <summary>
        /// Gets or sets the caliber3.
        /// </summary>
        /// <value>The caliber3.</value>
        public string Caliber3 { get; set; }
        /// <summary>
        /// Gets or sets the classification.
        /// </summary>
        /// <value>The classification.</value>
        public string Classification { get; set; }
        /// <summary>
        /// Gets or sets the date of c and r.
        /// </summary>
        /// <value>The date of c and r.</value>
        public string DateOfCAndR { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize date.
        /// </summary>
        /// <value>The last synchronize date.</value>
        public string LastSyncDate { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is class3 item.
        /// </summary>
        /// <value><c>true</c> if this instance is class3 item; otherwise, <c>false</c>.</value>
        public bool IsClass3Item { get; set; }
        /// <summary>
        /// Gets or sets the class3 owner.
        /// </summary>
        /// <value>The class3 owner.</value>
        public string Class3Owner { get; set; }

}
}
