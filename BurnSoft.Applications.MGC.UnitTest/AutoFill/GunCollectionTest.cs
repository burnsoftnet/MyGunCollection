using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using System.Windows.Forms;
using BurnSoft.Applications.MGC.AutoFill;

namespace BurnSoft.Applications.MGC.UnitTest.AutoFill
{
    [TestClass]
    public class GunCollectionTest
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
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("", TestContext);
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath", TestContext);
        }
        /// <summary>
        /// Defines the test method Sights test.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - GunCollection")]
        public void SightsTest()
        {
            AutoCompleteStringCollection value = GunCollection.Sights(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method StorageLocationTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - GunCollection")]
        public void StorageLocationTest()
        {
            AutoCompleteStringCollection value = GunCollection.StorageLocation(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method FinishTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - GunCollection")]
        public void FinishTest()
        {
            AutoCompleteStringCollection value = GunCollection.Finish(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method PetLoadsTests.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - GunCollection")]
        public void PetLoadsTests()
        {
            AutoCompleteStringCollection value = GunCollection.PetLoads(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method ImporterTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - GunCollection")]
        public void ImporterTest()
        {
            AutoCompleteStringCollection value = GunCollection.Importer(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method CustomIdTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - GunCollection")]
        public void CustomIdTest()
        {
            AutoCompleteStringCollection value = GunCollection.CustomId(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method BarrelSysTypesTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - GunCollection")]
        public void BarrelSysTypesTest()
        {
            AutoCompleteStringCollection value = GunCollection.BarrelSysTypes(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method FeedsystemTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - GunCollection")]
        public void FeedsystemTest()
        {
            AutoCompleteStringCollection value = GunCollection.Feedsystem(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method ActionTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - GunCollection")]
        public void ActionTest()
        {
            AutoCompleteStringCollection value = GunCollection.Action(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method ClassIII_ownerTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - GunCollection")]
        public void ClassIII_ownerTest()
        {
            AutoCompleteStringCollection value = GunCollection.ClassIII_owner(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

    }
}
