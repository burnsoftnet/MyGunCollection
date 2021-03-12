using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.Applications.MGC.Firearms;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using BurnSoft.Universal;


namespace BurnSoft.Applications.MGC.UnitTest.Firearms
{
    [TestClass]
    public class ExtraBarrelConvoKitsTest
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

        }
        /// <summary>
        /// Prints the list.
        /// </summary>
        /// <param name="value">The value.</param>
        private void PrintList(List<BarrelSystems> value)
        {
            if (value.Count > 0)
            {
                foreach (BarrelSystems g in value)
                {
                    TestContext.WriteLine($"id : {g.Id}");
                    TestContext.WriteLine($"Full Name: {g.FullName}");
                    TestContext.WriteLine($"Finish: {g.Finish}");
                    TestContext.WriteLine($"BarrelLength: {g.BarrelLength}");
                    TestContext.WriteLine($"Height: {g.Height}");
                    TestContext.WriteLine($"Action: {g.Action}");
                    TestContext.WriteLine($"Sights: {g.Sights}");
                    TestContext.WriteLine($"PurchasePrice: {g.PurchasedPrice}");
                    TestContext.WriteLine($"PurchaseFrom: {g.PurchasedFrom}");
                    TestContext.WriteLine($"Petloads/Caliber2: {g.PetLoads}");
                    TestContext.WriteLine($"--------------------------------------");
                    TestContext.WriteLine($"");
                }
            }
        }
        /// <summary>
        /// Defines the test method GetList.
        /// </summary>
        [TestMethod, TestCategory("Barrel/Conversion Kits")]
        public void GeCurrentBarrelDetailstListTest()
        {
            List<BarrelSystems> value = ExtraBarrelConvoKits.GetCurrentBarrelDetailstList(_databasePath, _gunId, out _errOut);
            PrintList(value);
            General.HasTrueValue(value.Count > 0, _errOut);
        }
    }
}
