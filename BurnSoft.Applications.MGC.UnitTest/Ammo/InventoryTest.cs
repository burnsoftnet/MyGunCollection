using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.Applications.MGC.Ammo;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using BurnSoft.Universal;

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

        private string Ammo_Caliber;
        private string Ammo_Manufacturer;
        private string Ammo_Name;
        private string Ammo_Grain;
        private string Ammo_Jacket;
        private long Ammo_Qty;
        private long Ammo_DCal;
        private long Ammo_VelocityNumber;
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
            Ammo_Manufacturer = Vs2019.GetSetting("Ammo_Manufacturer", TestContext);
            Ammo_Name = Vs2019.GetSetting("Ammo_Name", TestContext);
            Ammo_Caliber = Vs2019.GetSetting("Ammo_Caliber", TestContext);
            Ammo_Grain = Vs2019.GetSetting("Ammo_Grain", TestContext);
            Ammo_Jacket = Vs2019.GetSetting("Ammo_Jacket", TestContext);
            Ammo_Qty = Vs2019.IGetSetting("Ammo_Qty", TestContext);
            Ammo_DCal = Vs2019.IGetSetting("Ammo_DCal", TestContext);
            Ammo_VelocityNumber = Vs2019.IGetSetting("Ammo_VelocityNumber", TestContext);
        }
        /// <summary>
        /// Verifies the doesnt exist.
        /// </summary>
        private void VerifyDoesntExist()
        {
            if (Inventory.Exists(_databasePath, Ammo_Manufacturer, Ammo_Name, Ammo_Caliber, Ammo_Grain, Ammo_Jacket, Ammo_DCal, Ammo_VelocityNumber,out _errOut))
            {
                long id = Inventory.GetId(_databasePath, Ammo_Manufacturer, Ammo_Name, Ammo_Caliber, Ammo_Grain, Ammo_Jacket, Ammo_Qty, Ammo_DCal, Ammo_VelocityNumber, out _errOut);
                bool value = GlobalList.Delete(_databasePath, id, out _errOut);
            }
        }
        /// <summary>
        /// Verifies the exists.
        /// </summary>
        private void VerifyExists()
        {
            if (!Inventory.Exists(_databasePath, Ammo_Manufacturer, Ammo_Name, Ammo_Caliber, Ammo_Grain, Ammo_Jacket, Ammo_DCal, Ammo_VelocityNumber, out _errOut))
            {
                bool value = Inventory.Add(_databasePath, Ammo_Manufacturer, Ammo_Name, Ammo_Caliber, Ammo_Grain, Ammo_Jacket, Ammo_Qty, Ammo_DCal, Ammo_VelocityNumber, out _errOut);
            }
        }
        /// <summary>
        /// Defines the test method AddTest.
        /// </summary>
        [TestMethod, TestCategory("Ammo Inventory")]
        public void AddTest()
        {
            VerifyDoesntExist();
            bool value = Inventory.Add(_databasePath, Ammo_Manufacturer, Ammo_Name, Ammo_Caliber, Ammo_Grain, Ammo_Jacket, Ammo_Qty, Ammo_DCal, Ammo_VelocityNumber, out _errOut);
            General.HasTrueValue(value, _errOut);
        }

        [TestMethod, TestCategory("Ammo Inventory")]
        public void ExistsTest()
        {
            VerifyExists();
            bool value = Inventory.Exists(_databasePath, Ammo_Manufacturer, Ammo_Name, Ammo_Caliber, Ammo_Grain,
                Ammo_Jacket, Ammo_DCal, Ammo_VelocityNumber, out _errOut);
            General.HasTrueValue(value, _errOut);
        }

        [TestMethod, TestCategory("Ammo Inventory")]
        public void UpdateTest()
        {
            VerifyExists();
            long id = Inventory.GetId(_databasePath, Ammo_Manufacturer, Ammo_Name, Ammo_Caliber, Ammo_Grain, Ammo_Jacket, Ammo_Qty, Ammo_DCal, Ammo_VelocityNumber, out _errOut);
            bool value = Inventory.Update(_databasePath, id,Ammo_Manufacturer, Ammo_Name, Ammo_Caliber, Ammo_Grain,
                Ammo_Jacket, Ammo_Qty + 100, Ammo_DCal, Ammo_VelocityNumber, out _errOut);
            General.HasTrueValue(value, _errOut);
        }

        [TestMethod, TestCategory("Ammo Inventory")]
        public void UpdateQtyTest()
        {
            VerifyExists();
            long id = Inventory.GetId(_databasePath, Ammo_Manufacturer, Ammo_Name, Ammo_Caliber, Ammo_Grain, Ammo_Jacket, Ammo_Qty, Ammo_DCal, Ammo_VelocityNumber, out _errOut);
            long before = Inventory.GetQty(_databasePath, id, out _errOut);
            int addQty = 500;
            bool value = Inventory.UpdateQty(_databasePath, id,  before, addQty, out _errOut);
            long after = Inventory.GetQty(_databasePath, id, out _errOut);
            string status = value ? "PASSEd! " : "FAILED! ";
            TestContext.WriteLine($"{status}  Attempt to add {addQty} to {before} and after the attempt we have {after}");
            General.HasTrueValue(value, _errOut);
        }

        [TestMethod, TestCategory("Ammo Inventory")]
        public void DeleteTest()
        {
            VerifyExists();
            long id = Inventory.GetId(_databasePath, Ammo_Manufacturer, Ammo_Name, Ammo_Caliber, Ammo_Grain, Ammo_Jacket, Ammo_Qty, Ammo_DCal, Ammo_VelocityNumber, out _errOut);
            bool value = Inventory.Delete(_databasePath, id,  out _errOut);
            General.HasTrueValue(value, _errOut);
        }

        [TestMethod, TestCategory("Ammo Inventory")]
        public void GetIdTest()
        {
            VerifyExists();
            long id = Inventory.GetId(_databasePath, Ammo_Manufacturer, Ammo_Name, Ammo_Caliber, Ammo_Grain, Ammo_Jacket, Ammo_Qty, Ammo_DCal, Ammo_VelocityNumber, out _errOut);
            TestContext.WriteLine($"id: {id}");
            General.HasTrueValue(id > 0, _errOut);
        }

        [TestMethod, TestCategory("Ammo Inventory")]
        public void GetLastAmmoIdTest()
        {
            VerifyExists();
            long id = Inventory.GetLastAmmoId(_databasePath,  out _errOut);
            TestContext.WriteLine($"id: {id}");
            General.HasTrueValue(id > 0, _errOut);
        }

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

        [TestMethod, TestCategory("Ammo Inventory")]
        public void GetListByID()
        {
            VerifyExists();
            long id = Inventory.GetLastAmmoId(_databasePath, out _errOut);
            List<Ammunition> value = Inventory.GetList(_databasePath, id,out  _errOut);
            PrintList(value);
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        [TestMethod, TestCategory("Ammo Inventory")]
        public void GetListByName()
        {
            VerifyExists();
            
            List<Ammunition> value = Inventory.GetList(_databasePath, Ammo_Name, Ammo_Manufacturer, Ammo_Caliber, out _errOut);
            PrintList(value);
            General.HasTrueValue(value.Count > 0, _errOut);
        }

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
