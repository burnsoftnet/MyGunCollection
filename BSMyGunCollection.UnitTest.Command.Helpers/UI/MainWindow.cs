using System.Collections.Generic;
using BurnSoft.Testing.Apps.Appium;
using BurnSoft.Testing.Apps.Appium.Types;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConditionIsAlwaysTrueOrFalse

namespace BSMyGunCollection.UnitTest.Command.Helpers.UI
{
    public class MainWindow
    {
        public class MainMenu
        {
            public static List<BatchCommandList> RunTest(bool verify = false, bool runFile = true, bool runEdit = true, bool runAddItems = true, bool runView = true, bool runReports = true)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                if (runFile) cmd.AddRange(RunTestFileMenu(verify));
                if (runEdit) cmd.AddRange(RunTestEditMenu(verify));
                if (runAddItems) cmd.AddRange(RunTestAddItemsMenu(verify));
                if (runView) cmd.AddRange(RunTestViewsMenu(verify));
                if (runReports) cmd.AddRange(RunTestReportsMenu(verify));
                return cmd;
            }

            private static List<BatchCommandList> RunTestFileMenu(bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnMain(true));
                cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnImport(verify));
                cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnMain(verify));
                cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnRestore(true));
                //TODO: Functions do not Work Try to Fix Later
                //cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnExit(true));
                //cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnRestore(true));
                cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnMain(verify));
                return cmd;
            }

            private static List<BatchCommandList> RunTestEditMenu(bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnMain(true));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnManufactures(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnAmmoType(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnModelTypes(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnPlaceOfOrgin(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnGripTypes(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnFirearmConditions(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnFirearmTypes(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnClassification(verify));
                return cmd;
            }

            private static List<BatchCommandList> RunTestAddItemsMenu(bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnMain(true));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddFirearm(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddAmmunitiontomyCollection(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddtoWishlist(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddManufacturer(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddAmmunitionType(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddFirearmClassification(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddModel(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddPlaceofOrigin(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnMaintenancePlan(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnDocument(verify));
                return cmd;
            }

            private static List<BatchCommandList> RunTestViewsMenu(bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(FrmMain.Menu.ViewMenu.ClickOnMain(true));
                cmd.AddRange(FrmMain.Menu.ViewMenu.ClickOnAmmunitionInventory(verify));
                cmd.AddRange(FrmMain.Menu.ViewMenu.ClickOnWishlist(verify));
                cmd.AddRange(FrmMain.Menu.ViewMenu.ClickOnMaintenancePlan(verify));
                cmd.AddRange(FrmMain.Menu.ViewMenu.ClickOnListedShops(verify));
                cmd.AddRange(FrmMain.Menu.ViewMenu.ClickOnListedBuyers(verify));
                cmd.AddRange(FrmMain.Menu.ViewMenu.ClickOnListedGunsmiths(verify));
                cmd.AddRange(FrmMain.Menu.ViewMenu.ClickOnListedAppraisers(verify));
                cmd.AddRange(FrmMain.Menu.ViewMenu.ClickOnDocuments(verify));
                cmd.AddRange(FrmMain.Menu.ViewMenu.ClickOnImagePicker(verify));
         
                return cmd;
            }

            private static List<BatchCommandList> RunTestReportsMenu(bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnMain(true));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnQuickCollectionReport(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnQuickCollectionReportwNotes(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnAmmunitionCollectionReport(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnBoundBookv1(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnBoundBookv2(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnWishlist(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnInsuranceReport(true));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnInsuranceReportPurchaseValue(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnmInsuranceReportInsuredValue(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnmInsuranceReportAppraisedValue(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnInsuranceReportWithTotal(true));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnInsuranceReportWithTotalPurchaseValue(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnmInsuranceReportWithTotalInsuredValue(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnmInsuranceReporWithTotaltAppraisedValue(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnCustomReport(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnBlankReports(true));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnBlankReportsBoundBook(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnBlankReportsShooterCardWTraget(verify));
                cmd.AddRange(FrmMain.Menu.ReportsMenu.ClickOnBlankReportsShooterCard(verify));
                return cmd;
            }
        }
        public class SideMenu
        {
            public static List<BatchCommandList> RunTest(bool verify = false, string lookForFirearm = "")
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(FrmMain.FirearmSortList.ClickOnList(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ViewAll(verify));

                if (verify)
                {
                    cmd.AddRange(Base.Sleep500());
                    cmd.AddRange(Base.ClickOnElement(lookForFirearm, lookForFirearm, verify, GeneralActions.AppAction.FindElementByName));
                }
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ClickOnList(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ViewCandR(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ClickOnList(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ViewCompetition(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ClickOnList(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ViewCustomCataolog(verify));
                if (verify)
                {
                    //cmd.AddRange(Base.Sleep500());
                    cmd.AddRange(Base.ClickOnElement(lookForFirearm, lookForFirearm, verify, GeneralActions.AppAction.FindElementByName));
                }
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ClickOnList(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ViewClassIii(verify));

                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ClickOnList(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ViewInStock(verify));
                if (verify)
                {
                    //cmd.AddRange(Base.Sleep500());
                    cmd.AddRange(Base.ClickOnElement(lookForFirearm, lookForFirearm, verify, GeneralActions.AppAction.FindElementByName));
                }
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ClickOnList(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ViewInStockLethal(verify));
                if (verify)
                {
                    //cmd.AddRange(Base.Sleep500());
                    cmd.AddRange(Base.ClickOnElement(lookForFirearm, lookForFirearm, verify, GeneralActions.AppAction.FindElementByName));
                }
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ClickOnList(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ViewInStockLethal(verify));

                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ClickOnList(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ViewInStockNonLethal(verify));

                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ClickOnList(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ViewNonCAndR(verify));

                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ClickOnList(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ViewSoldOrStolen(verify));

                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ClickOnList(verify));
                //cmd.AddRange(Base.Sleep500());
                cmd.AddRange(FrmMain.FirearmSortList.ViewInStock(verify));

                //cmd.AddRange(Menu.ClickOnFile(verify));
                //cmd.AddRange(Menu.ClickOnExit(verify));
                return cmd;
            }
        }
        /// <summary>
        /// Class ToolBar.
        /// </summary>
        public class ToolBar
        {
            public static List<BatchCommandList> RunTest(bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(FrmMain.ToolBar.ClickOnSearchCollection(verify));
                cmd.AddRange(FrmMain.ToolBar.ClickOnAddAmmoInventory(verify));
                if (!verify) cmd.AddRange(Base.ClickOnElement("Cancel button", "btnCancel"));
                cmd.AddRange(FrmMain.ToolBar.ClickOnAddGun());
                if (!verify) cmd.AddRange(Base.ClickOnElement("Cancel button", "btnCancel"));
                cmd.AddRange(FrmMain.ToolBar.ClickOnAddWishList());
                if (!verify) cmd.AddRange(Base.ClickOnElement("Cancel button", "btnCancel"));
                cmd.AddRange(FrmMain.ToolBar.ClickOnAmmoInventoryToolStripButton());
                cmd.AddRange(FrmMain.ToolBar.ClickOnFirearmGallery());
                cmd.AddRange(FrmMain.ToolBar.ClickOnSettingsButton());
                if (!verify) cmd.AddRange(Base.ClickOnElement("Cancel button", "btnExit"));
                cmd.AddRange(FrmMain.ToolBar.ClickOnDeleteSelectedFirearm(true));
                cmd.AddRange(FrmMain.ToolBar.ClickOnOpenToolStripButton(true));
                cmd.AddRange(FrmMain.ToolBar.ClickOnViewMaintenancePlans());
                cmd.AddRange(FrmMain.ToolBar.ClickOnSaveToolStripButton(true));
                cmd.AddRange(FrmMain.ToolBar.ClickOnBoundBook());
                cmd.AddRange(FrmMain.ToolBar.ClickOnDocuments());
                cmd.AddRange(FrmMain.ToolBar.ClickOnSearchCollection());
                return cmd;
            }
        }
    }
}
