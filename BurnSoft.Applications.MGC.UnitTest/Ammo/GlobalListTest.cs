using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.Applications.MGC.Ammo;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using BurnSoft.Universal;
// ReSharper disable UnusedVariable

namespace BurnSoft.Applications.MGC.UnitTest.Ammo
{
    [TestClass]
    public class GlobalListTest
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
        /// The caliber test
        /// </summary>
        private string _caliberTest;
        /// <summary>
        /// The caliber test update
        /// </summary>
        private string _caliberTestUpdate;
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
            _caliberTest = Vs2019.GetSetting("Caliber_Test", TestContext);
            _caliberTestUpdate = $"{_caliberTest}-UPDATEd";
        }
        /// <summary>
        /// Verifies the doesnt exist.
        /// </summary>
        private void VerifyDoesntExist()
        {
            if (GlobalList.Exists(_databasePath, _caliberTest, out _errOut))
            {
                long id = GlobalList.GetId(_databasePath, _caliberTest, out _errOut);
                bool value = GlobalList.Delete(_databasePath, id, out _errOut);
            }

            if (GlobalList.Exists(_databasePath, _caliberTestUpdate, out _errOut))
            {
                long id = GlobalList.GetId(_databasePath, _caliberTestUpdate, out _errOut);
                bool value = GlobalList.Delete(_databasePath, id, out _errOut);
            }
        }
        /// <summary>
        /// Verifies the exists.
        /// </summary>
        private void VerifyExists()
        {
            if (!GlobalList.Exists(_databasePath, _caliberTest, out _errOut))
            {
                bool value = GlobalList.Add(_databasePath, _caliberTest, out _errOut);
            }
        }
        /// <summary>
        /// Defines the test method AddTest.
        /// </summary>
        [TestMethod, TestCategory("Caliber Global Listt")]
        public void AddTest()
        {
            VerifyDoesntExist();
            bool value = GlobalList.Add(_databasePath, _caliberTest, out _errOut);
            General.HasTrueValue(value, _errOut);
        }

        
        [TestMethod, TestCategory("Caliber Global Listt")]
        public void ExistsTest()
        {
            VerifyExists();
            bool value = GlobalList.Exists(_databasePath, _caliberTest, out _errOut);
            General.HasTrueValue(value, _errOut);
        }

        [TestMethod, TestCategory("Caliber Global Listt")]
        public void GetIdTest()
        {
            VerifyExists();
            long id = GlobalList.GetId(_databasePath, _caliberTest, out _errOut);
            TestContext.WriteLine($"IS: {id}");
            General.HasTrueValue(id > 0, _errOut);
        }

        [TestMethod, TestCategory("Caliber Global Listt")]
        public void UpdateTest()
        {
            VerifyDoesntExist();
            VerifyExists();
            long id = GlobalList.GetId(_databasePath, _caliberTest, out _errOut);
            bool value = GlobalList.Update(_databasePath,id, _caliberTestUpdate, out _errOut);
            General.HasTrueValue(value, _errOut);
        }

        [TestMethod, TestCategory("Caliber Global Listt")]
        public void DeleteTest()
        {
            VerifyDoesntExist();
            VerifyExists();
            long id = GlobalList.GetId(_databasePath, _caliberTest, out _errOut);
            bool value = GlobalList.Delete(_databasePath, id, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
    }
}
