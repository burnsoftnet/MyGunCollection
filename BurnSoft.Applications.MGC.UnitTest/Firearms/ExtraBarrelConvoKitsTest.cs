using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.Applications.MGC.Firearms;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using BurnSoft.Universal;


namespace BurnSoft.Applications.MGC.UnitTest.Firearms
{
    [TestClass]
    public class ExtraBarrelConvoKitsTest
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
        private long BarrelConvoKit_DefaultId;
        /// <summary>
        /// The database path
        /// </summary>
        private string _databasePath;
        /// <summary>
        /// The barrel convo kit add model name
        /// </summary>
        private string BarrelConvoKit_Add_ModelName;
        /// <summary>
        /// The barrel convo kit add caliber
        /// </summary>
        private string BarrelConvoKit_Add_Caliber;
        /// <summary>
        /// The barrel convo kit add finish
        /// </summary>
        private string BarrelConvoKit_Add_Finish;
        /// <summary>
        /// The barrel convo kit add barrel length
        /// </summary>
        private string BarrelConvoKit_Add_BarrelLength;
        /// <summary>
        /// The barrel convo kit add pet loads
        /// </summary>
        private string BarrelConvoKit_Add_PetLoads;
        /// <summary>
        /// The barrel convo kit add action
        /// </summary>
        private string BarrelConvoKit_Add_Action;
        /// <summary>
        /// The barrel convo kit add feedsystem
        /// </summary>
        private string BarrelConvoKit_Add_Feedsystem;
        /// <summary>
        /// The barrel convo kit add sights
        /// </summary>
        private string BarrelConvoKit_Add_Sights;
        /// <summary>
        /// The barrel convo kit add purchased price
        /// </summary>
        private string BarrelConvoKit_Add_PurchasedPrice;
        /// <summary>
        /// The barrel convo kit add purchased from
        /// </summary>
        private string BarrelConvoKit_Add_PurchasedFrom;
        /// <summary>
        /// The barrel convo kit add dta
        /// </summary>
        private string BarrelConvoKit_Add_dta;
        /// <summary>
        /// The barrel convo kit add height
        /// </summary>
        private string BarrelConvoKit_Add_Height;
        /// <summary>
        /// The barrel convo kit add type
        /// </summary>
        private string BarrelConvoKit_Add_Type;
        /// <summary>
        /// The barrel convo kit add is default
        /// </summary>
        private int BarrelConvoKit_Add_IsDefault;
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
            BarrelConvoKit_DefaultId = Vs2019.IGetSetting("BarrelConvoKit_DefaultId", TestContext);
            BarrelConvoKit_Add_ModelName = Vs2019.GetSetting("BarrelConvoKit_Add_ModelName", TestContext);
            BarrelConvoKit_Add_Caliber = Vs2019.GetSetting("BarrelConvoKit_Add_Caliber", TestContext);
            BarrelConvoKit_Add_Finish = Vs2019.GetSetting("BarrelConvoKit_Add_Finish", TestContext);
            BarrelConvoKit_Add_BarrelLength = Vs2019.GetSetting("BarrelConvoKit_Add_BarrelLength", TestContext);
            BarrelConvoKit_Add_PetLoads = Vs2019.GetSetting("BarrelConvoKit_Add_PetLoads", TestContext);
            BarrelConvoKit_Add_Action = Vs2019.GetSetting("BarrelConvoKit_Add_Action", TestContext);
            BarrelConvoKit_Add_Feedsystem = Vs2019.GetSetting("BarrelConvoKit_Add_Feedsystem", TestContext);
            BarrelConvoKit_Add_Sights = Vs2019.GetSetting("BarrelConvoKit_Add_Sights", TestContext);
            BarrelConvoKit_Add_PurchasedPrice = Vs2019.GetSetting("BarrelConvoKit_Add_PurchasedPrice", TestContext);
            BarrelConvoKit_Add_PurchasedFrom = Vs2019.GetSetting("BarrelConvoKit_Add_PurchasedFrom", TestContext);
            BarrelConvoKit_Add_dta = Vs2019.GetSetting("BarrelConvoKit_Add_dta", TestContext);
            BarrelConvoKit_Add_Height = Vs2019.GetSetting("BarrelConvoKit_Add_Height", TestContext);
            BarrelConvoKit_Add_Type = Vs2019.GetSetting("BarrelConvoKit_Add_Type", TestContext);
            BarrelConvoKit_Add_IsDefault = Vs2019.IGetSetting("BarrelConvoKit_Add_IsDefault", TestContext);
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
        /// Defines the test method GetList.
        /// </summary>
        [TestMethod, TestCategory("Barrel/Conversion Kits")]
        public void GeCurrentBarrelDetailstListTest()
        {
            List<BarrelSystems> value = ExtraBarrelConvoKits.GetCurrentBarrelDetailstList(_databasePath, _gunId, out _errOut);
            PrintList(value);
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("Barrel/Conversion Kits")]
        public void GetBarrelIdTest()
        {
            long value = ExtraBarrelConvoKits.GetBarrelId(_databasePath, _gunId, out _errOut, true);
            TestContext.WriteLine($"Barrel Id: {value}");
            General.HasTrueValue(value == BarrelConvoKit_DefaultId, _errOut);
        }

        [TestMethod, TestCategory("Barrel/Conversion Kits")]
        public void GetListAllTest()
        {
            List<BarrelSystems> value = ExtraBarrelConvoKits.GetList(_databasePath, out _errOut);
            PrintList(value);
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("Barrel/Conversion Kits")]
        public void GetListByBarrelIdTest()
        {
            List<BarrelSystems> value = ExtraBarrelConvoKits.GetList(_databasePath, BarrelConvoKit_DefaultId, out _errOut);
            PrintList(value);
            General.HasTrueValue(value.Count > 0, _errOut);
        }
    }
}
