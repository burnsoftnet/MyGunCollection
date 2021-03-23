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
    public class GunSmithsTest
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

        private string GunSmith_Name;

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
            GunSmith_Name = obj.FC(Vs2019.GetSetting("GunSmith_Name", TestContext));

        }
        /// <summary>
        /// Verifies the doesnt exist.
        /// </summary>
        private void VerifyDoesntExist()
        {
            if (GunSmiths.Exists(_databasePath, GunSmith_Name, out _errOut))
            {
                long id = GunSmiths.GetId(_databasePath, GunSmith_Name, out _errOut);
                bool value = GunSmiths.Delete(_databasePath, id, out _errOut);
            }
        }
        /// <summary>
        /// Verifies the exists.
        /// </summary>
        private void VerifyExists()
        {
            if (!GunSmiths.Exists(_databasePath, GunSmith_Name, out _errOut))
            {
                bool value = GunSmiths.Add(_databasePath, GunSmith_Name, out _errOut);
            }
        }
        /// <summary>
        /// Defines the test method AddTest.
        /// </summary>
        [TestMethod, TestCategory("Gunsmith Contact list")]
        public void AddQuickTest()
        {
            VerifyDoesntExist();
            bool value = GunSmiths.Add(_databasePath, GunSmith_Name, out _errOut);
            General.HasTrueValue(value, _errOut);
        }
    }
}
