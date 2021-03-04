using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BurnSoft.Applications.MGC.AutoFill;
using BurnSoft.Applications.MGC.Types;
using BurnSoft.Universal;

namespace BurnSoft.Applications.MGC.PeopleAndPlaces
{
    /// <summary>
    /// Class Contacts handling class
    /// </summary>
    public class Shops
    {
        #region "Exception Error Handling"        
        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MGC.PeopleAndPlaces.Shops";
        /// <summary>
        /// Errors the message for regular Exceptions
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, Exception e) => $"{ClassLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message for access violations
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, AccessViolationException e) => $"{ClassLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message for invalid cast exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, InvalidCastException e) => $"{ClassLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message argument exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentException e) => $"{ClassLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message for argument null exception.
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentNullException e) => $"{ClassLocation}.{functionName} - {e.Message}";
        #endregion        
        /// <summary>
        /// Existses the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="Exception"></exception>
        public static bool Exists(string databasePath, string name, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                //BSOtherObjects obj = new BSOtherObjects();
                //name = obj.FC(name);
                string sql = $"select * from Gun_Shop_Details where name like '{name}%'";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
                bAns = dt.Rows.Count > 0;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Exists", e);
            }
            return bAns;
        }
        /// <summary>
        /// Counts the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="Exception"></exception>
        public static int Count(string databasePath, string name, out string errOut)
        {
            int iAns = 0;
            errOut = @"";
            try
            {
                //BSOtherObjects obj = new BSOtherObjects();
                //name = obj.FC(name);
                string sql = $"select * from Gun_Shop_Details where name like '{name}%'";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
                iAns = dt.Rows.Count;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Count", e);
            }
            return iAns;
        }
        /// <summary>
        /// Adds the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, string name, out string errOut)
        {
            return Add(databasePath, name, "N/A", "N/A", "N/A", "N/A", out errOut);
        }
        /// <summary>
        /// Adds the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, string name,string address, string city, string state, string zipCode, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                string sql =
                    $"INSERT INTO Gun_Shop_Details (name,Address1,City,State,Zip,sync_lastupdate) VALUES('{name}','{address}','{city}','{state}','{zipCode}',Now())";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Add", e);
            }

            return bAns;
        }

        /// <summary>
        /// Updates the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="address">The address.</param>
        /// <param name="address2"></param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="isStillInBusiness">Still in business</param>
        /// <param name="errOut">The error out.</param>
        /// <param name="country">Country</param>
        /// <param name="phone">Phone number</param>
        /// <param name="fax">Fax, yes people still use them</param>
        /// <param name="website">Website</param>
        /// <param name="email">email</param>
        /// <param name="license">FFLor drivers license or C&R license</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath,int id, string name, string address, string address2, string city, string state, string zipCode,string country, string phone, string fax, string website, string email,string license, bool isStillInBusiness, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                int sib = isStillInBusiness ? 1 : 0;
                string sql =
                    $"UPDATE Gun_Shop_Details set name='{name}',Address1='{address}',Address2='{address2}',City='{city}',State='{state}',Zip='{zipCode}',sync_lastupdate=Now(), Country='{country}', phone='{phone}', fax='{fax}', website='{website}', email='{email}', lic='{license}',SIB={sib} where id={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Add", e);
            }

            return bAns;
        }
        /// <summary>
        /// Determines whether [has collection attached] [the specified database path].
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if [has collection attached] [the specified database path]; otherwise, <c>false</c>.</returns>
        /// <exception cref="Exception"></exception>
        public static int HasCollectionAttached(string databasePath, long id, out string errOut)
        {
            int iAns = 0;
            errOut = @"";
            try
            {
                string sql = $"SELECT Count(*) as Total from Gun_Collection where SID={id}";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
                iAns = dt.Rows.Count;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("HasCollectionAttached", e);
            }
            return iAns;
        }
        /// <summary>
        /// Deletes the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Delete(string databasePath, long id, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                string sql = $"Delete from Gun_Shop_Details where id={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Delete", e);
            }

            return bAns;
        }
        /// <summary>
        /// Gets the name of the shop by the id.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="Exception"></exception>
        public static string GetName(string databasePath, long id, out string errOut)
        {
            string sAns = @"";
            errOut= @"";
            try
            {
                string sql = $"SELECT name from Gun_Shop_Details where id={id}";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
                foreach (DataRow d in dt.Rows)
                {
                    sAns = d["name"].ToString();
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetName", e);
            }
            return sAns;
        }
        /// <summary>
        /// Gets the identifier by the shop name.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="Exception"></exception>
        public static long GetId(string databasePath, string name, out string errOut)
        {
            long lAns = 0;
            errOut = @"";
            try
            {
                string sql = $"SELECT id from Gun_Shop_Details where name='{name}'";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
                foreach (DataRow d in dt.Rows)
                {
                    lAns = Convert.ToInt32(d["id"].ToString());
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetId", e);
            }
            return lAns;
        }
        /// <summary>
        /// Gets the specified shop by id from the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;GunShopDetails&gt;.</returns>
        /// <exception cref="Exception"></exception>
        public static List<GunShopDetails> Get(string databasePath, int id, out string errOut)
        {
            List<GunShopDetails> lst = new List<GunShopDetails>();
            errOut = @"";
            try
            {
                List<GunShopDetails> tmp = Get(databasePath, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
                lst = tmp.Where(s => s.Id == id).ToList();
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Get", e);
            }
            return lst;
        }
        /// <summary>
        /// Gets all the shop details in the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;GunShopDetails&gt;.</returns>
        /// <exception cref="Exception"></exception>
        public static List<GunShopDetails> Get(string databasePath, out string errOut)
        {
            List<GunShopDetails> lst = new List<GunShopDetails>();
            errOut = @"";
            try
            {
                string sql = "select * from Gun_Shop_Details";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);

                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new GunShopDetails()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Name = d["Name"].ToString(),
                        Address1 = d["Address1"].ToString(),
                        Address2 = d["Address2"].ToString(),
                        City = d["City"].ToString(),
                        State = d["State"].ToString(),
                        ZipCode = d["Zip"].ToString(),
                        Phone = d["Phone"].ToString(),
                        Country = d["Country"].ToString(),
                        Email = d["Email"].ToString(),
                        Lic = d["Lic"].ToString(),
                        WebSite = d["WebSite"].ToString(),
                        Fax = d["Fax"].ToString(),
                        StillInBusiness = (Convert.ToInt32(d["SIB"].ToString()) == 1)
                    });
                }

            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Get", e);
            }
            return lst;
        }
    }
}
