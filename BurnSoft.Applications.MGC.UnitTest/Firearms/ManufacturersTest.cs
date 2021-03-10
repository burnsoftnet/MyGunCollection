using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.Applications.MGC.Firearms;
using BurnSoft.Applications.MGC.UnitTest.Settings;

namespace BurnSoft.Applications.MGC.UnitTest.Firearms
{
    [TestClass]
    public class ManufacturersTest
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
        /// The manufacturers test name
        /// </summary>
        private string _manufacturersTestName;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("", TestContext);
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath", TestContext);
            _manufacturersTestName = Vs2019.GetSetting("ManufacturersTestName", TestContext);
        }
        /// <summary>
        /// Verifies the exists in case the test runs out of order this will makre sure that the data is in the database.
        /// </summary>
        private void VerifyExists()
        {
            if (!Manufacturers.Exists(_databasePath, _manufacturersTestName, out _errOut))
            {
                Manufacturers.Add(_databasePath, _manufacturersTestName, out _errOut);
            }
        }
        /// <summary>
        /// Verifies the does not exist in the database before the test runs just in case it runs out of order
        /// </summary>
        private void VerifyDoesNotExist()
        {
            if (Manufacturers.Exists(_databasePath, _manufacturersTestName, out _errOut))
            {
                long id = Manufacturers.GetId(_databasePath, _manufacturersTestName, out _errOut);
                Manufacturers.Delete(_databasePath, id, out _errOut);
            }
        }
        /// <summary>
        /// Defines the test method AddTest.
        /// </summary>
        [TestMethod,TestCategory("Manufacturers")]
        public void AddTest()
        {
            VerifyDoesNotExist();
            bool value = Manufacturers.Add(_databasePath, _manufacturersTestName, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method ExistsTest.
        /// </summary>
        [TestMethod, TestCategory("Manufacturers")]
        public void ExistsTest()
        {
            VerifyExists();
            bool value = Manufacturers.Exists(_databasePath, _manufacturersTestName, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method GetIdTest.
        /// </summary>
        [TestMethod, TestCategory("Manufacturers")]
        public void GetIdTest()
        {
            VerifyExists();
            long id = Manufacturers.GetId(_databasePath, _manufacturersTestName, out _errOut);
            General.HasValue(id.ToString(), _errOut);
        }
        /// <summary>
        /// Defines the test method UpdateTest.
        /// </summary>
        [TestMethod, TestCategory("Manufacturers")]
        public void UpdateTest()
        {
            VerifyExists();
            long id = Manufacturers.GetId(_databasePath, _manufacturersTestName, out _errOut);
            bool value = Manufacturers.Update(_databasePath, id, $"{_manufacturersTestName}-Test", out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method DeleteTest.
        /// </summary>
        [TestMethod, TestCategory("Manufacturers")]
        public void DeleteTest()
        {
            VerifyExists();
            long id = Manufacturers.GetId(_databasePath, _manufacturersTestName, out _errOut);
            bool value = Manufacturers.Delete(_databasePath, id,  out _errOut);
            General.HasTrueValue(value, _errOut);
        }
    }
}
