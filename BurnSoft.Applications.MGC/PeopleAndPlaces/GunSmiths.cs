using System;
using System.Collections.Generic;
using System.Data;
using BurnSoft.Applications.MGC.Types;

// ReSharper disable UnusedMember.Local

namespace BurnSoft.Applications.MGC.PeopleAndPlaces
{
    /// <summary>
    /// Class GunSmiths, Main class to handle information about the gun smiths in the database
    /// </summary>
    public class GunSmiths
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MGC.PeopleAndPlaces.GunSmiths";

        /// <summary>
        /// Errors the message for regular Exceptions
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, Exception e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message for access violations
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, AccessViolationException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message for invalid cast exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, InvalidCastException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message argument exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message for argument null exception.
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentNullException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

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
                string sql = $"select * from GunSmith_Contact_Details where gname like '{name}%'";
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
        /// Adds the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="country">The country.</param>
        /// <param name="phone">The phone.</param>
        /// <param name="fax">The fax.</param>
        /// <param name="eMail">The e mail.</param>
        /// <param name="license">The license.</param>
        /// <param name="webSite">The web site.</param>
        /// <param name="stillInBusiness">if set to <c>true</c> [still in business].</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, string name, string address, string city, string state,
            string zipCode, string country, string phone, string fax, string eMail, string license, string webSite,
            bool stillInBusiness, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                int sib = stillInBusiness ? 1 : 0;
                string sql =
                    $"INSERT INTO GunSmith_Contact_Details (gname,Address1,City,State,Zip,country, phone, fax, website,email, lic,sib,sync_lastupdate) " +
                    $"VALUES('{name}','{address}','{city}','{state}','{zipCode}','{country}','{phone}','{fax}','{webSite}','{eMail}','{license}',{sib},Now())";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Add", e);
            }

            return bAns;
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
            return Add(databasePath, name, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", true,
                out errOut);
        }

        /// <summary>
        /// Updates the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="address">The address.</param>
        /// <param name="address2">The address2.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="country">The country.</param>
        /// <param name="phone">The phone.</param>
        /// <param name="fax">The fax.</param>
        /// <param name="eMail">The e mail.</param>
        /// <param name="license">The license.</param>
        /// <param name="webSite">The web site.</param>
        /// <param name="stillInBusiness">if set to <c>true</c> [still in business].</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath, long id, string name, string address, string address2,
            string city, string state,
            string zipCode, string country, string phone, string fax, string eMail, string license, string webSite,
            bool stillInBusiness, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                int sib = stillInBusiness ? 1 : 0;
                string sql =
                    $"Update GunSmith_Contact_Details set gname='{name}',Address1='{address}', Address2='{address2}',City='{city}'," +
                    $"State='{state}',Zip='{zipCode}',country='{country}', phone='{phone}', fax='{fax}', website='{webSite}'" +
                    $",email={eMail}', lic='{license}',sib={sib},sync_lastupdate)=Now() where id={id};";

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Update", e);
            }

            return bAns;
        }

        /// <summary>
        /// Determines whether [has work ordersn attached] [the specified database path].
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="Exception"></exception>
        public static int HasWorkOrdersnAttached(string databasePath, long id, out string errOut)
        {
            int iAns = 0;
            errOut = @"";
            try
            {
                string sql = $"SELECT Count(*) as Total from GunSmith_Details where GSID={id}";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
                iAns = dt.Rows.Count;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("HasWorkOrdersnAttached", e);
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
                string sql = $"Delete from GunSmith_Contact_Details where id={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Delete", e);
            }

            return bAns;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="Exception"></exception>
        public static string GetName(string databasePath, long id, out string errOut)
        {
            string sAns = @"";
            errOut = @"";
            try
            {
                string sql = $"SELECT gname from GunSmith_Contact_Details where id={id}";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut?.Length > 0) throw new Exception(errOut);
                foreach (DataRow d in dt.Rows)
                {
                    sAns = d["gname"].ToString();
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetName", e);
            }

            return sAns;
        }

        /// <summary>
        /// Gets the identifier.
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
                string sql = $"SELECT id from GunSmith_Contact_Details where gname='{name}'";
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
        /// Gets the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;GunSmithContacts&gt;.</returns>
        /// <exception cref="Exception"></exception>
        public static List<GunSmithContacts> Get(string databasePath, out string errOut)
        {
            List<GunSmithContacts> lst = new List<GunSmithContacts>();
            try
            {
                string sql = $"select * from GunSmith_Contact_Details";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw  new Exception(errOut);
                lst = GetList(dt, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Get", e);
            }

            return lst;
        }
        /// <summary>
        /// Gets the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;GunSmithContacts&gt;.</returns>
        /// <exception cref="Exception"></exception>
        public static List<GunSmithContacts> Get(string databasePath,long id, out string errOut)
        {
            List<GunSmithContacts> lst = new List<GunSmithContacts>();
            try
            {
                string sql = $"select * from GunSmith_Contact_Details where id={id}";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                lst = GetList(dt, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Get", e);
            }

            return lst;
        }
        /// <summary>
        /// Gets the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;GunSmithContacts&gt;.</returns>
        /// <exception cref="Exception"></exception>
        public static List<GunSmithContacts> Get(string databasePath, string name, out string errOut)
        {
            List<GunSmithContacts> lst = new List<GunSmithContacts>();
            try
            {
                string sql = $"select * from GunSmith_Contact_Details where gname='{name}'";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                lst = GetList(dt, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Get", e);
            }

            return lst;
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;GunSmithContacts&gt;.</returns>
        private static List<GunSmithContacts> GetList(DataTable dt, out string errOut)
        {
            List<GunSmithContacts> lst = new List<GunSmithContacts>();
            errOut = @"";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new GunSmithContacts()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Name = d["gName"].ToString(),
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
                errOut = ErrorMessage("GetList", e);
            }
            return lst;
        }
}
}
