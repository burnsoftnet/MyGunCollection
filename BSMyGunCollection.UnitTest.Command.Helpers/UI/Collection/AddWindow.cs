using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurnSoft.Testing.Apps.Appium;
using BurnSoft.Testing.Apps.Appium.Types;

namespace BSMyGunCollection.UnitTest.Command.Helpers.UI.Collection
{
    public class AddWindow
    {
        public static List<BatchCommandList> RunTest(string manufacture,string importer,string model,
            string serialNumber,string pistolType,string caliber,string condition,
            string purchasedFrom, string purchasedPrice, bool verify = false)
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            cmd.AddRange(MainWindow.ToolBar.ClickOnAddGun());
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(AddSimple(manufacture, importer, model, serialNumber, pistolType, caliber,
                condition, purchasedFrom, purchasedPrice, verify));
            cmd.AddRange(Details.ClickOn.CancelButton(verify));
            cmd.AddRange(MainWindow.ToolBar.ClickOnAddGun());
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(AddSimple(manufacture, importer, model, serialNumber, pistolType, caliber,
                condition, purchasedFrom, purchasedPrice, verify));
            cmd.AddRange(Details.ClickOn.AddButton(verify));
            cmd.AddRange(Base.Sleep());
            return cmd;
        }
        public static List<BatchCommandList> RunTest(string manufacture, string importer, string model,
            string serialNumber, string pistolType, string caliber, string condition,
            string purchasedFrom, string purchasedPrice, string caliber2, string caliber3, string stockType,
            string manufacturedDate, string action, string weight, string placeOfOrgin, string finish, 
            string storage, string sights, string feedSystem, string overallLength, string barrelLength, bool verify = false, string currentChoke = "")
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            cmd.AddRange(MainWindow.ToolBar.ClickOnAddGun());
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(AddSimple(manufacture, importer, model, serialNumber, pistolType, caliber,
                condition, purchasedFrom, purchasedPrice, verify));
            cmd.AddRange(AddOtherDetails(caliber2, caliber3, stockType, manufacturedDate, action, 
                weight, placeOfOrgin, finish, storage, sights, feedSystem, overallLength, barrelLength, verify, currentChoke));
            
            cmd.AddRange(Details.ClickOn.AddButton(verify));
            cmd.AddRange(Base.Sleep());
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

        internal class Details
        {
            internal class ClickOn
            {
                internal static List<BatchCommandList> OverallLength(bool verify = false)
                {
                    return Base.ClickOnElement("Overal lLength", "txtLength", verify);
                }
                internal static List<BatchCommandList> BarrelLength(bool verify = false)
                {
                    return Base.ClickOnElement("BarrelLength", "txtBarLen", verify);
                }
                internal static List<BatchCommandList> CurrentChoke(bool verify = false)
                {
                    return Base.ClickOnElement("Current Choke", "txtChoke", verify);
                }

                internal static List<BatchCommandList> Weight(bool verify = false)
                {
                    return Base.ClickOnElement("Weight", "txtWeight", verify);
                }
                internal static List<BatchCommandList> PlaceOfOrgin(bool verify = false)
                {
                    return Base.ClickOnElement("Place of origin", "txtNationality", verify);
                }
                internal static List<BatchCommandList> Finish(bool verify = false)
                {
                    return Base.ClickOnElement("Finish", "txtFinish", verify);
                }
                internal static List<BatchCommandList> Storage(bool verify = false)
                {
                    return Base.ClickOnElement("Storage Location", "txtStorage", verify);
                }
                internal static List<BatchCommandList> Sights(bool verify = false)
                {
                    return Base.ClickOnElement("Sigths", "txtSights", verify);
                }
                internal static List<BatchCommandList> FeedSystem(bool verify = false)
                {
                    return Base.ClickOnElement("Feed System", "txtFeed", verify);
                }

                internal static List<BatchCommandList> Manufacture(bool verify = false)
                {
                    return Base.ClickOnElement("Manufacture", "txtManu", verify);
                }

                internal static List<BatchCommandList> Importer(bool verify = false)
                {
                    return Base.ClickOnElement("Importer", "txtImporter", verify);
                }

                internal static List<BatchCommandList> Model(bool verify = false)
                {
                    return Base.ClickOnElement("Model", "txtModel", verify);
                }

                internal static List<BatchCommandList> SerialNumber(bool verify = false)
                {
                    return Base.ClickOnElement("Serial Number", "txtSerial", verify);
                }

                internal static List<BatchCommandList> PistolType(bool verify = false)
                {
                    return Base.ClickOnElement("Type", "txtType", verify);
                }

                internal static List<BatchCommandList> Caliber(bool verify = false)
                {
                    return Base.ClickOnElement("Caliber", "txtCal", verify);
                }

                internal static List<BatchCommandList> Condition(bool verify = false)
                {
                    return Base.ClickOnElement("Condition", "cmdCondition", verify);
                }

                internal static List<BatchCommandList> PurchasedFrom(bool verify = false)
                {
                    return Base.ClickOnElement("Purchased From", "txtPurchasedFrom", verify);
                }

                internal static List<BatchCommandList> PurchasedPrice(bool verify = false)
                {
                    return Base.ClickOnElement("Purchased Price", "txtPurPrice", verify);
                }

                internal static List<BatchCommandList> AddButton(bool verify = false)
                {
                    return Base.ClickOnElement("Add button", "btnAdd", verify);
                }

                internal static List<BatchCommandList> CancelButton(bool verify = false)
                {
                    return Base.ClickOnElement("Cancel button", "btnCancel", verify);
                }

                internal static List<BatchCommandList> Caliber2(bool verify = false)
                {
                    return Base.ClickOnElement("Caliber 2", "txtPetLoads", verify);
                }

                internal static List<BatchCommandList> Caliber3(bool verify = false)
                {
                    return Base.ClickOnElement("Caliber 3", "txtCaliber3", verify);
                }

                internal static List<BatchCommandList> StockGripType(bool verify = false)
                {
                    return Base.ClickOnElement("Stock Grip Type", "txtGripType", verify);
                }

                internal static List<BatchCommandList> ManufacturedDate(bool verify = false)
                {
                    return Base.ClickOnElement("Manufactured Date", "txtProduced", verify);
                }
                internal static List<BatchCommandList> Action(bool verify = false)
                {
                    return Base.ClickOnElement("Action", "txtAction", verify);
                }

            }
            internal class FillIn
            {
                internal static List<BatchCommandList> OverallLength(string value, bool verify = false)
                {
                    return Base.SendTExt("Overal lLength", "txtLength", value, verify);
                }
                internal static List<BatchCommandList> BarrelLength(string value, bool verify = false)
                {
                    return Base.SendTExt("BarrelLength", "txtBarLen", value, verify);
                }
                internal static List<BatchCommandList> CurrentChoke(string value, bool verify = false)
                {
                    return Base.SendTExt("Current Choke", "txtChoke", value, verify);
                }
                internal static List<BatchCommandList> Weight(string value, bool verify = false)
                {
                    return Base.SendTExt("Weight", "txtWeight", value, verify);
                }
                internal static List<BatchCommandList> PlaceOfOrgin(string value, bool verify = false)
                {
                    return Base.SendTExt("Place of origin", "txtNationality", value, verify);
                }
                internal static List<BatchCommandList> Finish(string value, bool verify = false)
                {
                    return Base.SendTExt("Finish", "txtFinish", value, verify);
                }
                internal static List<BatchCommandList> Storage(string value, bool verify = false)
                {
                    return Base.SendTExt("Storage Location", "txtStorage", value, verify);
                }
                internal static List<BatchCommandList> Sights(string value, bool verify = false)
                {
                    return Base.SendTExt("Sigths", "txtSights", value, verify);
                }
                internal static List<BatchCommandList> FeedSystem(string value, bool verify = false)
                {
                    return Base.SendTExt("Feed System", "txtFeed", value, verify);
                }
                internal static List<BatchCommandList> StockGripType(string value, bool verify = false)
                {
                    return Base.SendTExt("Stock Grip Type", "txtGripType", value, verify);
                }
                internal static List<BatchCommandList> ManufacturedDate(string value, bool verify = false)
                {
                    return Base.SendTExt("Manufactured Date", "txtProduced", value, verify);
                }
                internal static List<BatchCommandList> Action(string value, bool verify = false)
                {
                    return Base.SendTExt("Action", "txtAction", value, verify);
                }
                internal static List<BatchCommandList> Caliber2(string value, bool verify = false)
                {
                    return Base.SendTExt("Caliber 2", "txtPetLoads", value, verify);
                }
                internal static List<BatchCommandList> Caliber3(string value, bool verify = false)
                {
                    return Base.SendTExt("Caliber 3", "txtCaliber3", value, verify);
                }
                internal static List<BatchCommandList> Manufacture(string value, bool verify = false)
                {
                    return Base.SendTExt("Manufacture", "txtManu", value, verify);
                }

                internal static List<BatchCommandList> Importer(string value, bool verify = false)
                {
                    return Base.SendTExt("Importer", "txtImporter", value, verify);
                }

                internal static List<BatchCommandList> Model(string value, bool verify = false)
                {
                    return Base.SendTExt("Model", "txtModel", value, verify);
                }

                internal static List<BatchCommandList> SerialNumber(string value, bool verify = false)
                {
                    return Base.SendTExt("Serial Number", "txtSerial", value, verify);
                }

                internal static List<BatchCommandList> PistolType(string value, bool verify = false)
                {
                    return Base.SendTExt("Type", "txtType", value, verify);
                }

                internal static List<BatchCommandList> Caliber(string value, bool verify = false)
                {
                    return Base.SendTExt("Caliber", "txtCal", value, verify);
                }

                internal static List<BatchCommandList> Condition(string value, bool verify = false)
                {
                    return Base.SendTExt("Condition", "cmdCondition", value, verify);
                }

                internal static List<BatchCommandList> PurchasedFrom(string value, bool verify = false)
                {
                    return Base.SendTExt("Purchased From", "txtPurchasedFrom", value, verify);
                }

                internal static List<BatchCommandList> PurchasedPrice(string value, bool verify = false)
                {
                    return Base.SendTExt("Purchased Price", "txtPurPrice", value, verify);
                }

            }
        }

        internal class CollectorDetails
        {
            internal static List<BatchCommandList> RunTest(string AppraisedValue,string AppraisedDate, string AppraisedBy,string InsuredValue,  bool verify = false)
            {
                List<BatchCommandList> cmd = new List<BatchCommandList>();
                cmd.AddRange(ClickOnTab());
                cmd.AddRange(ClickOn.AppraisedValue(verify));
                cmd.AddRange(FillIn.AppraisedValue(AppraisedValue, verify));
                cmd.AddRange(ClickOn.AppraisedDate(verify));
                cmd.AddRange(FillIn.AppraisedDate(AppraisedDate, verify));
                cmd.AddRange(ClickOn.AppraisedBy(verify));
                cmd.AddRange(FillIn.AppraisedBy(AppraisedBy, verify));
                cmd.AddRange(ClickOn.InsuredValue(verify));
                cmd.AddRange(FillIn.InsuredValue(InsuredValue, verify));
                return cmd;
            }

            internal static List<BatchCommandList> ClickOnTab(bool verify = false)
            {
                return Base.ClickOnElement("Collector Details", "Collector Details", verify);
            }

            internal class ClickOn
            {
                internal static List<BatchCommandList> InsuredValue(bool verify = false)
                {
                    return Base.ClickOnElement("Insured Value", "txtInsVal", verify);
                }

                internal static List<BatchCommandList> AppraisedValue(bool verify = false)
                {
                    return Base.ClickOnElement("Appraised Value", "txtAppValue", verify);
                }
                internal static List<BatchCommandList> AppraisedDate(bool verify = false)
                {
                    return Base.ClickOnElement("Appraised Date", "dtpAppDate", verify);
                }

                internal static List<BatchCommandList> AppraisedBy(bool verify = false)
                {
                    return Base.ClickOnElement("Appraised By", "txtAppBy", verify);
                }
            }

            internal class FillIn
            {
                internal static List<BatchCommandList> InsuredValue(string value, bool verify = false)
                {
                    return Base.SendTExt("Insured Value", "txtInsVal", value, verify);
                }

                internal static List<BatchCommandList> AppraisedValue(string value, bool verify = false)
                {
                    return Base.SendTExt("Appraised Value", "txtAppValue", value, verify);
                }

                internal static List<BatchCommandList> AppraisedDate(string value, bool verify = false)
                {
                    return Base.SendTExt("Appraised Date", "dtpAppDate", value, verify);
                }

                internal static List<BatchCommandList> AppraisedBy(string value, bool verify = false)
                {
                    return Base.SendTExt("Appraised By", "txtAppBy", value, verify);
                }
            }
        }
        
    }
}
