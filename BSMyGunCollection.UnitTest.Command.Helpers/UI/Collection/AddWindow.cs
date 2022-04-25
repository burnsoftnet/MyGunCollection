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
        public static List<BatchCommandList> RunTest(string manufacture,string Importer,string Model,string SerialNumber,string PistolType, bool verify = false)
        {
            List<BatchCommandList> cmd = new List<BatchCommandList>();
            cmd.AddRange(MainWindow.ToolBar.ClickOnAddGun());
            cmd.AddRange(Base.Sleep500());
            cmd.AddRange(ClickOn.Manufacture(verify));
            cmd.AddRange(FillIn.Manufacture(manufacture, verify));
            cmd.AddRange(ClickOn.Importer(verify));
            cmd.AddRange(FillIn.Importer(Importer, verify));
            cmd.AddRange(ClickOn.Model(verify));
            cmd.AddRange(FillIn.Model(Model, verify));
            cmd.AddRange(ClickOn.SerialNumber(verify));
            cmd.AddRange(FillIn.SerialNumber(SerialNumber, verify));
            cmd.AddRange(ClickOn.PistolType(verify));
            cmd.AddRange(FillIn.PistolType(PistolType, verify));
            cmd.AddRange(Base.Sleep());
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
        }
        
    }
}
