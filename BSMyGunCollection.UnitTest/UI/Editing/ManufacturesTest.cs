﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using BSMyGunCollection.UnitTest.Settings;
using BurnSoft.Testing.Apps.Appium;
using BurnSoft.Testing.Apps.Appium.Types;

namespace BSMyGunCollection.UnitTest.UI.Editing
{
    [TestClass]
    public class ManufacturesTest
    {
        /// <summary>
        /// Gets or sets the test context.
        /// </summary>
        /// <value>The test context.</value>
        public TestContext TestContext { get; set; }
        /// <summary>
        /// The ga
        /// </summary>
        private GeneralActions _ga;
        /// <summary>
        /// The application path
        /// </summary>
        private string _appPath;
        /// <summary>
        /// The application name
        /// </summary>
        private string _appName;
        /// <summary>
        /// The error log
        /// </summary>
        private string _errLog;
        /// <summary>
        /// The full application path
        /// </summary>
        private string _fullAppPath;
        /// <summary>
        /// The full log path
        /// </summary>
        private string _fullLogPath;
        /// <summary>
        /// The error out
        /// </summary>
        private string _errOut;
        /// <summary>
        /// The firearm to view
        /// </summary>
        private string _firearmToView;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
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
        /// <summary>
        /// Errors the log exists.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool ErrLogExists()
        {
            return File.Exists(_fullLogPath);
        }
        /// <summary>
        /// Dumps the results.
        /// </summary>
        /// <param name="value">The value.</param>
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
        [TestMethod, TestCategory("Editing - Manufactures")]
        public void EditManufacture()
        {
            bool bans = false;
            try
            {
                List<BatchCommandList> value = _ga.RunBatchCommands(Command.Helpers.UI.Editing.Manufactures.RunTest(), out _errOut);
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
