using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BurnSoft.Applications.MGC.Ammo;
using BurnSoft.Applications.MGC.Firearms;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using BurnSoft.Universal;

namespace BurnSoft.Applications.MGC.UnitTest.Ammo
{
    [TestClass]
    public class AuditTest
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
        /// The ammo identifier
        /// </summary>
        private int Ammo_Id;

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
            Ammo_Id = Vs2019.IGetSetting("Ammo_Id", TestContext);
        }
        /// <summary>
        /// Verifies the doesnt exist.
        /// </summary>
        private void VerifyDoesntExist()
        {
            
        }
        /// <summary>
        /// Verifies the exists.
        /// </summary>
        private void VerifyExists()
        {
            
        }
        /// <summary>
        /// Defines the test method AddTest.
        /// </summary>
        [TestMethod, TestCategory("Ammo Audit")]
        public void AddTest()
        {
            VerifyDoesntExist();
            bool value = Audit.Add(_databasePath, Ammo_Id, DateTime.Now.ToString(), 50, 20.00, "Home", 2, 100,
                out _errOut);
            General.HasTrueValue(value, _errOut);
        }

        /// <summary>
        /// Defines the test method DeleteTest.
        /// </summary>
        [TestMethod, TestCategory("Ammo Audit")]
        public void DeleteTest()
        {
            VerifyDoesntExist();
            bool value = Audit.Delete(_databasePath, Ammo_Id,out _errOut);
            General.HasTrueValue(value, _errOut);
        }
    }
}
