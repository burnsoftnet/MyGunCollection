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
        /// The database path
        /// </summary>
        private string _databasePath;
        /// <summary>
        /// The classification name
        /// </summary>
        private string _classificationName;
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
            _classificationName = obj.FC(Vs2019.GetSetting("Classification_Name", TestContext));
        }

        /// <summary>
        /// Verifies the doesnt exist.
        /// </summary>
        private void VerifyDoesntExist()
        {
            if (Classification.Exists(_databasePath, _classificationName, out _errOut))
            {
                long id = Classification.GetId(_databasePath, _classificationName, out _errOut);
                Classification.Delete(_databasePath, id, out _errOut);
            }
        }
        /// <summary>
        /// Verifies the exists.
        /// </summary>
        private void VerifyExists()
        {
            if (!Classification.Exists(_databasePath, _classificationName, out _errOut))
            {
                Classification.Add(_databasePath, _classificationName, out _errOut);
            }
        }
        /// <summary>
        /// Defines the test method AddTest.
        /// </summary>
        [TestMethod]
        public void AddTest()
        {
            VerifyDoesntExist();
            bool value = Classification.Add(_databasePath, _classificationName, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method ExistsTest.
        /// </summary>
        [TestMethod]
        public void ExistsTest()
        {
            VerifyExists();
            bool value = Classification.Exists(_databasePath, _classificationName, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method GetIdTest.
        /// </summary>
        [TestMethod]
        public void GetIdTest()
        {
            VerifyExists();
            long value = Classification.GetId(_databasePath, _classificationName, out _errOut);
            TestContext.WriteLine($"ID: {value}");
            General.HasTrueValue(value > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method DeleteTest.
        /// </summary>
        [TestMethod]
        public void DeleteTest()
        {
            VerifyExists();
            long id = Classification.GetId(_databasePath, _classificationName, out _errOut);
            bool value = Classification.Delete(_databasePath, id, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Lists the data.
        /// </summary>
        /// <param name="value">The value.</param>
        private void ListData(List<ClassificationList> value)
        {
            if (value.Count > 0)
            {
                foreach (ClassificationList v in value)
                {
                    TestContext.WriteLine($"");
                    TestContext.WriteLine($"id: {v.Id}");
                    TestContext.WriteLine($"Class Name: {v.Name}");
                    TestContext.WriteLine($"Last Sync: {v.LastSync}");
                    TestContext.WriteLine($"");
                    TestContext.WriteLine($"--------------------------------------");
                    TestContext.WriteLine($"");
                }
            }
        }
        /// <summary>
        /// Defines the test method ListsTest.
        /// </summary>
        [TestMethod]
        public void ListsTest()
        {
            VerifyExists();
            List<ClassificationList> value = Classification.Lists(_databasePath, out _errOut);
            ListData(value);
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method ListsByNameTest.
        /// </summary>
        [TestMethod]
        public void ListsByNameTest()
        {
            VerifyExists();
            List<ClassificationList> value = Classification.Lists(_databasePath,_classificationName, out _errOut);
            ListData(value);
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method InUseInCollectionTest.
        /// </summary>
        [TestMethod]
        public void InUseInCollectionTest()
        {
            VerifyExists();
            bool value = Classification.IsNotInUse(_databasePath, _classificationName, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
    }
}
