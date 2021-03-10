using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
namespace BurnSoft.Applications.MGC.UnitTest
{
    /// <summary>
    /// Class General Class with way to test the end results and display the information that was returned in the output
    /// </summary>
    public class General
    {
        /// <summary>
        /// Determines whether [has true value] [the specified b ans].
        /// </summary>
        /// <param name="bAns">if set to <c>true</c> [b ans].</param>
        /// <param name="errOut">The error out.</param>
        public static void HasTrueValue(bool bAns, string errOut = "")
        {
            if (errOut?.Length > 0)
            {
                Debug.Print("ERROR!");
                Debug.Print(errOut);
            }
            Assert.IsTrue(bAns);
        }
        /// <summary>
        /// Determines whether [has false value] [the specified b ans].
        /// </summary>
        /// <param name="bAns">if set to <c>true</c> [b ans].</param>
        /// <param name="errOut">The error out.</param>
        public static void HasFalseValue(bool bAns, string errOut = "")
        {
            if (errOut?.Length > 0)
            {
                Debug.Print("ERROR!");
                Debug.Print(errOut);
            }
            Assert.IsFalse(bAns);
        }
        /// <summary>
        /// Determines whether the specified value has value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errOut">The error out.</param>
        public static void HasValue(string value, string errOut = "")
        {
            bool isLoaded = (value.Length > 0);
            if (isLoaded)
            {
                Debug.Print("Value Returned: {0}", value);
            }
            else
            {
                Debug.Print("NO VALUE RETURNED!!");
            }
            if (errOut?.Length > 0)
            {
                Debug.Print("ERROR!");
                Debug.Print(errOut);
            }
            Assert.IsTrue(isLoaded);
        }
    }
}
