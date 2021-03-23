using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
        public static bool Add(string databasePath, string name, string address, string city, string state, string zipCode, string country, string phone, string fax, string eMail, string license, string webSite, bool stillInBusiness, out string errOut)
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
            return Add(databasePath, name, "N/A", "N/A", "N/A", "N/A","N/A", "N/A", "N/A", "N/A", "N/A", "N/A",true, out errOut);
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
        public static bool Update(string databasePath,long id, string name, string address,string address2, string city, string state,
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
    }
}
