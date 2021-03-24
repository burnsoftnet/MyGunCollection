using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.Applications.MGC.Firearms;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using BurnSoft.Universal;
// ReSharper disable UnusedMember.Local


namespace BurnSoft.Applications.MGC.UnitTest.Firearms
{
    [TestClass]
    public class GunSmithDetailsTest
    {
        /// <summary>
        /// Gets or sets the test context.
        /// </summary>
        /// <value>The test context.</value>
        public TestContext TestContext { get; set; }
        /// <summary>
        /// The error out
        /// </summary>
        private string _errOut;
        /// <summary>
        /// The gun identifier
        /// </summary>
        private int _gunId;
        /// <summary>
        /// The barrel convo kit default identifier
        /// </summary>
        private long _barrelConvoKitDefaultId;
        /// <summary>
        /// The database path
        /// </summary>
        private string _databasePath;
        /// <summary>
        /// The barrel convo kit add model name
        /// </summary>
        private string _barrelConvoKitAddModelName;
        /// <summary>
        /// The barrel convo kit add caliber
        /// </summary>
        private string _barrelConvoKitAddCaliber;
        /// <summary>
        /// The barrel convo kit add finish
        /// </summary>
        private string _barrelConvoKitAddFinish;
        /// <summary>
        /// The barrel convo kit add barrel length
        /// </summary>
        private string _barrelConvoKitAddBarrelLength;
        /// <summary>
        /// The barrel convo kit add pet loads
        /// </summary>
        private string _barrelConvoKitAddPetLoads;
        /// <summary>
        /// The barrel convo kit add action
        /// </summary>
        private string _barrelConvoKitAddAction;
        /// <summary>
        /// The barrel convo kit add feedsystem
        /// </summary>
        private string _barrelConvoKitAddFeedsystem;
        /// <summary>
        /// The barrel convo kit add sights
        /// </summary>
        private string _barrelConvoKitAddSights;
        /// <summary>
        /// The barrel convo kit add purchased price
        /// </summary>
        private string _barrelConvoKitAddPurchasedPrice;
        /// <summary>
        /// The barrel convo kit add purchased from
        /// </summary>
        private string _barrelConvoKitAddPurchasedFrom;
        /// <summary>
        /// The barrel convo kit add height
        /// </summary>
        private string _barrelConvoKitAddHeight;
        /// <summary>
        /// The barrel convo kit add type
        /// </summary>
        private string _barrelConvoKitAddType;
        /// <summary>
        /// The barrel convo kit add is default
        /// </summary>
        private bool _barrelConvoKitAddIsDefault;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("", TestContext);
            BSOtherObjects obj = new BSOtherObjects();
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath", TestContext);
            _gunId = Vs2019.IGetSetting("MyGunCollectionID", TestContext);
            _barrelConvoKitDefaultId = Vs2019.IGetSetting("BarrelConvoKit_DefaultId", TestContext);
            _barrelConvoKitAddModelName = Vs2019.GetSetting("BarrelConvoKit_Add_ModelName", TestContext);
            _barrelConvoKitAddCaliber = Vs2019.GetSetting("BarrelConvoKit_Add_Caliber", TestContext);
            _barrelConvoKitAddFinish = Vs2019.GetSetting("BarrelConvoKit_Add_Finish", TestContext);
            _barrelConvoKitAddBarrelLength = Vs2019.GetSetting("BarrelConvoKit_Add_BarrelLength", TestContext);
            _barrelConvoKitAddPetLoads = Vs2019.GetSetting("BarrelConvoKit_Add_PetLoads", TestContext);
            _barrelConvoKitAddAction = Vs2019.GetSetting("BarrelConvoKit_Add_Action", TestContext);
            _barrelConvoKitAddFeedsystem = Vs2019.GetSetting("BarrelConvoKit_Add_Feedsystem", TestContext);
            _barrelConvoKitAddSights = Vs2019.GetSetting("BarrelConvoKit_Add_Sights", TestContext);
            _barrelConvoKitAddPurchasedPrice = Vs2019.GetSetting("BarrelConvoKit_Add_PurchasedPrice", TestContext);
            _barrelConvoKitAddPurchasedFrom = obj.FC(Vs2019.GetSetting("BarrelConvoKit_Add_PurchasedFrom", TestContext));
            _barrelConvoKitAddHeight = Vs2019.GetSetting("BarrelConvoKit_Add_Height", TestContext);
            _barrelConvoKitAddType = Vs2019.GetSetting("BarrelConvoKit_Add_Type", TestContext);
            _barrelConvoKitAddIsDefault = Vs2019.BGetSetting("BarrelConvoKit_Add_IsDefault", TestContext);
        }
        /// <summary>
        /// Prints the list.
        /// </summary>
        /// <param name="value">The value.</param>
        private void PrintList(List<BarrelSystems> value)
        {
            if (value.Count > 0)
            {
                foreach (BarrelSystems g in value)
                {
                    TestContext.WriteLine($"id : {g.Id}");
                    TestContext.WriteLine($"Full Name: {g.FullName}");
                    TestContext.WriteLine($"Finish: {g.Finish}");
                    TestContext.WriteLine($"BarrelLength: {g.BarrelLength}");
                    TestContext.WriteLine($"Height: {g.Height}");
                    TestContext.WriteLine($"Action: {g.Action}");
                    TestContext.WriteLine($"Sights: {g.Sights}");
                    TestContext.WriteLine($"PurchasePrice: {g.PurchasedPrice}");
                    TestContext.WriteLine($"PurchaseFrom: {g.PurchasedFrom}");
                    TestContext.WriteLine($"Petloads/Caliber2: {g.PetLoads}");
                    TestContext.WriteLine($"Gun Id: {g.GunId}");
                    TestContext.WriteLine($"Model Name: {g.ModelName}");
                    TestContext.WriteLine($"Caliber: {g.Caliber}");
                    TestContext.WriteLine($"Is Default: {g.IsDefault}");
                    TestContext.WriteLine($"Last Updated: {g.LastUpdated}");
                    TestContext.WriteLine($"");
                    TestContext.WriteLine($"--------------------------------------");
                    TestContext.WriteLine($"");
                }
            }
        }
        /// <summary>
        /// Verifies the exists.
        /// </summary>
        private void VerifyExists()
        {

            if (!ExtraBarrelConvoKits.Exists(_databasePath, _gunId, _barrelConvoKitAddModelName,
                _barrelConvoKitAddCaliber, _barrelConvoKitAddFinish, _barrelConvoKitAddBarrelLength,
                _barrelConvoKitAddPetLoads, _barrelConvoKitAddAction, _barrelConvoKitAddFeedsystem,
                _barrelConvoKitAddSights, _barrelConvoKitAddPurchasedPrice, _barrelConvoKitAddPurchasedFrom,
                _barrelConvoKitAddHeight, _barrelConvoKitAddType, _barrelConvoKitAddIsDefault, out _errOut))
            {
                ExtraBarrelConvoKits.Add(_databasePath, _gunId, _barrelConvoKitAddModelName,
                    _barrelConvoKitAddCaliber, _barrelConvoKitAddFinish, _barrelConvoKitAddBarrelLength,
                    _barrelConvoKitAddPetLoads, _barrelConvoKitAddAction, _barrelConvoKitAddFeedsystem,
                    _barrelConvoKitAddSights, _barrelConvoKitAddPurchasedPrice, _barrelConvoKitAddPurchasedFrom,
                    _barrelConvoKitAddHeight, _barrelConvoKitAddType, _barrelConvoKitAddIsDefault, out _errOut);
            }
        }
        /// <summary>
        /// Verifies the doesnt exist.
        /// </summary>
        private void VerifyDoesntExist()
        {
            if (ExtraBarrelConvoKits.Exists(_databasePath, _gunId, _barrelConvoKitAddModelName,
                _barrelConvoKitAddCaliber, _barrelConvoKitAddFinish, _barrelConvoKitAddBarrelLength,
                _barrelConvoKitAddPetLoads, _barrelConvoKitAddAction, _barrelConvoKitAddFeedsystem,
                _barrelConvoKitAddSights, _barrelConvoKitAddPurchasedPrice, _barrelConvoKitAddPurchasedFrom,
                _barrelConvoKitAddHeight, _barrelConvoKitAddType, _barrelConvoKitAddIsDefault, out _errOut))
            {
                long value = ExtraBarrelConvoKits.GetBarrelId(_databasePath, _gunId, _barrelConvoKitAddModelName, out _errOut);
                ExtraBarrelConvoKits.Delete(_databasePath, value, out _errOut);
            }
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
