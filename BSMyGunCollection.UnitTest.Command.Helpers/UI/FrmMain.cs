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
                return ClickOnButton(element, element, verify);
            }
            /// <summary>
            /// Clicks the on save tool strip button.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnSaveToolStripButton(bool verify = false)
            {
                string element = "SaveToolStripButton";
                return ClickOnButton(element, element, verify);
            }
            /// <summary>
            /// Clicks the on settings button.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnSettingsButton(bool verify = false)
            {
                string element = "SettingsButton";
                return ClickOnButton(element, element, verify);
            }
            /// <summary>
            /// Clicks the on ammo inventory tool strip button.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnAmmoInventoryToolStripButton(bool verify = false)
            {
                string element = "AmmoInventory";
                return ClickOnButton(element, element, verify);
            }
            /// <summary>
            /// Clicks the on add ammo inventory.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnAddAmmoInventory(bool verify = false)
            {
                string element = "AddAmmoInventory";
                return ClickOnButton(element, element, verify);
            }
            /// <summary>
            /// Clicks the on wish list.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnWishList(bool verify = false)
            {
                string element = "WishList";
                return ClickOnButton(element, element, verify);
            }
            /// <summary>
            /// Clicks the on view maintenance plans.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnViewMaintenancePlans(bool verify = false)
            {
                string element = "ViewMaintenancePlans";
                return ClickOnButton(element, element, verify);
            }
            /// <summary>
            /// Clicks the on add gun.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnAddGun(bool verify = false)
            {
                string element = "AddGun";
                return ClickOnButton(element, element, verify);
            }
            /// <summary>
            /// Clicks the on firearm gallery.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnFirearmGallery(bool verify = false)
            {
                string element = "FirearmGallery";
                return ClickOnButton(element, element, verify);
            }
            /// <summary>
            /// Clicks the on add wish list.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnAddWishList(bool verify = false)
            {
                string element = "AddWishList";
                return ClickOnButton(element, element, verify);
            }
            /// <summary>
            /// Clicks the on search collection.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnSearchCollection(bool verify = false)
            {
                string element = "SearchCollection";
                return ClickOnButton(element, element, verify);
            }
            /// <summary>
            /// Clicks the on delete selected firearm.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnDeleteSelectedFirearm(bool verify = false)
            {
                string element = "DeleteSelectedFirearm";
                return ClickOnButton(element, element, verify);
            }
            /// <summary>
            /// Clicks the on bound book.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnBoundBook(bool verify = false)
            {
                return ClickOnButton("Bound Book", "ToolStripButton8", verify);
            }
            /// <summary>
            /// Clicks the on documents.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnDocuments(bool verify = false)
            {
                return ClickOnButton("Documents", "ToolStripButton14", verify);
            }
            /// <summary>
            /// Clicks the on custom reports.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnCustomReports(bool verify = false)
            {
                return ClickOnButton("Custom Reports", "ToolStripButton12", verify);
            }

            /// <summary>
            /// Clicks the on button.
            /// </summary>
            /// <param name="name">The name.</param>
            /// <param name="element">The element.</param>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            private static List<BatchCommandList> ClickOnButton(string name, string element, bool verify = false, GeneralActions.AppAction cmdAction = GeneralActions.AppAction.FindElementByName)
            {
                return Base.ClickOnElement($"{name} tool bar icon", element, verify,
                    cmdAction);
            }
        }

        /// <summary>
        /// Class Menu.
        /// </summary>
        internal class Menu
        {
            internal class FileMenu
            {
                private static string SectionName = "File Menu";
                /// <summary>
                /// Clicks the on file.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> ClickOnMain(bool verify = false)
                {
                    return ClickOn(SectionName, "File", verify);
                }
                /// <summary>
                /// Clicks the on exit.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> ClickOnExit(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "Exit", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnImport(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "Import", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnRestore(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "Restore", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnBackup(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify)cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "Backup", verify));
                    return cmd;
                }
            }

            internal class EditMenu
            {
                private static string SectionName = "Edit Menu";

                internal static List<BatchCommandList> ClickOnMain(bool verify = false)
                {
                    return ClickOn(SectionName, "Edit", verify);
                }

                internal static List<BatchCommandList> ClickOnManufactures(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "Manufacturers", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnAmmoType(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "AmooType", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnModelTypes(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "ManageModels", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnPlaceOfOrgin(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "PlaceOfOrigin", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnGripTypes(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "GripTypes", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnFirearmConditions(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "FirearmConditions", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnFirearmTypes(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "FirearmTypes", verify));
                    return cmd;
                }
                internal static List<BatchCommandList> ClickOnClassification(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "Classification", verify));
                    return cmd;
                }
            }

            internal class AddItemMenu
            {
                private static string SectionName = "Add Item Menu";

                internal static List<BatchCommandList> ClickOnMain(bool verify = false)
                {
                    return ClickOn(SectionName, "mnuAddItem", verify);
                }

                internal static List<BatchCommandList> ClickOnAddFirearm(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuAddFirearm", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnAddAmmunitiontomyCollection(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuAddAmmunitiontomyCollection", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnAddtoWishlist(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuAddtoWishlist", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnAddManufacturer(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuAddManufacturer", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnAddAmmunitionType(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuAddAmmunitionType", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnAddFirearmClassification(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuAddFirearmClassification", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnAddModel(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuAddModel", verify));
                    return cmd;
                }
                internal static List<BatchCommandList> ClickOnAddPlaceofOrigin(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuAddPlaceofOrigin", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnMaintenancePlan(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuAddMaintenancePlan", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnDocument(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuDocument", verify));
                    return cmd;
                }
            }

            internal class ViewMenu
            {
                private static string SectionName = "Add Item Menu";

                internal static List<BatchCommandList> ClickOnMain(bool verify = false)
                {
                    return ClickOn(SectionName, "ViewItems", verify);
                }

                internal static List<BatchCommandList> ClickOnAmmunitionInventory(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "AmmunitionInventory", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnWishlist(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "Wishlist", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnMaintenancePlan(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "ViewMaintenancePlan", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnListedShops(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "ListedShops", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnListedBuyers(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "ListedBuyers", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnListedGunsmiths(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "ListedGunsmiths", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnListedAppraisers(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "ListedAppraisers", verify));
                    return cmd;
                }
                internal static List<BatchCommandList> ClickOnDocuments(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "Documents", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnImagePicker(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "ImagePicker", verify));
                    return cmd;
                }

            }

            internal class ReportsMenu
            {
                private static string SectionName = "Reports Menu";

                internal static List<BatchCommandList> ClickOnMain(bool verify = false)
                {
                    return ClickOn(SectionName, "mnuViewReports", verify);
                }

                internal static List<BatchCommandList> ClickOnQuickCollectionReport(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuQuickCollectionReport", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnQuickCollectionReportwNotes(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuQuickCollectionReportwNotes", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnAmmunitionCollectionReport(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuAmmunitionCollectionReport", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnBoundBook(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuBoundBookReport", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnBoundBookv1(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnBoundBook(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuBoundBookv1", verify));
                    return cmd;
                }
                internal static List<BatchCommandList> ClickOnBoundBookv2(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnBoundBook(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuBoundBookv2", verify));
                    return cmd;
                }


                internal static List<BatchCommandList> ClickOnWishlist(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuWishlist", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnInsuranceReport(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuInsuranceReport", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnInsuranceReportPurchaseValue(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    cmd.AddRange(ClickOnInsuranceReport(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuInsuranceReportPV", verify));
                    return cmd;
                }
                internal static List<BatchCommandList> ClickOnmInsuranceReportInsuredValue(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnInsuranceReport(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuInsuranceReportIv", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnmInsuranceReportAppraisedValue(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnInsuranceReport(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuInsuranceReportAv", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnInsuranceReportWithTotal(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuInsuranceReportWt", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnInsuranceReportWithTotalPurchaseValue(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnInsuranceReportWithTotal(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuInsuranceReportWtPv", verify));
                    return cmd;
                }
                internal static List<BatchCommandList> ClickOnmInsuranceReportWithTotalInsuredValue(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnInsuranceReportWithTotal(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuInsuranceReportWtIv", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnmInsuranceReporWithTotaltAppraisedValue(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnInsuranceReportWithTotal(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuInsuranceReportWtAv", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnCustomReport(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuCustomReport", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnBlankReports(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnMain(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuBlankReports", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnBlankReportsBoundBook(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnBlankReports(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuBlankReportsBoundBook", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnBlankReportsShooterCardWTraget(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnBlankReports(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuBlankReportsShooterCardWTraget", verify));
                    return cmd;
                }

                internal static List<BatchCommandList> ClickOnBlankReportsShooterCard(bool verify = false)
                {
                    List<BatchCommandList> cmd = new List<BatchCommandList>();
                    if (!verify) cmd.AddRange(ClickOnBlankReports(verify));
                    cmd.AddRange(ClickOn(SectionName, "mnuBlankReportsShootersCard", verify));
                    return cmd;
                }
            }

            /// <summary>
            /// Clicks the on button.
            /// </summary>
            /// <param name="name">The name.</param>
            /// <param name="element">The element.</param>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            private static List<BatchCommandList> ClickOn(string name, string element, bool verify = false, GeneralActions.AppAction cmdAction = GeneralActions.AppAction.FindElementByName)
            {
                return Base.ClickOnElement(name, element, verify,cmdAction);
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
