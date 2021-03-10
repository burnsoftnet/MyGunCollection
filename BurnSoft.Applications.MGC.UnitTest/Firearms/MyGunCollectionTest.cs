using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BurnSoft.Applications.MGC;
using BurnSoft.Applications.MGC.Firearms;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Applications.MGC.UnitTest.Settings;

namespace BurnSoft.Applications.MGC.UnitTest.Firearms
{
    [TestClass]
    public class MyGunCollectionTest
    {
        /// <summary>
        /// Gets or sets the test context.
        /// </summary>
        /// <value>The test context.</value>
        public TestContext TestContext { get; set; }
        /// <summary>
        /// The error out
        /// </summary>
        private string errOut;
        /// <summary>
        /// The gun identifier
        /// </summary>
        private int GunID;
        /// <summary>
        /// The database path
        /// </summary>
        private string DatabasePath;

        [TestInitialize]
        public void Init()
        {
            errOut = @"";
            DatabasePath = Vs2019.GetSetting("DatabasePath", TestContext);
            GunID = Vs2019.IGetSetting("MyGunCollectionID", TestContext);
        }
        [TestMethod, TestCategory("")]
        public void GetList()
        {
            List<GunCollectionList> value = MyCollection.GetList(DatabasePath, GunID, out errOut);
            if (value.Count > 0)
            {
                foreach (GunCollectionList g in value)
                {
                    TestContext.WriteLine($"id : {g.Id}");
                    TestContext.WriteLine($"Full Name: {g.FullName}");
                    TestContext.WriteLine($"Owner id: {g.Oid}");
                    TestContext.WriteLine($"Manufacture Id: {g.Mid}");
                    TestContext.WriteLine($"ModelName: {g.ModelName}");
                    TestContext.WriteLine($"Model Id: {g.ModelId}");
                    TestContext.WriteLine($"SerialNumber: {g.SerialNumber}");
                    TestContext.WriteLine($"Type: {g.Type}");
                    TestContext.WriteLine($"Caliber: {g.Caliber}");
                    TestContext.WriteLine($"Caliber 2: {g.PetLoads}");
                    TestContext.WriteLine($"Caliber 3: {g.Caliber3}");
                    TestContext.WriteLine($"Finish: {g.FeedSystem}");
                    TestContext.WriteLine($"Finish: {g.Finish}");
                    TestContext.WriteLine($"Condition: {g.Condition}");
                    TestContext.WriteLine($"CustomId: {g.CustomId}");
                    TestContext.WriteLine($"NationalityId: {g.NationalityId}");
                    TestContext.WriteLine($"BarrelLength: {g.BarrelLength}");
                    TestContext.WriteLine($"GripId: {g.GripId}");
                    TestContext.WriteLine($"Qty: {g.Qty}");
                    TestContext.WriteLine($"Weight: {g.Weight}");
                    TestContext.WriteLine($"Height: {g.Height}");
                    TestContext.WriteLine($"StockType: {g.StockType}");
                    TestContext.WriteLine($"BarrelHeight: {g.BarrelHeight}");
                    TestContext.WriteLine($"BarrelWidth: {g.BarrelWidth}");
                    TestContext.WriteLine($"Action: {g.Action}");
                    TestContext.WriteLine($"Sights: {g.Sights}");
                    TestContext.WriteLine($"PurchasePrice: {g.PurchasePrice}");
                    TestContext.WriteLine($"PurchaseFrom: {g.PurchaseFrom}");
                    TestContext.WriteLine($"AppriasedBy: {g.AppriasedBy}");
                    TestContext.WriteLine($"AppriasedValue: {g.AppriasedValue}");
                    TestContext.WriteLine($"AppriaserId: {g.AppriaserId}");
                    TestContext.WriteLine($"AppraisalDate: {g.AppraisalDate}");
                    TestContext.WriteLine($"InsuredValue: {g.InsuredValue}");
                    TestContext.WriteLine($"StorageLocation: {g.StorageLocation}");
                    TestContext.WriteLine($"ConditionComments: {g.ConditionComments}");
                    TestContext.WriteLine($"AdditionalNotes: {g.AdditionalNotes}");
                    TestContext.WriteLine($"HasAccessory: {g.HasAccessory}");
                    TestContext.WriteLine($"DateProduced: {g.DateProduced}");
                    TestContext.WriteLine($"DateTimeAddedInDb: {g.DateTimeAddedInDb}");
                    TestContext.WriteLine($"ItemSold: {g.ItemSold}");
                    TestContext.WriteLine($"Selled Id: {g.Sid}");
                    TestContext.WriteLine($"Buyer Id: {g.Bid}");
                    TestContext.WriteLine($"Date Sold: {g.DateSold}");
                    TestContext.WriteLine($"Is C&R Items: {g.IsCAndR}");
                    TestContext.WriteLine($"DateTimeAdded: {g.DateTimeAddedInDb}");
                    TestContext.WriteLine($"Importer: {g.Importer}");
                    TestContext.WriteLine($"RemanufactureDate: {g.RemanufactureDate}");
                    TestContext.WriteLine($"Poi: {g.Poi}");
                    TestContext.WriteLine($"HasMb : {g.HasMb}");
                    TestContext.WriteLine($"DbId: {g.DbId}");
                    TestContext.WriteLine($"ShotGunChoke: {g.ShotGunChoke}");
                    TestContext.WriteLine($"IsInBoundBook: {g.IsInBoundBook}");
                    TestContext.WriteLine($"TwistRate: {g.TwistRate}");
                    TestContext.WriteLine($"TriggerPullInPounds: {g.TriggerPullInPounds}");
                    TestContext.WriteLine($"Classification: {g.Classification}");
                    TestContext.WriteLine($"DateOfCAndR: {g.DateOfCAndR}");
                    TestContext.WriteLine($"LastSyncDate: {g.LastSyncDate}");
                    TestContext.WriteLine($"IsClass3Item: {g.IsClass3Item}");
                    TestContext.WriteLine($"Class3Owner: {g.Class3Owner}");
                    TestContext.WriteLine($"--------------------------------------");
                    TestContext.WriteLine($"");
                }
            }

            General.HasTrueValue(value.Count > 0, errOut);
        }
    }
}
