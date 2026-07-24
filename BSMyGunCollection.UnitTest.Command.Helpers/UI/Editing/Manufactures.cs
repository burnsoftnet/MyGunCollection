using BurnSoft.Testing.Apps.Appium.Types;
using BurnSoft.Testing.Apps.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BSMyGunCollection.UnitTest.Command.Helpers.UI.Editing
{
    public class Manufactures
    {

        public static List<BatchCommandList> RunTest(bool verify = false)
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            cmd.AddRange(FrmMain.Menu.EditMenu.ClickOnManufactures());
            cmd.AddRange(ClickOnGrid(verify));
            cmd.AddRange(ClickOnExit());
            return cmd;
        }

        internal static List<BatchCommandList> ClickOnGrid(bool verify = false)
        {
            return ClickOn("Main Grid", "gridMain", verify);
        }

        internal static List<BatchCommandList> ClickOnExit(bool verify = false)
        {
            return ClickOn("Close Window", "mnuExit", verify);
        }

        private static List<BatchCommandList> ClickOn(string name, string element, bool verify = false, GeneralActions.AppAction cmdAction = GeneralActions.AppAction.FindElementByName)
        {
            return Base.ClickOnElement(name, element, verify,
                cmdAction);
        }
    }
}
