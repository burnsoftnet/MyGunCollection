using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BurnSoft.Applications.MGC.Firearms;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using BurnSoft.Universal;

namespace BurnSoft.Applications.MGC.UnitTest.Firearms
{
    [TestClass]
    public class ClassifcationTest
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
        /// The classification name
        /// </summary>
        private string Classification_Name;
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
            Classification_Name = obj.FC(Vs2019.GetSetting("Classification_Name", TestContext));
        }

        /// <summary>
        /// Verifies the doesnt exist.
        /// </summary>
        private void VerifyDoesntExist()
        {
            if (Classification.Exists(_databasePath, Classification_Name, out _errOut))
            {
                long id = Classification.GetId(_databasePath, Classification_Name, out _errOut);
                Classification.Delete(_databasePath, id, out _errOut);
            }
        }
        /// <summary>
        /// Verifies the exists.
        /// </summary>
        private void VerifyExists()
        {
            if (!Classification.Exists(_databasePath, Classification_Name, out _errOut))
            {
                Classification.Add(_databasePath, Classification_Name, out _errOut);
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
