﻿using System.Collections.Generic;
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
            public static List<BatchCommandList> RunTest(bool verify = false, bool runFile = true, bool runEdit = true, bool runAddItems = true)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                if (runFile) cmd.AddRange(RunTestFileMenu(verify));
                if (runEdit) cmd.AddRange(RunTestEditMenu(verify));
                if (runAddItems) cmd.AddRange(RunTestAddItemsMenu(verify));
                return cmd;
            }

            private static List<BatchCommandList> RunTestFileMenu(bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnFile(verify));
                cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnImport(verify));
                cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnFile(verify));
                cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnRestore(true));
                //TODO: Functions do not Work Try to Fix Later
                //cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnExit(true));
                //cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnRestore(true));
                cmd.AddRange(FrmMain.Menu.FileMenu.ClickOnFile(verify));
                return cmd;
            }

            private static List<BatchCommandList> RunTestEditMenu(bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnEdit(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnManufactures(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnEdit(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnAmmoType(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnEdit(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnModelTypes(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnEdit(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnPlaceOfOrgin(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnEdit(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnGripTypes(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnEdit(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnFirearmConditions(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnEdit(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnFirearmTypes(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnEdit(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnClassification(verify));
                cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnEdit(verify));
                return cmd;
            }

            private static List<BatchCommandList> RunTestAddItemsMenu(bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddItem(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddFirearm(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddItem(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddAmmunitiontomyCollection(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddItem(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddtoWishlist(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddItem(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddManufacturer(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddItem(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddAmmunitionType(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddItem(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddFirearmClassification(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddItem(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddModel(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddItem(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddPlaceofOrigin(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddItem(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnMaintenancePlan(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddItem(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnDocument(verify));
                cmd.AddRange(FrmMain.Menu.AddItemMenu.ClickOnAddItem(verify));
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
