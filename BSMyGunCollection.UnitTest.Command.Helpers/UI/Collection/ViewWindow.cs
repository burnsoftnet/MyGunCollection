using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurnSoft.Testing.Apps.Appium;
using BurnSoft.Testing.Apps.Appium.Types;

namespace BSMyGunCollection.UnitTest.Command.Helpers.UI.Collection
{
    public class ViewWindow
    {
        public static List<BatchCommandList> RunTest(string firearmName, bool verify = false)
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            cmd.AddRange(ClickOnFirearm(firearmName, verify));
            cmd.AddRange(ColletorDetails(verify));
            cmd.AddRange(ConditionComments(verify));
            cmd.AddRange(AdditionalNotes(verify));
            cmd.AddRange(Pictures(verify));
            cmd.AddRange(BarrelsConversionKits(verify));
            cmd.AddRange(Accessories(verify));
            cmd.AddRange(Ammunition(verify));
            cmd.AddRange(Maintenance(verify));
            cmd.AddRange(GunSmith(verify));
            cmd.AddRange(SaleDisposition(verify));
            cmd.AddRange(StandardDetails(verify));
            cmd.AddRange(Exit(verify));
            return cmd;
        }

        internal static List<BatchCommandList> ClickOnFirearm(string fireArmName, bool verify = false)
        {
            return Base.DoubleClickOnElement($"firearm {fireArmName}", fireArmName, verify,
                GeneralActions.AppAction.FindElementByName);
        }

        internal static List<BatchCommandList> ColletorDetails(bool verify = false)
        {
            string element = "Collector Details";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }

        internal static List<BatchCommandList> ConditionComments(bool verify = false)
        {
            string element = "Condition Comments";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        internal static List<BatchCommandList> AdditionalNotes(bool verify = false)
        {
            string element = "Additional Notes";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        internal static List<BatchCommandList> Pictures(bool verify = false)
        {
            string element = "Picture(s)";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        internal static List<BatchCommandList> BarrelsConversionKits(bool verify = false)
        {
            string element = "Barrels/Conversion Kits";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        internal static List<BatchCommandList> Accessories(bool verify = false)
        {
            string element = "Accessories";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        internal static List<BatchCommandList> Ammunition(bool verify = false)
        {
            string element = "Ammunition";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        internal static List<BatchCommandList> Maintenance(bool verify = false)
        {
            string element = "Maintenance";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        internal static List<BatchCommandList> GunSmith(bool verify = false)
        {
            string element = "Gun Smith";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        internal static List<BatchCommandList> SaleDisposition(bool verify = false)
        {
            string element = "Sale/Disposition";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        internal static List<BatchCommandList> StandardDetails(bool verify = false)
        {
            string element = "Standard Details";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        internal static List<BatchCommandList> Exit(bool verify = false)
        {
            string element = "Exit";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
    }
}
