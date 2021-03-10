using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using System.Windows.Forms;

namespace BurnSoft.Applications.MGC.UnitTest.AutoFill
{
    [TestClass]
    public class AmmoTest
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
        [TestMethod, TestCategory("AutoFill - Ammo")]
        public void NameTest()
        {
            AutoCompleteStringCollection value = MGC.AutoFill.Ammo.Name(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method CaliberTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Ammo")]
        public void CaliberTest()
        {
            AutoCompleteStringCollection value = MGC.AutoFill.Ammo.Caliber(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method GrainTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Ammo")]
        public void GrainTest()
        {
            AutoCompleteStringCollection value = MGC.AutoFill.Ammo.Grain(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method JacketTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Ammo")]
        public void JacketTest()
        {
            AutoCompleteStringCollection value = MGC.AutoFill.Ammo.Jacket(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method ManufacturerTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Ammo")]
        public void ManufacturerTest()
        {
            AutoCompleteStringCollection value = MGC.AutoFill.Ammo.Manufacturer(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
    }
}
