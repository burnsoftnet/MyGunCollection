using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.Applications.MGC.Ammo;
using BurnSoft.Applications.MGC.PeopleAndPlaces;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using BurnSoft.Universal;
// ReSharper disable UnusedVariable
// ReSharper disable UnusedMember.Local
// ReSharper disable NotAccessedField.Local

namespace BurnSoft.Applications.MGC.UnitTest.PeopleAndPlaces
{
    [TestClass]
    public class ShopsTest
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
        /// The shop name
        /// </summary>
        private string _shopsName;
        /// <summary>
        /// The shops name existing
        /// </summary>
        private string _shopsNameExisting;
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
            _shopsName = obj.FC(Vs2019.GetSetting("Shops_Name", TestContext));
            _shopsNameExisting = obj.FC(Vs2019.GetSetting("Shops_Name_Existing", TestContext));

        }
        /// <summary>
        /// Verifies the doesnt exist.
        /// </summary>
        private void VerifyDoesntExist()
        {
            if (Shops.Exists(_databasePath, _shopsName, out _errOut))
            {
                long id = Shops.GetId(_databasePath, _shopsName, out _errOut);
                bool value = GlobalList.Delete(_databasePath, id, out _errOut);
            }
        }
        /// <summary>
        /// Verifies the exists.
        /// </summary>
        private void VerifyExists()
        {
            if (!Shops.Exists(_databasePath, _shopsName, out _errOut))
            {
                bool value = Shops.Add(_databasePath, _shopsName, out _errOut);
            }
        }
        /// <summary>
        /// Defines the test method AddTest.
        /// </summary>
        [TestMethod, TestCategory("Shops")]
        public void AddQuickTest()
        {
            VerifyDoesntExist();
            bool value = Shops.Add(_databasePath, _shopsName, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method ExistsTest.
        /// </summary>
        [TestMethod, TestCategory("Shops")]
        public void ExistsTest()
        {
            VerifyExists();
            bool value = Shops.Exists(_databasePath, _shopsName, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method CountTest.
        /// </summary>
        [TestMethod, TestCategory("Shops")]
        public void CountTest()
        {
            VerifyExists(); 
            int value = Shops.Count(_databasePath, _shopsName, out _errOut);
            TestContext.WriteLine($"Number of shops: {value}");
            General.HasTrueValue(value > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method GetIdTest.
        /// </summary>
        [TestMethod, TestCategory("Shops")]
        public void GetIdTest()
        {
            VerifyExists();
            long value = Shops.GetId(_databasePath, _shopsName, out _errOut);
            TestContext.WriteLine($"ids: {value}");
            General.HasTrueValue(value > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method HasCollectionAttachedTest.
        /// </summary>
        [TestMethod, TestCategory("Shops")]
        public void HasCollectionAttachedTest()
        {
            VerifyExists();
            long id = Shops.GetId(_databasePath, _shopsNameExisting, out _errOut);
            int value = Shops.HasCollectionAttached(_databasePath, id,out _errOut);
            TestContext.WriteLine($"firearm count in shop: {value}");
            General.HasTrueValue(value > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method DeleteTest.
        /// </summary>
        [TestMethod, TestCategory("Shops")]
        public void DeleteTest()
        {
            VerifyExists();
            long id = Shops.GetId(_databasePath, _shopsName, out _errOut);
            bool value = Shops.Delete(_databasePath, id, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
        /// <summary>
        /// Defines the test method GetNameTest.
        /// </summary>
        [TestMethod, TestCategory("Shops")]
        public void GetNameTest()
        {
            VerifyExists();
            long id = Shops.GetId(_databasePath, _shopsName, out _errOut);
            string value = Shops.GetName(_databasePath, id, out _errOut);

            General.HasValue(value, _errOut);
        }
        /// <summary>
        /// Prints the list.
        /// </summary>
        /// <param name="value">The value.</param>
        private void PrintList(List<GunShopDetails> value)
        {
            if (value.Count > 0)
            {
                foreach (GunShopDetails g in value)
                {
                    TestContext.WriteLine($"id: {g.Id}");
                    TestContext.WriteLine($"Name: {g.Name}");
                    TestContext.WriteLine($"Address: {g.Address1}");
                    TestContext.WriteLine($"Address2: {g.Address2}");
                    TestContext.WriteLine($"City: {g.City}");
                    TestContext.WriteLine($"State: {g.State}");
                    TestContext.WriteLine($"Zip Code: {g.ZipCode}");
                    TestContext.WriteLine($"Country: {g.Country}");
                    TestContext.WriteLine($"Phone: {g.Phone}");
                    TestContext.WriteLine($"Website: {g.WebSite}");
                    TestContext.WriteLine($"License: {g.Lic}");
                    TestContext.WriteLine($"Fax: {g.Fax}");
                    TestContext.WriteLine($"Still in Business: {g.StillInBusiness}");
                    TestContext.WriteLine($"");
                    TestContext.WriteLine($"-------------------------------------");
                    TestContext.WriteLine($"");
                }
            }
        }
        /// <summary>
        /// Defines the test method GetByIdTest.
        /// </summary>
        [TestMethod, TestCategory("Shops")]
        public void GetByIdTest()
        {
            VerifyExists();
            long id = Shops.GetId(_databasePath, _shopsName, out _errOut);
            List<GunShopDetails> value = Shops.Get(_databasePath, id, out _errOut);
            PrintList(value);
            General.HasTrueValue(value.Count > 0, _errOut);
        }
        /// <summary>
        /// Defines the test method GetTest.
        /// </summary>
        [TestMethod, TestCategory("Shops")]
        public void GetTest()
        {
            List<GunShopDetails> value = Shops.Get(_databasePath, out _errOut);
            PrintList(value);
            General.HasTrueValue(value.Count > 0, _errOut);
        }
    }
}
