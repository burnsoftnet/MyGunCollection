using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using BSMyGunCollection.UnitTest.Settings;
using BurnSoft.Testing.Apps.Appium;

namespace BSMyGunCollection.UnitTest.UI
{
    [TestClass]
    public class MainApp
    {
        public TestContext TestContect { get; set; }
        private GeneralActions ga;
        private string appPath;
        private string appName;
        private string errLog;
        private string fullAppPath;
        private string fullLogPath;
        private string errOut;

        [TestInitialize]
        public void Init()
        {
            try
            {
                errOut = "";
                appPath = Vs2019.GetSetting("AppPath");
                appName = Vs2019.GetSetting("AppName");
                errLog = Vs2019.GetSetting("ErrorLogName");
                fullAppPath = Path.Combine(appPath, appName);
                fullLogPath = Path.Combine(appPath, errLog);
                string SettingsScreenShotLocation = "ScreenShots";
                string fullExceptionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SettingsScreenShotLocation);
                if (!Directory.Exists(fullExceptionPath)) Directory.CreateDirectory(fullExceptionPath);
                if (File.Exists(fullLogPath)) File.Delete(fullLogPath);

                ga = new GeneralActions();
                ga.TestName = "MainApp";
                ga.ApplicationPath = fullLogPath;
                ga.SettingsScreenShotLocation = fullExceptionPath;
                ga.DoSleep = true;
                ga.Initialize();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Assert.Fail(e.Message);
            }
        }
        /// <summary>
        /// Cleans up.
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            ga.Dispose();
        }

        private bool ErrLogExists()
        {
            return File.Exists(fullLogPath);
        }

        [TestMethod]
        public void VerifyAppInit()
        {
            bool bans = false;
            try
            {
                ga.GetElements("ListBox1", out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bans = true;
                if (ErrLogExists())
                {
                    bans = false;
                    throw new Exception($"ERROR LOG EXISTS!! {fullLogPath}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.IsTrue(bans);
        }
    }
}
