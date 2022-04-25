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
            cmd.AddRange(ClickOn.CancelButton(verify));
            cmd.AddRange(MainWindow.ToolBar.ClickOnAddGun());
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(AddSimple(manufacture, importer, model, serialNumber, pistolType, caliber,
                condition, purchasedFrom, purchasedPrice, verify));
            cmd.AddRange(ClickOn.AddButton(verify));
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
            cmd.AddRange(ClickOn.Manufacture(verify));
            cmd.AddRange(FillIn.Manufacture(manufacture, verify));
            cmd.AddRange(ClickOn.Importer(verify));
            cmd.AddRange(FillIn.Importer(importer, verify));
            cmd.AddRange(ClickOn.Model(verify));
            cmd.AddRange(FillIn.Model(model, verify));
            cmd.AddRange(ClickOn.SerialNumber(verify));
            cmd.AddRange(FillIn.SerialNumber(serialNumber, verify));
            cmd.AddRange(ClickOn.PistolType(verify));
            cmd.AddRange(FillIn.PistolType(pistolType, verify));
            cmd.AddRange(ClickOn.Caliber(verify));
            cmd.AddRange(FillIn.Caliber(caliber, verify));
            cmd.AddRange(ClickOn.Condition(verify));
            cmd.AddRange(FillIn.Condition(condition, verify));
            cmd.AddRange(ClickOn.PurchasedFrom(verify));
            cmd.AddRange(FillIn.PurchasedFrom(purchasedFrom, verify));
            cmd.AddRange(ClickOn.PurchasedPrice(verify));
            cmd.AddRange(FillIn.PurchasedPrice(purchasedPrice, verify));
            return cmd;
        }

        internal class ClickOn
        {
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

            internal static List<BatchCommandList> SerialNumber( bool verify = false)
            {
                return Base.ClickOnElement("Serial Number", "txtSerial", verify);
            }

            internal static List<BatchCommandList> PistolType(bool verify = false)
            {
                return Base.ClickOnElement("Type", "txtType", verify);
            }

            internal static List<BatchCommandList> Caliber( bool verify = false)
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

        }
        internal class FillIn
        {
            internal static List<BatchCommandList> Manufacture(string value, bool verify = false)
            {
                return Base.SendTExt("Manufacture", "txtManu", value,verify);
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
}
