using System;

namespace BurnSoft.Applications.MGC.Types
{
    /// <summary>
    /// Class GunCollectionList.  List container to hold the database taken from the database fort he gun collection details.
    /// </summary>
    [Serializable]
    public class GunCollectionList
    {
        public int Id { get; set; }
        public int Oid { get; set; }
        public int Mid { get; set; }
        public string FullName { get; set; }
        public string ModelName { get; set; }
        public int ModelId { get; set; }
        public string SerialNumber { get; set; }
        public string Type { get; set; }
        public string Caliber { get; set; }
        public string Finish { get; set; }
        public string Condition { get; set; }
        public string CustomId { get; set; }
        public int NationalityId { get; set; }
        public int GripId { get; set; }
        public int Qty { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string TockType { get; set; }
        public string BarrelLength { get; set; }
        public string BarrelWidth { get; set; }
        public string BarrelHeight { get; set; }
        public string Action { get; set; }
        public string FeedSystem { get; set; }
        public string PurchasePrice { get; set; }
        public string PurchaseFrom { get; set; }
        public string AppriasedValue { get; set; }
        public string AppriasedBy { get; set; }
        public int AppriaserId { get; set; }
        public string InsuredValue { get; set; }
        public string StorageLocation { get; set; }
        public string ConditionComments { get; set; }
        public string AdditionalNotes { get; set; }
        public bool HasAccessory { get; set; }
        public int HasAccessoryDbValue { get; set; }
        public string DateProduced { get; set; }
        public string DateTimeAddedInDb { get; set; }
        public bool ItemSold { get; set; }
        public bool ItemSoldDbValue { get; set; }
        public int Sid { get; set; }
        public int Bid { get; set; }
        public string DateSold { get; set; }
        public bool IsCAndR { get; set; }
        public int IsCAndRDbValue { get; set; }
        public string PetLoads { get; set; }
        public string DateTimeAdded { get; set; }
        public string Importer { get; set; }
        public string RemanufactureDate { get; set; }
        public string Poi { get; set; }
        public bool HasMb { get; set; }
        public int DbId { get; set; }
        public string ShotGunChoke { get; set; }
        public bool IsInBoundBook { get; set; }
        public string TwistRate { get; set; }
        public string TriggerPullInPunds { get; set; }
        public string Caliber3 { get; set; }
        public string Classification { get; set; }
        public string DateOfCAndR { get; set; }
        public string LastSyncDate { get; set; }
        public bool IsClass3Item { get; set; }
        public string Class3Owner { get; set; }

}
}
