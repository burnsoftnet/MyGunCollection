using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading;
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
        private string FirearmToView;

        [TestInitialize]
        public void Init()
        {
            try
            {
                errOut = "";
                appPath = Vs2019.GetSetting("AppPath");
                appName = Vs2019.GetSetting("AppName");
                errLog = Vs2019.GetSetting("ErrorLogName");
                FirearmToView = Vs2019.GetSetting("FirearmToView");
                fullAppPath = Path.Combine(appPath, appName);
                fullLogPath = Path.Combine(appPath, errLog);
                string SettingsScreenShotLocation = "ScreenShots";
                string fullExceptionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SettingsScreenShotLocation);
                if (!Directory.Exists(fullExceptionPath)) Directory.CreateDirectory(fullExceptionPath);
                if (File.Exists(fullLogPath)) File.Delete(fullLogPath);

                ga = new GeneralActions();
                ga.TestName = "MainApp";
                ga.ApplicationPath = fullAppPath;
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
        public void VerifyAppInitlizeTest()
        {
            bool bans = false;
            try
            {
                ga.GetElements("ListBox1", out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bool value = ga.PerformAction(FirearmToView, "", GeneralActions.MyAction.DoubleClick, out errOut, GeneralActions.AppAction.FindElementByName);
                if (errOut.Length > 0) throw new Exception(errOut);
                Thread.Sleep(2000);
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
        [TestMethod]
        public void CollectionTestTest()
        {
            bool bans = false;
            try
            {
                ga.GetElements("ListBox1", out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bool value = ga.PerformAction(FirearmToView, "", GeneralActions.MyAction.DoubleClick, out errOut, GeneralActions.AppAction.FindElementByName);
                if (errOut.Length > 0) throw new Exception(errOut);
                Thread.Sleep(2000);
                value = ga.PerformAction("Collector Details", "", GeneralActions.MyAction.Click, out errOut, GeneralActions.AppAction.FindElementByName);
                if (errOut.Length > 0) throw new Exception(errOut);
                value = ga.PerformAction("Condition Comments", "", GeneralActions.MyAction.Click, out errOut, GeneralActions.AppAction.FindElementByName);
                if (errOut.Length > 0) throw new Exception(errOut);
                value = ga.PerformAction("Additional Notes", "", GeneralActions.MyAction.Click, out errOut, GeneralActions.AppAction.FindElementByName);
                if (errOut.Length > 0) throw new Exception(errOut);
                value = ga.PerformAction("Picture(s)", "", GeneralActions.MyAction.Click, out errOut, GeneralActions.AppAction.FindElementByName);
                if (errOut.Length > 0) throw new Exception(errOut);
                value = ga.PerformAction("Barrels/Conversion Kits", "", GeneralActions.MyAction.Click, out errOut, GeneralActions.AppAction.FindElementByName);
                if (errOut.Length > 0) throw new Exception(errOut);
                value = ga.PerformAction("Accessories", "", GeneralActions.MyAction.Click, out errOut, GeneralActions.AppAction.FindElementByName);
                if (errOut.Length > 0) throw new Exception(errOut);
                value = ga.PerformAction("Ammunition", "", GeneralActions.MyAction.Click, out errOut, GeneralActions.AppAction.FindElementByName);
                if (errOut.Length > 0) throw new Exception(errOut);
                value = ga.PerformAction("Maintenance", "", GeneralActions.MyAction.Click, out errOut, GeneralActions.AppAction.FindElementByName);
                if (errOut.Length > 0) throw new Exception(errOut);
                value = ga.PerformAction("Gun Smith", "", GeneralActions.MyAction.Click, out errOut, GeneralActions.AppAction.FindElementByName);
                if (errOut.Length > 0) throw new Exception(errOut);
                value = ga.PerformAction("Sale/Disposition", "", GeneralActions.MyAction.Click, out errOut, GeneralActions.AppAction.FindElementByName);
                if (errOut.Length > 0) throw new Exception(errOut);
                value = ga.PerformAction("Standard Details", "", GeneralActions.MyAction.Click, out errOut, GeneralActions.AppAction.FindElementByName);
                if (errOut.Length > 0) throw new Exception(errOut);
                value = ga.PerformAction("Exit", "", GeneralActions.MyAction.Click, out errOut, GeneralActions.AppAction.FindElementByName);
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
