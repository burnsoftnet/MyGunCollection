using System.Collections.Generic;
using BurnSoft.Applications.MGC.AutoFill;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BurnSoft.Applications.MGC.Firearms;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Applications.MGC.UnitTest.Settings;
using BurnSoft.Universal;
// ReSharper disable UnusedMember.Local


namespace BurnSoft.Applications.MGC.UnitTest.Firearms
{
    [TestClass]
    public class GunSmithDetailsTest
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
        /// The gun smith name
        /// </summary>
        private string GunSmith_Name;
        /// <summary>
        /// The gun details order details
        /// </summary>
        private string GunDetails_OrderDetails;
        /// <summary>
        /// The gun details notes
        /// </summary>
        private string GunDetails_Notes;
        /// <summary>
        /// The gun details start date
        /// </summary>
        private string GunDetails_StartDate;
        /// <summary>
        /// The gun details return date
        /// </summary>
        private string GunDetails_ReturnDate;
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
            GunSmith_Name = Vs2019.GetSetting("GunSmith_Name", TestContext);
            GunDetails_OrderDetails = Vs2019.GetSetting("GunDetails_OrderDetails", TestContext);
            GunDetails_Notes = Vs2019.GetSetting("GunDetails_Notes", TestContext);
            GunDetails_StartDate = Vs2019.GetSetting("GunDetails_StartDate", TestContext);
            GunDetails_ReturnDate = Vs2019.GetSetting("GunDetails_ReturnDate", TestContext);
        }
        /// <summary>
        /// Prints the list.
        /// </summary>
        /// <param name="value">The value.</param>
        private void PrintList(List<GunSmithWorkDone> value)
        {
            if (value.Count > 0)
            {
                foreach (GunSmithWorkDone g in value)
                {
                    TestContext.WriteLine($"id : {g.Id}");
                    TestContext.WriteLine($"Smith Name: {g.GunSmithName}");
                    TestContext.WriteLine($"Smith ID: {g.GunSmithId}");
                    TestContext.WriteLine($"Gun Id: {g.GunId}");
                    TestContext.WriteLine($"OrderDetails: {g.OrderDetails}");
                    TestContext.WriteLine($"Notes: {g.Notes}");
                    TestContext.WriteLine($"Return Date: {g.ReturnDate}");
                    TestContext.WriteLine($"Start Date: {g.StartDate}");
                    TestContext.WriteLine($"Last Updated: {g.LastSync}");
                    TestContext.WriteLine($"");
                    TestContext.WriteLine($"--------------------------------------");
                    TestContext.WriteLine($"");
                }
            }
        }
        /// <summary>
        /// Verifies the exists.
        /// </summary>
        private void VerifyExists()
        {

            if (!GunSmithDetails.Exists(_databasePath, _gunId, GunSmith_Name, GunDetails_OrderDetails, out _errOut))
            {
                if (!BurnSoft.Applications.MGC.PeopleAndPlaces.GunSmiths.Exists(_databasePath, GunSmith_Name,
                    out _errOut))
                {
                    MGC.PeopleAndPlaces.GunSmiths.Add(_databasePath, GunSmith_Name,out _errOut);
                }

                long gsid = MGC.PeopleAndPlaces.GunSmiths.GetId(_databasePath, GunSmith_Name, out _errOut);

                GunSmithDetails.Add(_databasePath, _gunId, GunSmith_Name, gsid, GunDetails_OrderDetails, GunDetails_Notes, GunDetails_StartDate, GunDetails_ReturnDate, out _errOut);

            }
        }
        /// <summary>
        /// Verifies the doesnt exist.
        /// </summary>
        private void VerifyDoesntExist()
        {
            if (GunSmithDetails.Exists(_databasePath, _gunId, GunSmith_Name, GunDetails_OrderDetails, out _errOut))
            {

                if (!BurnSoft.Applications.MGC.PeopleAndPlaces.GunSmiths.Exists(_databasePath, GunSmith_Name,
                    out _errOut))
                {
                    MGC.PeopleAndPlaces.GunSmiths.Add(_databasePath, GunSmith_Name, out _errOut);
                }

                long gsid = MGC.PeopleAndPlaces.GunSmiths.GetId(_databasePath, GunSmith_Name, out _errOut);
                long value = GunSmithDetails.GetId(_databasePath, _gunId, gsid, GunDetails_OrderDetails, out _errOut);
                GunSmithDetails.Delete(_databasePath, value, out _errOut);
            }
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
