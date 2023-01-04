using System.Collections.Generic;
using BurnSoft.Testing.Apps.Appium;
using BurnSoft.Testing.Apps.Appium.Types;

namespace BSMyGunCollection.UnitTest.Command.Helpers.UI.Collection
{
    public class AddWindow
    {
        /// <summary>
        /// Runs the test.
        /// </summary>
        /// <param name="manufacture">The manufacture.</param>
        /// <param name="importer">The importer.</param>
        /// <param name="model">The model.</param>
        /// <param name="serialNumber">The serial number.</param>
        /// <param name="pistolType">Type of the pistol.</param>
        /// <param name="caliber">The caliber.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="purchasedFrom">The purchased from.</param>
        /// <param name="purchasedPrice">The purchased price.</param>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        public static List<BatchCommandList> RunTest(string manufacture,string importer,string model,
            string serialNumber,string pistolType,string caliber,string condition,
            string purchasedFrom, string purchasedPrice, bool verify = false)
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            cmd.AddRange(MainWindow.ToolBar.ClickOnAddGun());
            //cmd.AddRange(Base.Sleep500());
            cmd.AddRange(AddSimple(manufacture, importer, model, serialNumber, pistolType, caliber,
                condition, purchasedFrom, purchasedPrice, verify));
            cmd.AddRange(Details.ClickOn.CancelButton(verify));
            cmd.AddRange(MainWindow.ToolBar.ClickOnAddGun());
            //cmd.AddRange(Base.Sleep500());
            cmd.AddRange(AddSimple(manufacture, importer, model, serialNumber, pistolType, caliber,
                condition, purchasedFrom, purchasedPrice, verify));
            cmd.AddRange(Details.ClickOn.AddButton(verify));
            //cmd.AddRange(Base.Sleep());
            return cmd;
        }
        /// <summary>
        /// Runs the test.
        /// </summary>
        /// <param name="manufacture">The manufacture.</param>
        /// <param name="importer">The importer.</param>
        /// <param name="model">The model.</param>
        /// <param name="serialNumber">The serial number.</param>
        /// <param name="pistolType">Type of the pistol.</param>
        /// <param name="caliber">The caliber.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="purchasedFrom">The purchased from.</param>
        /// <param name="purchasedPrice">The purchased price.</param>
        /// <param name="caliber2">The caliber2.</param>
        /// <param name="caliber3">The caliber3.</param>
        /// <param name="stockType">Type of the stock.</param>
        /// <param name="manufacturedDate">The manufactured date.</param>
        /// <param name="action">The action.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="placeOfOrgin">The place of orgin.</param>
        /// <param name="finish">The finish.</param>
        /// <param name="storage">The storage.</param>
        /// <param name="sights">The sights.</param>
        /// <param name="feedSystem">The feed system.</param>
        /// <param name="overallLength">Length of the overall.</param>
        /// <param name="barrelLength">Length of the barrel.</param>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <param name="currentChoke">The current choke.</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        public static List<BatchCommandList> RunTest(string manufacture, string importer, string model,
            string serialNumber, string pistolType, string caliber, string condition,
            string purchasedFrom, string purchasedPrice, string caliber2, string caliber3, string stockType,
            string manufacturedDate, string action, string weight, string placeOfOrgin, string finish, 
            string storage, string sights, string feedSystem, string overallLength, string barrelLength, bool verify = false, string currentChoke = "")
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            cmd.AddRange(MainWindow.ToolBar.ClickOnAddGun());
            //cmd.AddRange(Base.Sleep500());
            cmd.AddRange(AddSimple(manufacture, importer, model, serialNumber, pistolType, caliber,
                condition, purchasedFrom, purchasedPrice, verify));
            cmd.AddRange(AddOtherDetails(caliber2, caliber3, stockType, manufacturedDate, action, 
                weight, placeOfOrgin, finish, storage, sights, feedSystem, overallLength, barrelLength, verify, currentChoke));
            
            cmd.AddRange(Details.ClickOn.AddButton(verify));
            //cmd.AddRange(Base.Sleep());
            return cmd;
        }
        /// <summary>
        /// Runs the test.
        /// </summary>
        /// <param name="manufacture">The manufacture.</param>
        /// <param name="importer">The importer.</param>
        /// <param name="model">The model.</param>
        /// <param name="serialNumber">The serial number.</param>
        /// <param name="pistolType">Type of the pistol.</param>
        /// <param name="caliber">The caliber.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="purchasedFrom">The purchased from.</param>
        /// <param name="purchasedPrice">The purchased price.</param>
        /// <param name="caliber2">The caliber2.</param>
        /// <param name="caliber3">The caliber3.</param>
        /// <param name="stockType">Type of the stock.</param>
        /// <param name="manufacturedDate">The manufactured date.</param>
        /// <param name="action">The action.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="placeOfOrgin">The place of orgin.</param>
        /// <param name="finish">The finish.</param>
        /// <param name="storage">The storage.</param>
        /// <param name="sights">The sights.</param>
        /// <param name="feedSystem">The feed system.</param>
        /// <param name="overallLength">Length of the overall.</param>
        /// <param name="barrelLength">Length of the barrel.</param>
        /// <param name="appraisedValue">The appraised value.</param>
        /// <param name="appraisedDate">The appraised date.</param>
        /// <param name="appraisedBy">The appraised by.</param>
        /// <param name="insuredValue">The insured value.</param>
        /// <param name="twistOfRate">The twist of rate.</param>
        /// <param name="triggerPull">The trigger pull.</param>
        /// <param name="isClassIiiItem">if set to <c>true</c> [is class iii item].</param>
        /// <param name="isClassIiiOwner">The is class iii owner.</param>
        /// <param name="isCompetitionGun">if set to <c>true</c> [is competition gun].</param>
        /// <param name="isNonLethalDevice">if set to <c>true</c> [is non lethal device].</param>
        /// <param name="isCandR">if set to <c>true</c> [is cand r].</param>
        /// <param name="conditionNotes">The condition notes.</param>
        /// <param name="additionalNotes">The additional notes.</param>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <param name="currentChoke">The current choke.</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        public static List<BatchCommandList> RunTest(string manufacture, string importer, string model,
            string serialNumber, string pistolType, string caliber, string condition,
            string purchasedFrom, string purchasedPrice, string caliber2, string caliber3, string stockType,
            string manufacturedDate, string action, string weight, string placeOfOrgin, string finish,
            string storage, string sights, string feedSystem, string overallLength, string barrelLength,
            string appraisedValue, string appraisedDate, string appraisedBy, string insuredValue, string twistOfRate,
            string triggerPull, bool isClassIiiItem, string isClassIiiOwner, bool isCompetitionGun, bool isNonLethalDevice, 
            bool isCandR, string conditionNotes, string additionalNotes, bool verify = false, string currentChoke = "")
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            cmd.AddRange(MainWindow.ToolBar.ClickOnAddGun());
            //cmd.AddRange(Base.Sleep500());
            cmd.AddRange(AddSimple(manufacture, importer, model, serialNumber, pistolType, caliber,
                condition, purchasedFrom, purchasedPrice, verify));
            cmd.AddRange(AddOtherDetails(caliber2, caliber3, stockType, manufacturedDate, action,
                weight, placeOfOrgin, finish, storage, sights, feedSystem, overallLength, barrelLength, verify, currentChoke));
            cmd.AddRange(CollectorDetails.RunTest(appraisedValue, appraisedDate, appraisedBy, insuredValue, twistOfRate,
                 triggerPull, isClassIiiItem, isClassIiiOwner, isCompetitionGun, isNonLethalDevice, isCandR, verify));
            cmd.AddRange(ConditionComments.RunTest(conditionNotes, verify));
            cmd.AddRange(AdditionalNotes.RunTest(additionalNotes, verify));

            cmd.AddRange(Details.ClickOn.AddButton(verify));
            //cmd.AddRange(Base.Sleep());
            return cmd;
        }
        /// <summary>
        /// Adds the simple.
        /// </summary>
        /// <param name="manufacture">The manufacture.</param>
        /// <param name="importer">The importer.</param>
        /// <param name="model">The model.</param>
        /// <param name="serialNumber">The serial number.</param>
        /// <param name="pistolType">Type of the pistol.</param>
        /// <param name="caliber">The caliber.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="purchasedFrom">The purchased from.</param>
        /// <param name="purchasedPrice">The purchased price.</param>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> AddSimple(string manufacture, string importer, string model,
            string serialNumber, string pistolType, string caliber, string condition,
            string purchasedFrom, string purchasedPrice, bool verify = false)
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            cmd.AddRange(Details.ClickOn.Manufacture(verify));
            cmd.AddRange(Details.FillIn.Manufacture(manufacture, verify));
            cmd.AddRange(Details.ClickOn.Importer(verify));
            cmd.AddRange(Details.FillIn.Importer(importer, verify));
            cmd.AddRange(Details.ClickOn.Model(verify));
            cmd.AddRange(Details.FillIn.Model(model, verify));
            cmd.AddRange(Details.ClickOn.SerialNumber(verify));
            cmd.AddRange(Details.FillIn.SerialNumber(serialNumber, verify));
            cmd.AddRange(Details.ClickOn.PistolType(verify));
            cmd.AddRange(Details.FillIn.PistolType(pistolType, verify));
            cmd.AddRange(Details.ClickOn.Caliber(verify));
            cmd.AddRange(Details.FillIn.Caliber(caliber, verify));
            cmd.AddRange(Details.ClickOn.Condition(verify));
            cmd.AddRange(Details.FillIn.Condition(condition, verify));
            cmd.AddRange(Details.ClickOn.PurchasedFrom(verify));
            cmd.AddRange(Details.FillIn.PurchasedFrom(purchasedFrom, verify));
            cmd.AddRange(Details.ClickOn.PurchasedPrice(verify));
            cmd.AddRange(Details.FillIn.PurchasedPrice(purchasedPrice, verify));
            return cmd;
        }
        /// <summary>
        /// Adds the other details.
        /// </summary>
        /// <param name="caliber2">The caliber2.</param>
        /// <param name="caliber3">The caliber3.</param>
        /// <param name="stockType">Type of the stock.</param>
        /// <param name="manufacturedDate">The manufactured date.</param>
        /// <param name="action">The action.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="placeOfOrgin">The place of orgin.</param>
        /// <param name="finish">The finish.</param>
        /// <param name="storage">The storage.</param>
        /// <param name="sights">The sights.</param>
        /// <param name="feedSystem">The feed system.</param>
        /// <param name="overallLength">Length of the overall.</param>
        /// <param name="barrelLength">Length of the barrel.</param>
        /// <param name="verify">if set to <c>true</c> [verify].</param>
        /// <param name="currentChoke">The current choke.</param>
        /// <returns>List&lt;BatchCommandList&gt;.</returns>
        internal static List<BatchCommandList> AddOtherDetails(string caliber2, string caliber3, string stockType, string manufacturedDate, string action,
            string weight, string placeOfOrgin, string finish, string storage, string sights, string feedSystem,
            string overallLength, string barrelLength, bool verify = false, string currentChoke = "")
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            cmd.AddRange(Details.ClickOn.Caliber2(verify));
            cmd.AddRange(Details.FillIn.Caliber2(caliber2, verify));
            cmd.AddRange(Details.ClickOn.Caliber3(verify));
            cmd.AddRange(Details.FillIn.Caliber3(caliber3, verify));
            cmd.AddRange(Details.ClickOn.StockGripType(verify));
            cmd.AddRange(Details.FillIn.StockGripType(stockType, verify));
            cmd.AddRange(Details.ClickOn.ManufacturedDate(verify));
            cmd.AddRange(Details.FillIn.ManufacturedDate(manufacturedDate, verify));
            cmd.AddRange(Details.ClickOn.Action(verify));
            cmd.AddRange(Details.FillIn.Action(action, verify));
            cmd.AddRange(Details.ClickOn.Weight(verify));
            cmd.AddRange(Details.FillIn.Weight(weight, verify));
            cmd.AddRange(Details.ClickOn.PlaceOfOrgin(verify));
            cmd.AddRange(Details.FillIn.PlaceOfOrgin(placeOfOrgin, verify));
            cmd.AddRange(Details.ClickOn.Finish(verify));
            cmd.AddRange(Details.FillIn.Finish(finish, verify));
            cmd.AddRange(Details.ClickOn.Storage(verify));
            cmd.AddRange(Details.FillIn.Storage(storage, verify));
            cmd.AddRange(Details.ClickOn.Sights(verify));
            cmd.AddRange(Details.FillIn.Sights(sights, verify));
            cmd.AddRange(Details.ClickOn.FeedSystem(verify));
            cmd.AddRange(Details.FillIn.FeedSystem(feedSystem, verify));
            cmd.AddRange(Details.ClickOn.OverallLength(verify));
            cmd.AddRange(Details.FillIn.OverallLength(overallLength, verify));
            cmd.AddRange(Details.ClickOn.BarrelLength(verify));
            cmd.AddRange(Details.FillIn.BarrelLength(barrelLength, verify));
            if (currentChoke.Length > 0)
            {
                cmd.AddRange(Details.ClickOn.CurrentChoke(verify));
                cmd.AddRange(Details.FillIn.CurrentChoke(currentChoke, verify));
            }
            
            return cmd;
        }
        /// <summary>
        /// Class Details.
        /// </summary>
        internal class Details
        {
            /// <summary>
            /// Class ClickOn.
            /// </summary>
            internal class ClickOn
            {
                /// <summary>
                /// Overalls the length.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> OverallLength(bool verify = false)
                {
                    return Base.ClickOnElement("Overal lLength", "txtLength", verify);
                }
                /// <summary>
                /// Barrels the length.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> BarrelLength(bool verify = false)
                {
                    return Base.ClickOnElement("BarrelLength", "txtBarLen", verify);
                }
                /// <summary>
                /// Currents the choke.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> CurrentChoke(bool verify = false)
                {
                    return Base.ClickOnElement("Current Choke", "txtChoke", verify);
                }
                /// <summary>
                /// Weights the specified verify.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Weight(bool verify = false)
                {
                    return Base.ClickOnElement("Weight", "txtWeight", verify);
                }
                /// <summary>
                /// Places the of orgin.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> PlaceOfOrgin(bool verify = false)
                {
                    return Base.ClickOnElement("Place of origin", "txtNationality", verify);
                }
                /// <summary>
                /// Finishes the specified verify.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Finish(bool verify = false)
                {
                    return Base.ClickOnElement("Finish", "txtFinish", verify);
                }
                /// <summary>
                /// Storages the specified verify.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Storage(bool verify = false)
                {
                    return Base.ClickOnElement("Storage Location", "txtStorage", verify);
                }
                /// <summary>
                /// Sightses the specified verify.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Sights(bool verify = false)
                {
                    return Base.ClickOnElement("Sigths", "txtSights", verify);
                }
                /// <summary>
                /// Feeds the system.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> FeedSystem(bool verify = false)
                {
                    return Base.ClickOnElement("Feed System", "txtFeed", verify);
                }
                /// <summary>
                /// Manufactures the specified verify.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Manufacture(bool verify = false)
                {
                    return Base.ClickOnElement("Manufacture", "txtManu", verify);
                }
                /// <summary>
                /// Importers the specified verify.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Importer(bool verify = false)
                {
                    return Base.ClickOnElement("Importer", "txtImporter", verify);
                }
                /// <summary>
                /// Models the specified verify.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Model(bool verify = false)
                {
                    return Base.ClickOnElement("Model", "txtModel", verify);
                }
                /// <summary>
                /// Serials the number.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> SerialNumber(bool verify = false)
                {
                    return Base.ClickOnElement("Serial Number", "txtSerial", verify);
                }
                /// <summary>
                /// Pistols the type.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> PistolType(bool verify = false)
                {
                    return Base.ClickOnElement("Type", "txtType", verify);
                }
                /// <summary>
                /// Calibers the specified verify.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Caliber(bool verify = false)
                {
                    return Base.ClickOnElement("Caliber", "txtCal", verify);
                }
                /// <summary>
                /// Conditions the specified verify.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Condition(bool verify = false)
                {
                    return Base.ClickOnElement("Condition", "cmdCondition", verify);
                }
                /// <summary>
                /// Purchaseds from.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> PurchasedFrom(bool verify = false)
                {
                    return Base.ClickOnElement("Purchased From", "txtPurchasedFrom", verify);
                }
                /// <summary>
                /// Purchaseds the price.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> PurchasedPrice(bool verify = false)
                {
                    return Base.ClickOnElement("Purchased Price", "txtPurPrice", verify);
                }
                /// <summary>
                /// Adds the button.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> AddButton(bool verify = false)
                {
                    return Base.ClickOnElement("Add button", "btnAdd", verify);
                }
                /// <summary>
                /// Cancels the button.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> CancelButton(bool verify = false)
                {
                    return Base.ClickOnElement("Cancel button", "btnCancel", verify);
                }
                /// <summary>
                /// Caliber2s the specified verify.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Caliber2(bool verify = false)
                {
                    return Base.ClickOnElement("Caliber 2", "txtPetLoads", verify);
                }
                /// <summary>
                /// Caliber3s the specified verify.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Caliber3(bool verify = false)
                {
                    return Base.ClickOnElement("Caliber 3", "txtCaliber3", verify);
                }
                /// <summary>
                /// Stocks the type of the grip.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> StockGripType(bool verify = false)
                {
                    return Base.ClickOnElement("Stock Grip Type", "txtGripType", verify);
                }
                /// <summary>
                /// Manufactureds the date.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> ManufacturedDate(bool verify = false)
                {
                    return Base.ClickOnElement("Manufactured Date", "txtProduced", verify);
                }
                /// <summary>
                /// Actions the specified verify.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Action(bool verify = false)
                {
                    return Base.ClickOnElement("Action", "txtAction", verify);
                }

            }
            /// <summary>
            /// Class FillIn.
            /// </summary>
            internal class FillIn
            {
                /// <summary>
                /// Overalls the length.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> OverallLength(string value, bool verify = false)
                {
                    return Base.SendTExt("Overal lLength", "txtLength", value, verify);
                }
                /// <summary>
                /// Barrels the length.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> BarrelLength(string value, bool verify = false)
                {
                    return Base.SendTExt("BarrelLength", "txtBarLen", value, verify);
                }
                /// <summary>
                /// Currents the choke.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> CurrentChoke(string value, bool verify = false)
                {
                    return Base.SendTExt("Current Choke", "txtChoke", value, verify);
                }
                /// <summary>
                /// Weights the specified value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Weight(string value, bool verify = false)
                {
                    return Base.SendTExt("Weight", "txtWeight", value, verify);
                }
                /// <summary>
                /// Places the of orgin.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> PlaceOfOrgin(string value, bool verify = false)
                {
                    return Base.SendTExt("Place of origin", "txtNationality", value, verify);
                }
                /// <summary>
                /// Finishes the specified value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Finish(string value, bool verify = false)
                {
                    return Base.SendTExt("Finish", "txtFinish", value, verify);
                }
                /// <summary>
                /// Storages the specified value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Storage(string value, bool verify = false)
                {
                    return Base.SendTExt("Storage Location", "txtStorage", value, verify);
                }
                /// <summary>
                /// Sightses the specified value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Sights(string value, bool verify = false)
                {
                    return Base.SendTExt("Sigths", "txtSights", value, verify);
                }
                /// <summary>
                /// Feeds the system.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> FeedSystem(string value, bool verify = false)
                {
                    return Base.SendTExt("Feed System", "txtFeed", value, verify);
                }
                /// <summary>
                /// Stocks the type of the grip.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> StockGripType(string value, bool verify = false)
                {
                    return Base.SendTExt("Stock Grip Type", "txtGripType", value, verify);
                }
                /// <summary>
                /// Manufactureds the date.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> ManufacturedDate(string value, bool verify = false)
                {
                    return Base.SendTExt("Manufactured Date", "txtProduced", value, verify);
                }
                /// <summary>
                /// Actions the specified value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Action(string value, bool verify = false)
                {
                    return Base.SendTExt("Action", "txtAction", value, verify);
                }
                /// <summary>
                /// Caliber2s the specified value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Caliber2(string value, bool verify = false)
                {
                    return Base.SendTExt("Caliber 2", "txtPetLoads", value, verify);
                }
                /// <summary>
                /// Caliber3s the specified value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Caliber3(string value, bool verify = false)
                {
                    return Base.SendTExt("Caliber 3", "txtCaliber3", value, verify);
                }
                /// <summary>
                /// Manufactures the specified value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Manufacture(string value, bool verify = false)
                {
                    return Base.SendTExt("Manufacture", "txtManu", value, verify);
                }
                /// <summary>
                /// Importers the specified value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Importer(string value, bool verify = false)
                {
                    return Base.SendTExt("Importer", "txtImporter", value, verify);
                }
                /// <summary>
                /// Models the specified value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Model(string value, bool verify = false)
                {
                    return Base.SendTExt("Model", "txtModel", value, verify);
                }
                /// <summary>
                /// Serials the number.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> SerialNumber(string value, bool verify = false)
                {
                    return Base.SendTExt("Serial Number", "txtSerial", value, verify);
                }
                /// <summary>
                /// Pistols the type.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> PistolType(string value, bool verify = false)
                {
                    return Base.SendTExt("Type", "txtType", value, verify);
                }
                /// <summary>
                /// Calibers the specified value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Caliber(string value, bool verify = false)
                {
                    return Base.SendTExt("Caliber", "txtCal", value, verify);
                }
                /// <summary>
                /// Conditions the specified value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> Condition(string value, bool verify = false)
                {
                    return Base.SendTExt("Condition", "cmdCondition", value, verify);
                }
                /// <summary>
                /// Purchaseds from.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> PurchasedFrom(string value, bool verify = false)
                {
                    return Base.SendTExt("Purchased From", "txtPurchasedFrom", value, verify);
                }
                /// <summary>
                /// Purchaseds the price.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> PurchasedPrice(string value, bool verify = false)
                {
                    return Base.SendTExt("Purchased Price", "txtPurPrice", value, verify);
                }

            }
        }
        /// <summary>
        /// Class CollectorDetails.
        /// </summary>
        internal class CollectorDetails
        {
            /// <summary>
            /// Runs the test.
            /// </summary>
            /// <param name="appraisedValue">The appraised value.</param>
            /// <param name="appraisedDate">The appraised date.</param>
            /// <param name="appraisedBy">The appraised by.</param>
            /// <param name="insuredValue">The insured value.</param>
            /// <param name="twistOfRate">The twist of rate.</param>
            /// <param name="triggerPull">The trigger pull.</param>
            /// <param name="isClassIiiItem">if set to <c>true</c> [is class iii item].</param>
            /// <param name="isClassIiiOwner">The is class iii owner.</param>
            /// <param name="isCompetitionGun">if set to <c>true</c> [is competition gun].</param>
            /// <param name="isNonLethalDevice">if set to <c>true</c> [is non lethal device].</param>
            /// <param name="isCandR">if set to <c>true</c> [is cand r].</param>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> RunTest(string appraisedValue,string appraisedDate, string appraisedBy,string insuredValue,string twistOfRate,
                string triggerPull, bool isClassIiiItem, string isClassIiiOwner, bool isCompetitionGun,bool isNonLethalDevice,bool isCandR, bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(ClickOnTab());
                cmd.AddRange(ClickOn.AppraisedValue(verify));
                cmd.AddRange(FillIn.AppraisedValue(appraisedValue, verify));
                cmd.AddRange(ClickOn.AppraisedDate(verify));
                cmd.AddRange(FillIn.AppraisedDate(appraisedDate, verify));
                cmd.AddRange(ClickOn.AppraisedBy(verify));
                cmd.AddRange(FillIn.AppraisedBy(appraisedBy, verify));
                cmd.AddRange(ClickOn.InsuredValue(verify));
                cmd.AddRange(FillIn.InsuredValue(insuredValue, verify));
                cmd.AddRange(ClickOn.TwistOfRate(verify));
                cmd.AddRange(FillIn.TwistOfRate(twistOfRate, verify));
                cmd.AddRange(ClickOn.TriggerPull(verify));
                cmd.AddRange(FillIn.TriggerPull(triggerPull, verify));
                if (isClassIiiItem)
                {
                    cmd.AddRange(ClickOn.IsClassIiiItem(verify));
                    cmd.AddRange(ClickOn.IsClassIiiOwner(verify));
                    cmd.AddRange(FillIn.IsClassIiiOwner(isClassIiiOwner, verify));
                }
                if (isCompetitionGun) cmd.AddRange(ClickOn.IsCompetitionGun(verify));
                if (isNonLethalDevice) cmd.AddRange(ClickOn.IsNonLethalDevice(verify));
                if (isCandR) cmd.AddRange(ClickOn.IsCandR(verify));

                return cmd;
            }
            /// <summary>
            /// Clicks the on tab.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnTab(bool verify = false)
            {
                return Base.ClickOnElement("Collector Details", "Collector Details", verify, GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Class ClickOn.
            /// </summary>
            internal class ClickOn
            {
                /// <summary>
                /// Determines whether [is cand r] [the specified verify].
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> IsCandR(bool verify = false)
                {
                    return Base.ClickOnElement("C & R Check Box", "chkBoxCR", verify);
                }
                /// <summary>
                /// Determines whether [is competition gun] [the specified verify].
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> IsCompetitionGun(bool verify = false)
                {
                    return Base.ClickOnElement("Competition Gun Check Box", "chkIsCompeition", verify);
                }
                /// <summary>
                /// Determines whether [is non lethal device] [the specified verify].
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> IsNonLethalDevice(bool verify = false)
                {
                    return Base.ClickOnElement("Non-Lethal Device Check Box", "chkNonLethal", verify);
                }
                /// <summary>
                /// Determines whether [is class iii owner] [the specified verify].
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> IsClassIiiOwner(bool verify = false)
                {
                    return Base.ClickOnElement("Class III Owner", "txtClassIIIOwner", verify);
                }
                /// <summary>
                /// Determines whether [is class iii item] [the specified verify].
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> IsClassIiiItem(bool verify = false)
                {
                    return Base.ClickOnElement("Is Class III Item Check Box", "chkClassIII", verify);
                }
                /// <summary>
                /// Triggers the pull.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> TriggerPull(bool verify = false)
                {
                    return Base.ClickOnElement("Trigger Pull", "txtTriggerPull", verify);
                }
                /// <summary>
                /// Twists the of rate.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> TwistOfRate(bool verify = false)
                {
                    return Base.ClickOnElement("Twist Rate", "txtTwistOfRate", verify);
                }
                /// <summary>
                /// Insureds the value.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> InsuredValue(bool verify = false)
                {
                    return Base.ClickOnElement("Insured Value", "txtInsVal", verify);
                }
                /// <summary>
                /// Appraiseds the value.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> AppraisedValue(bool verify = false)
                {
                    return Base.ClickOnElement("Appraised Value", "txtAppValue", verify);
                }
                /// <summary>
                /// Appraiseds the date.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> AppraisedDate(bool verify = false)
                {
                    return Base.ClickOnElement("Appraised Date", "dtpAppDate", verify);
                }
                /// <summary>
                /// Appraiseds the by.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> AppraisedBy(bool verify = false)
                {
                    return Base.ClickOnElement("Appraised By", "txtAppBy", verify);
                }
            }
            /// <summary>
            /// Class FillIn.
            /// </summary>
            internal class FillIn
            {
                /// <summary>
                /// Determines whether [is class iii owner] [the specified value].
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> IsClassIiiOwner(string value, bool verify = false)
                {
                    return Base.SendTExt("Class III Owner", "txtClassIIIOwner", value, verify);
                }
                /// <summary>
                /// Triggers the pull.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> TriggerPull(string value, bool verify = false)
                {
                    return Base.SendTExt("Trigger Pull", "txtTriggerPull", value, verify);
                }
                /// <summary>
                /// Twists the of rate.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> TwistOfRate(string value, bool verify = false)
                {
                    return Base.SendTExt("Twist Rate", "txtTwistOfRate", value, verify);
                }
                /// <summary>
                /// Insureds the value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> InsuredValue(string value, bool verify = false)
                {
                    return Base.SendTExt("Insured Value", "txtInsVal", value, verify);
                }
                /// <summary>
                /// Appraiseds the value.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> AppraisedValue(string value, bool verify = false)
                {
                    return Base.SendTExt("Appraised Value", "txtAppValue", value, verify);
                }
                /// <summary>
                /// Appraiseds the date.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> AppraisedDate(string value, bool verify = false)
                {
                    return Base.SendTExt("Appraised Date", "dtpAppDate", value, verify);
                }
                /// <summary>
                /// Appraiseds the by.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> AppraisedBy(string value, bool verify = false)
                {
                    return Base.SendTExt("Appraised By", "txtAppBy", value, verify);
                }
            }
        }
        /// <summary>
        /// Class ConditionComments.
        /// </summary>
        internal class ConditionComments
        {
            /// <summary>
            /// Runs the test.
            /// </summary>
            /// <param name="notes">The notes.</param>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> RunTest(string notes,bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(ClickOnTab());
                cmd.AddRange(ClickOn.NotesTextBox(verify));
                cmd.AddRange(FillIn.NotesTextBox(notes, verify));

                return cmd;
            }

            /// <summary>
            /// Clicks the on tab.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnTab(bool verify = false)
            {
                return Base.ClickOnElement("Condition Comments", "Condition Comments", verify, GeneralActions.AppAction.FindElementByName);
            }
            /// <summary>
            /// Class ClickOn.
            /// </summary>
            internal class ClickOn
            {
                /// <summary>
                /// Appraiseds the date.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> NotesTextBox(bool verify = false)
                {
                    return Base.ClickOnElement("Condition Text Box", "txtConCom", verify);
                }
            }
            /// <summary>
            /// Class FillIn.
            /// </summary>
            internal class FillIn
            {
                /// <summary>
                /// Noteses the text box.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> NotesTextBox(string value, bool verify = false)
                {
                    return Base.SendTExt("Condition Text Box", "txtConCom", value, verify);
                }
            }
        }

        /// <summary>
        /// Class AdditionalNotes.
        /// </summary>
        internal class AdditionalNotes
        {
            /// <summary>
            /// Runs the test.
            /// </summary>
            /// <param name="notes">The notes.</param>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> RunTest(string notes, bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                
                cmd.AddRange(ClickOnTab());
                cmd.AddRange(ClickOn.NotesTextBox(verify));
                cmd.AddRange(FillIn.NotesTextBox(notes, verify));

                return cmd;
            }
            /// <summary>
            /// Clicks the on tab.
            /// </summary>
            /// <param name="verify">if set to <c>true</c> [verify].</param>
            /// <returns>List&lt;BatchCommandList&gt;.</returns>
            internal static List<BatchCommandList> ClickOnTab(bool verify = false)
            {
                return Base.ClickOnElement("Additional Notes", "Additional Notes", verify,
                    GeneralActions.AppAction.FindElementByName);
            }

            /// <summary>
            /// Class ClickOn.
            /// </summary>
            internal class ClickOn
            {
                /// <summary>
                /// Noteses the text box.
                /// </summary>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> NotesTextBox(bool verify = false)
                {
                    return Base.ClickOnElement("Notes Text Box", "txtAddNotes", verify);
                }
            }
            /// <summary>
            /// Class FillIn.
            /// </summary>
            internal class FillIn
            {
                /// <summary>
                /// Noteses the text box.
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="verify">if set to <c>true</c> [verify].</param>
                /// <returns>List&lt;BatchCommandList&gt;.</returns>
                internal static List<BatchCommandList> NotesTextBox(string value, bool verify = false)
                {
                    return Base.SendTExt("Notes Text Box", "txtAddNotes", value, verify);
                }
            }
        }
    }
}
