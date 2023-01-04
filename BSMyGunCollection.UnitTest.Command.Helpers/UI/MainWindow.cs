using System.Collections.Generic;
using BurnSoft.Testing.Apps.Appium;
using BurnSoft.Testing.Apps.Appium.Types;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConditionIsAlwaysTrueOrFalse

namespace BSMyGunCollection.UnitTest.Command.Helpers.UI
{
    public class MainWindow
    {
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

        public class ToolBar
        {
            public static List<BatchCommandList> RunTest(bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(FrmMain.ToolBar.ClickOnSearchCollection(verify));
                if (!verify) cmd.AddRange(Base.ClickOnElement("Cancel button","btnCancel"));
                return cmd;
            }
        }
    }
}
