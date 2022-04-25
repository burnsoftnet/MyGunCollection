using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using BSMyGunCollection.UnitTest.Settings;
using BurnSoft.Testing.Apps.Appium;
using BurnSoft.Testing.Apps.Appium.Types;

namespace BSMyGunCollection.UnitTest.UI
{
    [TestClass]
    public class MainApp
    {
        /// <summary>
        /// Gets or sets the test context.
        /// </summary>
        /// <value>The test context.</value>
        public TestContext TestContext { get; set; }
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

        private void DumpResults(List<BatchCommandList> value)
        {
            if (value.Count > 0)
            {
                int testNumber = 1;
                foreach (BatchCommandList v in value)
                {
                    string passfailed = v.PassedFailed ? "PASSED" : "FAILED";
                    TestContext.WriteLine($"{testNumber}.) {passfailed} - {v.TestName}");
                    TestContext.WriteLine(v.ReturnedValue);
                    testNumber++;
                }
            }
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
        public void CollectionViewTest()
        {
            bool bans = false;
            try
            {
                List<BatchCommandList> value = ga.RunBatchCommands(Command.Helpers.UI.Collection.ViewWindow.RunTest(FirearmToView), out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                DumpResults(value);
                bans= ga.AllTestsPassed(value);

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
