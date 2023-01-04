using System.Collections.Generic;
using BurnSoft.Testing.Apps.Appium;
using BurnSoft.Testing.Apps.Appium.Types;

namespace BSMyGunCollection.UnitTest.Command.Helpers.UI
{
    /// <summary>
    /// Class FrmMain, contains all the locations for the Main Window
    /// </summary>
    public class FrmMain
    {
        /// <summary>
        /// Class ToolBar.
        /// </summary>
        internal class ToolBar
        {
            /// <summary>
            /// Clicks the on open tool strip button.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnOpenToolStripButton(bool verify = false)
            {
                string element = "OpenToolStripButton";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Clicks the on save tool strip button.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnSaveToolStripButton(bool verify = false)
            {
                string element = "SaveToolStripButton";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Clicks the on settings button.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnSettingsButton(bool verify = false)
            {
                string element = "SettingsButton";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Clicks the on ammo inventory tool strip button.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnAmmoInventoryToolStripButton(bool verify = false)
            {
                string element = "AmmoInventory";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Clicks the on add ammo inventory.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnAddAmmoInventory(bool verify = false)
            {
                string element = "AddAmmoInventory";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Clicks the on wish list.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnWishList(bool verify = false)
            {
                string element = "WishList";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Clicks the on view maintenance plans.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnViewMaintenancePlans(bool verify = false)
            {
                string element = "ViewMaintenancePlans";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Clicks the on add gun.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnAddGun(bool verify = false)
            {
                string element = "AddGun";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Clicks the on firearm gallery.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnFirearmGallery(bool verify = false)
            {
                string element = "FirearmGallery";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Clicks the on add wish list.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnAddWishList(bool verify = false)
            {
                string element = "AddWishList";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Clicks the on search collection.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnSearchCollection(bool verify = false)
            {
                string element = "SearchCollection";
                return Base.ClickOnElement($"{element} tool bar icon", element, verify,
                    GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Clicks the on delete selected firearm.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
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
                return Base.ClickOnElement("View All Firearms", "ALL", verify,
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
            /// Views the custom catalog.
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
