using System.Collections.Generic;
using BurnSoft.Testing.Apps.Appium;
using BurnSoft.Testing.Apps.Appium.Types;

namespace BSMyGunCollection.UnitTest.Command.Helpers.UI.Collection
{
    /// <summary>
    /// Class ViewWindow.
    /// </summary>
    public class ViewWindow
    {
        /// <summary>
        /// Runs the test.
        /// </summary>
        /// <param name="firearmName">Name of the firearm.</param>
        /// <param name="walkWindow">if set to <c>true</c> [walk window].</param>
        /// <param name="addAsCompetitionGun">if set to <c>true</c> [add as competition gun].</param>
        /// <param name="addAsNonLethal">if set to <c>true</c> [add as non lethal].</param>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        public static List<BatchCommandList> RunTest(string firearmName,bool walkWindow, bool addAsCompetitionGun, bool addAsNonLethal, bool verify = false)
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            cmd.AddRange(ClickOnFirearm(firearmName, verify));
            cmd.AddRange(ColletorDetails(verify));
            if (walkWindow)
            {
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
            }

            if (addAsCompetitionGun) cmd.AddRange(IsCompetitionCheckBox(verify));
            if (addAsNonLethal) cmd.AddRange(IsNonLethalCheckBox(verify));
            
            cmd.AddRange(Exit(verify));
            return cmd;
        }
        /// <summary>
        /// Clicks the on firearm.
        /// </summary>
        /// <param name="fireArmName">Name of the fire arm.</param>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> ClickOnFirearm(string fireArmName, bool verify = false)
        {
            return Base.DoubleClickOnElement($"firearm {fireArmName}", fireArmName, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        /// <summary>
        /// Determines whether [is competition CheckBox] [the specified verify].
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> IsCompetitionCheckBox(bool verify = false)
        {
            return Base.ClickOnElement("Competition Gun Check Box", "chkIsCompeition", verify,
                GeneralActions.AppAction.FindElementByName);
        }
        /// <summary>
        /// Determines whether [is non lethal CheckBox] [the specified verify].
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> IsNonLethalCheckBox(bool verify = false)
        {
            return Base.ClickOnElement("Non-Lethal Device Check Box", "chkNonLethal", verify,
                GeneralActions.AppAction.FindElementByName);
        }

        /// <summary>
        /// Collators the details.
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> ColletorDetails(bool verify = false)
        {
            string element = "Collector Details";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        /// <summary>
        /// Conditions the comments.
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> ConditionComments(bool verify = false)
        {
            string element = "Condition Comments";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        /// <summary>
        /// Additional the notes.
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> AdditionalNotes(bool verify = false)
        {
            string element = "Additional Notes";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        /// <summary>
        /// Pictures  the specified verify.
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> Pictures(bool verify = false)
        {
            string element = "Picture(s)";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        /// <summary>
        /// Barrels the conversion kits.
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> BarrelsConversionKits(bool verify = false)
        {
            string element = "Barrels/Conversion Kits";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        /// <summary>
        /// Accessories the specified verify.
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> Accessories(bool verify = false)
        {
            string element = "Accessories";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        /// <summary>
        /// Ammunitions the specified verify.
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> Ammunition(bool verify = false)
        {
            string element = "Ammunition";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        /// <summary>
        /// Maintenances the specified verify.
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> Maintenance(bool verify = false)
        {
            string element = "Maintenance";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        /// <summary>
        /// Guns the smith.
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> GunSmith(bool verify = false)
        {
            string element = "Gun Smith";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        /// <summary>
        /// Sales the disposition.
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> SaleDisposition(bool verify = false)
        {
            string element = "Sale/Disposition";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        /// <summary>
        /// Standards the details.
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> StandardDetails(bool verify = false)
        {
            string element = "Standard Details";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
        /// <summary>
        /// Exits the specified verify.
        /// </summary>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> Exit(bool verify = false)
        {
            string element = "Close Details";
            return Base.ClickOnElement(element, element, verify,
                GeneralActions.AppAction.FindElementByName);
        }
    }
}
