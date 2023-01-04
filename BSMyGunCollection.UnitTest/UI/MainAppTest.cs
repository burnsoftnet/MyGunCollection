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
    public class MainAppTest
    {
        /// <summary>
        /// Gets or sets the test context.
        /// </summary>
        /// <value>The test context.</value>
        public TestContext TestContext { get; set; }
        private GeneralActions _ga;
        private string _appPath;
        private string _appName;
        private string _errLog;
        private string _fullAppPath;
        private string _fullLogPath;
        private string _errOut;
        private string _firearmToView;

        [TestInitialize]
        public void Init()
        {
            try
            {
                _errOut = "";
                _appPath = Vs2019.GetSetting("AppPath");
                _appName = Vs2019.GetSetting("AppName");
                _errLog = Vs2019.GetSetting("ErrorLogName");
                _firearmToView = Vs2019.GetSetting("FirearmToView");
                _fullAppPath = Path.Combine(_appPath, _appName);
                _fullLogPath = Path.Combine(_appPath, _errLog);
                string settingsScreenShotLocation = "ScreenShots";
                string fullExceptionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, settingsScreenShotLocation);
                if (!Directory.Exists(fullExceptionPath)) Directory.CreateDirectory(fullExceptionPath);
                if (File.Exists(_fullLogPath)) File.Delete(_fullLogPath);

                _ga = new GeneralActions();
                _ga.TestName = "MainApp";
                _ga.ApplicationPath = _fullAppPath;
                _ga.SettingsScreenShotLocation = fullExceptionPath;
                _ga.DoSleep = true;
                _ga.Initialize();
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
            if (_ga != null) _ga.Dispose();
        }

        private bool ErrLogExists()
        {
            return File.Exists(_fullLogPath);
        }

        private void DumpResults(List<BatchCommandList> value)
        {
            if (value.Count > 0)
            {
                int testNumber = 1;
                foreach (BatchCommandList v in value)
                {
                    string passFailed = v.PassedFailed ? "PASSED" : "FAILED";
                    TestContext.WriteLine($"{testNumber}.) {passFailed} - {v.TestName}");
                    TestContext.WriteLine(v.ReturnedValue);
                    testNumber++;
                }
            }
        }

        [TestMethod, TestCategory("Main App")]
        public void VerifyAppInitTest()
        {
            bool bans = false;
            try
            {
                _ga.GetElements("ListBox1", out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                bool value = _ga.PerformAction(_firearmToView, "", GeneralActions.MyAction.DoubleClick, out _errOut, GeneralActions.AppAction.FindElementByName);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                Thread.Sleep(2000);
                bans = true;
                if (ErrLogExists())
                {
                    bans = false;
                    throw new Exception($"ERROR LOG EXISTS!! {_fullLogPath}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Assert.IsTrue(bans);
        }
        

        [TestMethod, TestCategory("Main App")]
        public void VerifyMainWindowControls()
        {
            bool bans = false;
            try
            {
                List<BatchCommandList> value = _ga.RunBatchCommands(Command.Helpers.UI.MainWindow.SideMenu.RunTest(), out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                DumpResults(value);
                bans = _ga.AllTestsPassed(value);

                if (ErrLogExists())
                {
                    bans = false;
                    throw new Exception($"ERROR LOG EXISTS!! {_fullLogPath}");
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
