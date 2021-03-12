using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable InconsistentNaming

namespace BurnSoft.Applications.MGC.UnitTest.Settings
{
    /// <summary>
    /// Class VS2019. Seetings class that will allow me to put setting in this section or a unit test settings file if that is working.
    /// This was created because my unit test file from VS2017 would not work in VS2019, so this function was created to allow either or
    /// when the settings file is available.
    /// </summary>
    public class Vs2019
    {
        /// <summary>
        /// Gets or sets the test context.
        /// </summary>
        /// <value>The test context.</value>
        public TestContext TestContext { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Vs2019"/> class.
        /// </summary>
        /// <param name="con">The con.</param>
        public Vs2019(TestContext con)
        {
            TestContext = con;
        }
        /// <summary>
        /// Generals the settings.
        /// </summary>
        /// <returns>List&lt;Tuple&lt;System.String, System.String&gt;&gt;.</returns>
        private static List<Tuple<string, string>> GeneralSettings()
        {
            string testCaliber = @"10mm gunny";
            List<Tuple<string, string>> ls = new List<Tuple<string, string>>();
            ls.Add(new Tuple<string, string>("DatabasePath", "data\\mgc.mdb"));
            ls.Add(new Tuple<string, string>("MyGunCollectionID", "3"));
            ls.Add(new Tuple<string, string>("MyGunCollection_ShopOldName", "Mike's Guns"));
            ls.Add(new Tuple<string, string>("MyGunCollection_ShopNewName", "Mikes Guns"));
            ls.Add(new Tuple<string, string>("ManufacturersTestName", "OpenGlock"));
            ls.Add(new Tuple<string, string>("Accessories_Manufacturer", "Glock"));
            ls.Add(new Tuple<string, string>("Accessories_Name", "21 Round Mag"));
            ls.Add(new Tuple<string, string>("Accessories_serialNumber", "N/A"));
            ls.Add(new Tuple<string, string>("Accessories_condition", "New"));
            ls.Add(new Tuple<string, string>("Accessories_notes", "extra mag's for the gun"));
            ls.Add(new Tuple<string, string>("Accessories_use", "Extra Mag"));
            ls.Add(new Tuple<string, string>("Accessories_purValue", "19.95"));
            ls.Add(new Tuple<string, string>("Accessories_appValue", "10.00"));
            ls.Add(new Tuple<string, string>("Accessories_civ", "true"));
            ls.Add(new Tuple<string, string>("Accessories_ic", "true"));
            ls.Add(new Tuple<string, string>("Model_LookUp", "Glock"));
            ls.Add(new Tuple<string, string>("Caliber_Test", testCaliber));
            ls.Add(new Tuple<string, string>("Ammo_Id", "12"));
            ls.Add(new Tuple<string, string>("Ammo_Manufacturer", "WildCats"));
            ls.Add(new Tuple<string, string>("Ammo_Name", "WildCats 10mm gunny"));
            ls.Add(new Tuple<string, string>("Ammo_Caliber", testCaliber));
            ls.Add(new Tuple<string, string>("Ammo_Grain", "500"));
            ls.Add(new Tuple<string, string>("Ammo_Jacket", "FMJ Gold"));
            ls.Add(new Tuple<string, string>("Ammo_Qty", "100"));
            ls.Add(new Tuple<string, string>("Ammo_DCal", "500"));
            ls.Add(new Tuple<string, string>("Ammo_VelocityNumber", "2000"));
            ls.Add(new Tuple<string, string>("Shops_Name", "Gunny's Big Ass Guns"));
            ls.Add(new Tuple<string, string>("Shops_Name_Existing", "Mike's Guns"));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_DefaultId", "1"));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_ModelName", ""));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_Caliber", ""));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_Finish", ""));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_BarrelLength", ""));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_PetLoads", ""));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_Action", ""));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_Feedsystem", ""));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_Sights", ""));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_PurchasedPrice", ""));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_PurchasedFrom", ""));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_", ""));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_", ""));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_", ""));
            ls.Add(new Tuple<string, string>("BarrelConvoKit_Add_", ""));
            //ls.Add(new Tuple<string, string>("", ""));
            return ls;
        }
        /// <summary>
        /// Gets the settings.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        private static string GetSettings(string value)
        {
            string sAns = @"";
            List<Tuple<string, string>> ls = GeneralSettings();
            foreach (Tuple<string, string> l in ls)
            {
                if (l.Item1.Equals(value))
                {
                    sAns = l.Item2;
                    break;
                }
            }
            return sAns;
        }
        /// <summary>
        /// Gets the settings.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="con">The con.</param>
        /// <returns>System.String.</returns>
        private static string GetSettings(string value, TestContext con)
        {
            string sAns;

            Vs2019 obj = new Vs2019(con);
            if (obj.TestSettingsLoaded(value))
            {
                sAns = con.Properties[value].ToString();
            }
            else
            {
                sAns = GetSetting(value);
            }

            return sAns;
        }
        /// <summary>
        /// Tests the settings loaded.
        /// </summary>
        /// <param name="property">The property.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool TestSettingsLoaded(string property)
        {
            bool bAns = false;
            try
            {
                if (TestContext != null)
                {
                    if (TestContext.Properties[property] != null)
                    {
                        string value = TestContext.Properties[property].ToString();
                        bAns = value.Length > 0;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return bAns;
        }
        /// <summary>
        /// Gets the setting.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string GetSetting(string value) => GetSettings(value);
        /// <summary>
        /// is the get setting.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.Int32.</returns>
        public static int IGetSetting(string value) => Convert.ToInt32(GetSettings(value));
        /// <summary>
        /// ds the get setting.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.Double.</returns>
        public static double DGetSetting(string value) => Convert.ToDouble(GetSettings(value));
        /// <summary>
        /// bs the get setting.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool BGetSetting(string value) => Convert.ToBoolean(GetSettings(value));
        /// <summary>
        /// Gets the setting.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="con">The con.</param>
        /// <returns>System.String.</returns>
        public static string GetSetting(string value, TestContext con) => GetSettings(value, con);
        /// <summary>
        /// is the get setting.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="con">The con.</param>
        /// <returns>System.Int32.</returns>
        public static int IGetSetting(string value, TestContext con) => Convert.ToInt32(GetSettings(value, con));
        /// <summary>
        /// ds the get setting.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="con">The con.</param>
        /// <returns>System.Double.</returns>
        public static double DGetSetting(string value, TestContext con) => Convert.ToDouble(GetSettings(value, con));
        /// <summary>
        /// bs the get setting.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="con">The con.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool BGetSetting(string value, TestContext con) => Convert.ToBoolean(GetSettings(value, con));
    }
}
