using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using System.Windows.Forms;
using BurnSoft.Applications.MGC.AutoFill;

namespace BurnSoft.Applications.MGC.UnitTest.AutoFill
{
    [TestClass]
    public class AccessoryTest
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
        /// Defines the test method ModelTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Accessory")]
        public void ModelTest()
        {
            AutoCompleteStringCollection value = Accessory.Model(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method PurchaseValueTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Accessory")]
        public void PurchaseValueTest()
        {
            AutoCompleteStringCollection value = Accessory.PurchaseValue(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method UseTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Accessory")]
        public void UseTest()
        {
            AutoCompleteStringCollection value = Accessory.Use(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method ManufacturerTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Accessory")]
        public void ManufacturerTest()
        {
            AutoCompleteStringCollection value = Accessory.Manufacturer(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
    }
}
