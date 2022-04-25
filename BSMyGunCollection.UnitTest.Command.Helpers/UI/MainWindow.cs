using System.Collections.Generic;
using BurnSoft.Testing.Apps.Appium;
using BurnSoft.Testing.Apps.Appium.Types;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConditionIsAlwaysTrueOrFalse

namespace BSMyGunCollection.UnitTest.Command.Helpers.UI
{
    public class MainWindow
    {
        public static List<BatchCommandList> RunTest(bool verify = false, string lookForFirearm = "")
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            cmd.AddRange(FirearmSortList.ClickOnList(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ViewAll(verify));

            if (verify)
            {
                cmd.AddRange(Base.Sleep500());
                cmd.AddRange(Base.ClickOnElement(lookForFirearm, lookForFirearm, verify, GeneralActions.AppAction.FindElementByName));
            }
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ClickOnList(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ViewCandR(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ClickOnList(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ViewCompetition(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ClickOnList(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ViewCustomCataolog(verify));
            if (verify)
            {
                cmd.AddRange(Base.Sleep500());
                cmd.AddRange(Base.ClickOnElement(lookForFirearm, lookForFirearm, verify, GeneralActions.AppAction.FindElementByName));
            }
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ClickOnList(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ViewClassIii(verify));

            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ClickOnList(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ViewInStock(verify));
            if (verify)
            {
                cmd.AddRange(Base.Sleep500());
                cmd.AddRange(Base.ClickOnElement(lookForFirearm, lookForFirearm, verify, GeneralActions.AppAction.FindElementByName));
            }
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ClickOnList(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ViewInStockLethal(verify));
            if (verify)
            {
                cmd.AddRange(Base.Sleep500());
                cmd.AddRange(Base.ClickOnElement(lookForFirearm, lookForFirearm, verify, GeneralActions.AppAction.FindElementByName));
            }
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ClickOnList(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ViewInStockLethal(verify));

            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ClickOnList(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ViewInStockNonLethal(verify));

            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ClickOnList(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ViewNonCAndR(verify));

            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ClickOnList(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ViewSoldOrStolen(verify));

            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ClickOnList(verify));
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(FirearmSortList.ViewInStock(verify));

            //cmd.AddRange(Menu.ClickOnFile(verify));
            //cmd.AddRange(Menu.ClickOnExit(verify));
            return cmd;
        }

        internal class ToolBar
        {
            internal static List<BatchCommandList> ClickOnOpenToolStripButton(bool verify = false)
            {
                string element = "OpenToolStripButton";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            internal static List<BatchCommandList> ClickOnSaveToolStripButton(bool verify = false)
            {
                string element = "SaveToolStripButton";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }

            internal static List<BatchCommandList> ClickOnSettingsButton(bool verify = false)
            {
                string element = "SettingsButton";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }

            internal static List<BatchCommandList> ClickOnAmmoInventoryToolStripButton(bool verify = false)
            {
                string element = "AmmoInventory";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }

            internal static List<BatchCommandList> ClickOnAddAmmoInventory(bool verify = false)
            {
                string element = "AddAmmoInventory";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }

            internal static List<BatchCommandList> ClickOnWishList(bool verify = false)
            {
                string element = "WishList";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }

            internal static List<BatchCommandList> ClickOnViewMaintenancePlans(bool verify = false)
            {
                string element = "ViewMaintenancePlans";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }

            internal static List<BatchCommandList> ClickOnAddGun(bool verify = false)
            {
                string element = "AddGun";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }

            internal static List<BatchCommandList> ClickOnFirearmGallery(bool verify = false)
            {
                string element = "FirearmGallery";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }

            internal static List<BatchCommandList> ClickOnAddWishList(bool verify = false)
            {
                string element = "AddWishList";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            
            internal static List<BatchCommandList> ClickOnSearchCollection(bool verify = false)
            {
                string element = "SearchCollection";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }

            internal static List<BatchCommandList> ClickOnDeleteSelectedFirearm(bool verify = false)
            {
                string element = "DeleteSelectedFirearm";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }

        }

        /// <summary>
        /// Class Menu.
        /// </summary>
        internal class Menu
        {
            /// <summary>
            /// Clicks the on file.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnFile(bool verify = false)
            {
                return Base.ClickOnElement("File Menu", "File", verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Clicks the on exit.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnExit(bool verify = false)
            {
                return Base.ClickOnElement("File Menu", "Exit", verify,
                    GeneralActions.AppAction.FindElementByName);
            }
        }
        /// <summary>
        /// Class FirearmSortList.
        /// </summary>
        internal class FirearmSortList
        {
            /// <summary>
            /// Clicks the on list.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnList(bool verify = false)
            {
                return Base.ClickOnElement("Firearm sort list", "Open", verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Views all.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ViewAll(bool verify = false)
            {
                return Base.ClickOnElement("View All Firearms","ALL", verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Views the in stock.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ViewInStock(bool verify = false)
            {
                return Base.ClickOnElement("View In Stock Firearms", "In Stock", verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Views the i class iii.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ViewClassIii(bool verify = false)
            {
                return Base.ClickOnElement("View Class III Firearms", "Class III", verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Views the in stock lethal.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ViewInStockLethal(bool verify = false)
            {
                return Base.ClickOnElement("View In Stock - Lethal Firearms", "In Stock - Lethal", verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Views the in stock non lethal.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ViewInStockNonLethal(bool verify = false)
            {
                return Base.ClickOnElement("View In Stock - Non-Lethal Firearms", "In Stock - Non-Lethal", verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Views the competition.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ViewCompetition(bool verify = false)
            {
                return Base.ClickOnElement("View Competition Firearms", "Competition", verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Views the cand r.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ViewCandR(bool verify = false)
            {
                return Base.ClickOnElement("View C & R Firearms", "C & R", verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Views the non c and r.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ViewNonCAndR(bool verify = false)
            {
                return Base.ClickOnElement("View Non C & R Firearms", "Non C & R", verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Views the custom cataolog.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ViewCustomCataolog(bool verify = false)
            {
                return Base.ClickOnElement("View Cust. Catalog # Firearms", "Cust. Catalog #", verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Views the sold or stolen.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ViewSoldOrStolen(bool verify = false)
            {
                return Base.ClickOnElement("View Sold/Stolen Firearms", "Sold/Stolen", verify,
                    GeneralActions.AppAction.FindElementByName);
            }
        }

    }
}
