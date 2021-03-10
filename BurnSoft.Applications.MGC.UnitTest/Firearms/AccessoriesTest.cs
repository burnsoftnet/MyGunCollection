using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BurnSoft.Applications.MGC.Firearms;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using BurnSoft.Universal;

namespace BurnSoft.Applications.MGC.UnitTest.Firearms
{
    [TestClass]
    public class AccessoriesTest
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
        /// The database path
        /// </summary>
        private string _databasePath;
        /// <summary>
        /// The accessories manufacturer
        /// </summary>
        private string Accessories_Manufacturer;
        /// <summary>
        /// The accessories name
        /// </summary>
        private string Accessories_Name;
        /// <summary>
        /// The accessories serial number
        /// </summary>
        private string Accessories_serialNumber;
        /// <summary>
        /// The accessories condition
        /// </summary>
        private string Accessories_condition;
        /// <summary>
        /// The accessories notes
        /// </summary>
        private string Accessories_notes;
        /// <summary>
        /// The accessories use
        /// </summary>
        private string Accessories_use;
        /// <summary>
        /// The accessories pur value
        /// </summary>
        private double Accessories_purValue;
        /// <summary>
        /// The accessories application value
        /// </summary>
        private double Accessories_appValue;
        /// <summary>
        /// The accessories civ
        /// </summary>
        private bool Accessories_civ;
        /// <summary>
        /// The accessories ic
        /// </summary>
        private bool Accessories_ic;
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
            Accessories_Manufacturer = obj.FC(Vs2019.GetSetting("Accessories_Manufacturer", TestContext));
            Accessories_Name = obj.FC(Vs2019.GetSetting("Accessories_Name", TestContext));
            Accessories_serialNumber = obj.FC(Vs2019.GetSetting("Accessories_serialNumber", TestContext));
            Accessories_condition = obj.FC(Vs2019.GetSetting("Accessories_condition", TestContext));
            Accessories_notes = obj.FC(Vs2019.GetSetting("Accessories_notes", TestContext));
            Accessories_use = obj.FC(Vs2019.GetSetting("Accessories_use", TestContext));
            Accessories_purValue =Vs2019.DGetSetting("Accessories_purValue", TestContext);
            Accessories_appValue = Vs2019.DGetSetting("Accessories_appValue", TestContext);
            Accessories_civ = Vs2019.BGetSetting("Accessories_civ", TestContext);
            Accessories_ic = Vs2019.BGetSetting("Accessories_ic", TestContext);
        }
        /// <summary>
        /// Verifies the doesnt exist.
        /// </summary>
        private void VerifyDoesntExist()
        {
            if (Accessories.Exists(_databasePath, _gunId, Accessories_Manufacturer, Accessories_Name,
                Accessories_serialNumber, Accessories_condition, Accessories_notes, Accessories_use,
                Accessories_purValue, Accessories_appValue, Accessories_civ, Accessories_ic, out _errOut))
            {
                long id = Accessories.GetId(_databasePath, _gunId, Accessories_Manufacturer, Accessories_Name,
                    Accessories_serialNumber, Accessories_condition, Accessories_notes, Accessories_use,
                    Accessories_purValue, Accessories_appValue, Accessories_civ, Accessories_ic, out _errOut);
                Accessories.Delete(_databasePath, id, out _errOut);
            }
        }
        /// <summary>
        /// Verifies the exists.
        /// </summary>
        private void VerifyExists()
        {
            if (!Accessories.Exists(_databasePath, _gunId, Accessories_Manufacturer, Accessories_Name,
                Accessories_serialNumber, Accessories_condition, Accessories_notes, Accessories_use,
                Accessories_purValue, Accessories_appValue, Accessories_civ, Accessories_ic, out _errOut))
            {
                Accessories.Add(_databasePath, _gunId, Accessories_Manufacturer, Accessories_Name,
                    Accessories_serialNumber, Accessories_condition, Accessories_notes, Accessories_use,
                    Accessories_purValue, Accessories_appValue, Accessories_civ, Accessories_ic, out _errOut);
            }
        }
        /// <summary>
        /// Defines the test method AddTest.
        /// </summary>
        [TestMethod, TestCategory("Accessories")]
        public void AddTest()
        {
            VerifyDoesntExist();
            bool value = Accessories.Add(_databasePath, _gunId, Accessories_Manufacturer, Accessories_Name,
                Accessories_serialNumber, Accessories_condition, Accessories_notes, Accessories_use,
                Accessories_purValue, Accessories_appValue, Accessories_civ, Accessories_ic, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method ExistsTest.
        /// </summary>
        [TestMethod, TestCategory("Accessories")]
        public void ExistsTest()
        {
            VerifyExists();
            bool value = Accessories.Exists(_databasePath, _gunId, Accessories_Manufacturer, Accessories_Name,
                Accessories_serialNumber, Accessories_condition, Accessories_notes, Accessories_use,
                Accessories_purValue, Accessories_appValue, Accessories_civ, Accessories_ic, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method GetId.
        /// </summary>
        [TestMethod, TestCategory("Accessories")]
        public void GetId()
        {
            VerifyExists();
            long value = Accessories.GetId(_databasePath, _gunId, Accessories_Manufacturer, Accessories_Name,
                Accessories_serialNumber, Accessories_condition, Accessories_notes, Accessories_use,
                Accessories_purValue, Accessories_appValue, Accessories_civ, Accessories_ic, out _errOut);
            TestContext.WriteLine($"ID = {value}");
            General.HasTrueValue(value > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method DeleteTest.
        /// </summary>
        [TestMethod, TestCategory("Accessories")]
        public void DeleteTest()
        {
            VerifyExists();
            long id = Accessories.GetId(_databasePath, _gunId, Accessories_Manufacturer, Accessories_Name,
                Accessories_serialNumber, Accessories_condition, Accessories_notes, Accessories_use,
                Accessories_purValue, Accessories_appValue, Accessories_civ, Accessories_ic, out _errOut);
            bool value = Accessories.Delete(_databasePath, id, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
    }
}
