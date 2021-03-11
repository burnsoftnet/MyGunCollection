using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.Applications.MGC.Ammo;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using BurnSoft.Universal;
// ReSharper disable UnusedVariable

namespace BurnSoft.Applications.MGC.UnitTest.Ammo
{
    [TestClass]
    public class InventoryTest
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
        /// The database path
        /// </summary>
        private string _databasePath;
        /// <summary>
        /// The ammo caliber
        /// </summary>
        private string _ammoCaliber;
        /// <summary>
        /// The ammo manufacturer
        /// </summary>
        private string _ammoManufacturer;
        /// <summary>
        /// The ammo name
        /// </summary>
        private string _ammoName;
        /// <summary>
        /// The ammo grain
        /// </summary>
        private string _ammoGrain;
        /// <summary>
        /// The ammo jacket
        /// </summary>
        private string _ammoJacket;
        /// <summary>
        /// The ammo qty
        /// </summary>
        private long _ammoQty;
        /// <summary>
        /// The ammo d cal
        /// </summary>
        private long _ammoDCal;
        /// <summary>
        /// The ammo velocity number
        /// </summary>
        private long _ammoVelocityNumber;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("", TestContext);
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath", TestContext);
            _ammoManufacturer = Vs2019.GetSetting("Ammo_Manufacturer", TestContext);
            _ammoName = Vs2019.GetSetting("Ammo_Name", TestContext);
            _ammoCaliber = Vs2019.GetSetting("Ammo_Caliber", TestContext);
            _ammoGrain = Vs2019.GetSetting("Ammo_Grain", TestContext);
            _ammoJacket = Vs2019.GetSetting("Ammo_Jacket", TestContext);
            _ammoQty = Vs2019.IGetSetting("Ammo_Qty", TestContext);
            _ammoDCal = Vs2019.IGetSetting("Ammo_DCal", TestContext);
            _ammoVelocityNumber = Vs2019.IGetSetting("Ammo_VelocityNumber", TestContext);
        }
        /// <summary>
        /// Verifies the doesnt exist.
        /// </summary>
        private void VerifyDoesntExist()
        {
            if (Inventory.Exists(_databasePath, _ammoManufacturer, _ammoName, _ammoCaliber, _ammoGrain, _ammoJacket, _ammoDCal, _ammoVelocityNumber,out _errOut))
            {
                long id = Inventory.GetId(_databasePath, _ammoManufacturer, _ammoName, _ammoCaliber, _ammoGrain, _ammoJacket, _ammoQty, _ammoDCal, _ammoVelocityNumber, out _errOut);
                bool value = GlobalList.Delete(_databasePath, id, out _errOut);
            }
        }
        /// <summary>
        /// Verifies the exists.
        /// </summary>
        private void VerifyExists()
        {
            if (!Inventory.Exists(_databasePath, _ammoManufacturer, _ammoName, _ammoCaliber, _ammoGrain, _ammoJacket, _ammoDCal, _ammoVelocityNumber, out _errOut))
            {
                bool value = Inventory.Add(_databasePath, _ammoManufacturer, _ammoName, _ammoCaliber, _ammoGrain, _ammoJacket, _ammoQty, _ammoDCal, _ammoVelocityNumber, out _errOut);
            }
        }
        /// <summary>
        /// Defines the test method AddTest.
        /// </summary>
        [TestMethod, TestCategory("Ammo Inventory")]
        public void AddTest()
        {
            VerifyDoesntExist();
            bool value = Inventory.Add(_databasePath, _ammoManufacturer, _ammoName, _ammoCaliber, _ammoGrain, _ammoJacket, _ammoQty, _ammoDCal, _ammoVelocityNumber, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method ExistsTest.
        /// </summary>
        [TestMethod, TestCategory("Ammo Inventory")]
        public void ExistsTest()
        {
            VerifyExists();
            bool value = Inventory.Exists(_databasePath, _ammoManufacturer, _ammoName, _ammoCaliber, _ammoGrain,
                _ammoJacket, _ammoDCal, _ammoVelocityNumber, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method UpdateTest.
        /// </summary>
        [TestMethod, TestCategory("Ammo Inventory")]
        public void UpdateTest()
        {
            VerifyExists();
            long id = Inventory.GetId(_databasePath, _ammoManufacturer, _ammoName, _ammoCaliber, _ammoGrain, _ammoJacket, _ammoQty, _ammoDCal, _ammoVelocityNumber, out _errOut);
            bool value = Inventory.Update(_databasePath, id,_ammoManufacturer, _ammoName, _ammoCaliber, _ammoGrain,
                _ammoJacket, _ammoQty + 100, _ammoDCal, _ammoVelocityNumber, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method UpdateQtyTest.
        /// </summary>
        [TestMethod, TestCategory("Ammo Inventory")]
        public void UpdateQtyTest()
        {
            VerifyExists();
            long id = Inventory.GetId(_databasePath, _ammoManufacturer, _ammoName, _ammoCaliber, _ammoGrain, _ammoJacket, _ammoQty, _ammoDCal, _ammoVelocityNumber, out _errOut);
            long before = Inventory.GetQty(_databasePath, id, out _errOut);
            int addQty = 500;
            bool value = Inventory.UpdateQty(_databasePath, id,  before, addQty, out _errOut);
            long after = Inventory.GetQty(_databasePath, id, out _errOut);
            string status = value ? "PASSEd! " : "FAILED! ";
            TestContext.WriteLine($"{status}  Attempt to add {addQty} to {before} and after the attempt we have {after}");
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method DeleteTest.
        /// </summary>
        [TestMethod, TestCategory("Ammo Inventory")]
        public void DeleteTest()
        {
            VerifyExists();
            long id = Inventory.GetId(_databasePath, _ammoManufacturer, _ammoName, _ammoCaliber, _ammoGrain, _ammoJacket, _ammoQty, _ammoDCal, _ammoVelocityNumber, out _errOut);
            bool value = Inventory.Delete(_databasePath, id,  out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method GetIdTest.
        /// </summary>
        [TestMethod, TestCategory("Ammo Inventory")]
        public void GetIdTest()
        {
            VerifyExists();
            long id = Inventory.GetId(_databasePath, _ammoManufacturer, _ammoName, _ammoCaliber, _ammoGrain, _ammoJacket, _ammoQty, _ammoDCal, _ammoVelocityNumber, out _errOut);
            TestContext.WriteLine($"id: {id}");
            General.HasTrueValue(id > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method GetLastAmmoIdTest.
        /// </summary>
        [TestMethod, TestCategory("Ammo Inventory")]
        public void GetLastAmmoIdTest()
        {
            VerifyExists();
            long id = Inventory.GetLastAmmoId(_databasePath,  out _errOut);
            TestContext.WriteLine($"id: {id}");
            General.HasTrueValue(id > 0, _errOut);
        }
        /// <summary>
        /// Prints the list.
        /// </summary>
        /// <param name="value">The value.</param>
        private void PrintList(List<Ammunition> value)
        {
            if (value.Count > 0)
            {
                foreach (Ammunition a in value)
                {
                    TestContext.WriteLine($"id: {a.Id}");
                    TestContext.WriteLine($"Manufacture: {a.Manufacturer}");
                    TestContext.WriteLine($"Name: {a.Name}");
                    TestContext.WriteLine($"Caliber: {a.Cal}"); 
                    TestContext.WriteLine($"Grain: {a.Grain}");
                    TestContext.WriteLine($"Jacket: {a.Jacket}");
                    TestContext.WriteLine($"Qty: {a.Qty}");
                    TestContext.WriteLine($"Number Version caliber: {a.Dcal}");
                    TestContext.WriteLine($"Velocity: {a.Vel_n}");
                    TestContext.WriteLine($"Last Updated: {a.Sync_lastupdate}");
                    TestContext.WriteLine($"");
                    TestContext.WriteLine($"----------------------------------");
                    TestContext.WriteLine($"");

                }
            }
        }
        /// <summary>
        /// Defines the test method GetListByID.
        /// </summary>
        [TestMethod, TestCategory("Ammo Inventory")]
        public void GetListById()
        {
            VerifyExists();
            long id = Inventory.GetLastAmmoId(_databasePath, out _errOut);
            List<Ammunition> value = Inventory.GetList(_databasePath, id,out  _errOut);
            PrintList(value);
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method GetListByName.
        /// </summary>
        [TestMethod, TestCategory("Ammo Inventory")]
        public void GetListByName()
        {
            VerifyExists();
            
            List<Ammunition> value = Inventory.GetList(_databasePath, _ammoName, _ammoManufacturer, _ammoCaliber, out _errOut);
            PrintList(value);
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method GetListAll.
        /// </summary>
        [TestMethod, TestCategory("Ammo Inventory")]
        public void GetListAll()
        {
            VerifyExists();

            List<Ammunition> value = Inventory.GetList(_databasePath,  out _errOut);
            PrintList(value);
            General.HasTrueValue(value.Count > 0, _errOut);
        }
    }
}
