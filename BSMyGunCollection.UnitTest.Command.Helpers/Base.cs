using System.Collections.Generic;
using BurnSoft.Testing.Apps.Appium;
using BurnSoft.Testing.Apps.Appium.Types;

namespace BSMyGunCollection.UnitTest.Command.Helpers
{
    public class Base
    {
        internal static List<BatchCommandList> ClickOnElement(string testName, string element, bool verify = false,
            GeneralActions.AppAction commandAction = GeneralActions.AppAction.FindElementByAccessibilityId)
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            //cmd.AddRange(Sleep500());
            string actionMs = verify ? "Verify" : "Click On";
            GeneralActions.MyAction action = verify ? GeneralActions.MyAction.Nothing : GeneralActions.MyAction.Click;

            cmd.Add(new BatchCommandList()
            {
                Actions = action,
                TestName = $"{actionMs} {testName}",
                ElementName = element,
                CommandAction = commandAction
            });
            return cmd;
        }
        internal static List<BatchCommandList> DoubleClickOnElement(string testName, string element, bool verify = false,
            GeneralActions.AppAction commandAction = GeneralActions.AppAction.FindElementByAccessibilityId)
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            //cmd.AddRange(Sleep500());
            string actionMs = verify ? "Verify" : "Double Click On";
            GeneralActions.MyAction action = verify ? GeneralActions.MyAction.Nothing : GeneralActions.MyAction.DoubleClick;

            cmd.Add(new BatchCommandList()
            {
                Actions = action,
                TestName = $"{actionMs} {testName}",
                ElementName = element,
                CommandAction = commandAction
            });
            return cmd;
        }

        internal static List<BatchCommandList> SendTExt(string testName, string element,string value, bool verify = false,
            GeneralActions.AppAction commandAction = GeneralActions.AppAction.FindElementByAccessibilityId)
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            //cmd.AddRange(Sleep500());
            string actionMs = verify ? "Verify" : "Send Text";
            GeneralActions.MyAction action = verify ? GeneralActions.MyAction.Nothing : GeneralActions.MyAction.SendKeys;

            cmd.Add(new BatchCommandList()
            {
                Actions = action,
                TestName = $"{actionMs} {testName}",
                ElementName = element,
                CommandAction = commandAction,
                SendKeys = value
            });
            return cmd;
        }

        internal static List<BatchCommandList> Sleep500()
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();

            cmd.Add(new BatchCommandList()
            {
                Actions = GeneralActions.MyAction.Sleep,
                TestName = $"Sleep 500ms",
                SleepInterval = 500
            });
            return cmd;
        }
        internal static List<BatchCommandList> Sleep( int interval = 1000)
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();

            cmd.Add(new BatchCommandList()
            {
                Actions = GeneralActions.MyAction.Sleep,
                TestName = $"Sleep {interval}ms",
                SleepInterval = interval
            });
            return cmd;
        }
    }
}
