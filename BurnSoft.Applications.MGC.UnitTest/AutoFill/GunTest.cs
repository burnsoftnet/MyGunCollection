using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using System.Windows.Forms;
using BurnSoft.Applications.MGC.AutoFill;
namespace BurnSoft.Applications.MGC.UnitTest.AutoFill
{
    [TestClass]
    public class GunTest
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
        [TestMethod, TestCategory("AutoFill - Gun")]
        public void TypeTest()
        {
            AutoCompleteStringCollection value = Gun.Type(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method ShopDetailsTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Gun")]
        public void ShopDetailsTest()
        {
            AutoCompleteStringCollection value = Gun.ShopDetails(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method CalTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Gun")]
        public void CalTest()
        {
            AutoCompleteStringCollection value = Gun.Cal(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method ModelTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Gun")]
        public void ModelTest()
        {
            AutoCompleteStringCollection value = Gun.Model(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method GripTypeTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Gun")]
        public void GripTypeTest()
        {
            AutoCompleteStringCollection value = Gun.GripType(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method ManufacturerTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Gun")]
        public void ManufacturerTest()
        {
            AutoCompleteStringCollection value = Gun.Manufacturer(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method ModelByManufacturerTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Gun")]
        public void ModelByManufacturerTest()
        {
            AutoCompleteStringCollection value = Gun.ModelByManufacturer(_databasePath, "Glock", out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method NationalityTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Gun")]
        public void NationalityTest()
        {
            AutoCompleteStringCollection value = Gun.Nationality(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
    }
}
