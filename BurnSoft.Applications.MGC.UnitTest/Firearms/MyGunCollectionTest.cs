using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BurnSoft.Applications.MGC;
using BurnSoft.Applications.MGC.Firearms;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Applications.MGC.UnitTest.Settings;

namespace BurnSoft.Applications.MGC.UnitTest.Firearms
{
    [TestClass]
    public class MyGunCollectionTest
    {
        /// <summary>
        /// Gets or sets the test context.
        /// </summary>
        /// <value>The test context.</value>
        public TestContext TestContext { get; set; }
        /// <summary>
        /// The error out
        /// </summary>
        private string errOut;
        /// <summary>
        /// The gun identifier
        /// </summary>
        private int GunID;
        /// <summary>
        /// The database path
        /// </summary>
        private string DatabasePath;

        [TestInitialize]
        public void Init()
        {
            errOut = @"";
            DatabasePath = Vs2019.GetSetting("DatabasePath", TestContext);
            GunID = Vs2019.IGetSetting("MyGunCollectionID", TestContext);
        }
        [TestMethod, TestCategory("")]
        public void GetList()
        {
            List<GunCollectionList> value = MyCollection.GetList(DatabasePath, GunID, out errOut);
            if (value.Count > 0)
            {
                foreach (GunCollectionList g in value)
                {
                    TestContext.Write($"id : {g.Id}");
                    TestContext.Write($"Full Name: {g.FullName}");
                    TestContext.Write($"");
                    TestContext.Write($"");
                    TestContext.Write($"--------------------------------------");
                    TestContext.Write($"");
                }
            }

            General.HasTrueValue(value.Count > 0, errOut);
        }
    }
}
