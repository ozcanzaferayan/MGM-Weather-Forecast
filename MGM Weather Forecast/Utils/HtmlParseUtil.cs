using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MgmWeatherForecast.Utils
{
    /// <summary>
    /// Replaces/Removes html special characters with originals
    /// Special characters list: http://math.uh.edu/~hjm/HTML%20Tag%20List.htm
    /// </summary>
    public static class HtmlParseUtil
    {
        /// <summary>
        /// Replaces &#176; decimal with ° sign
        /// </summary>
        /// <param name="degreeDecimal">The string includes degree decimal sign.</param>
        /// <returns>String with ° sign</returns>
        public static string ReplaceDegree(this string degreeDecimal)
        {
            return degreeDecimal.Replace("&#176;", "°");
        }

        /// <summary>
        /// Replaces &#39; decimal with ' sign
        /// </summary>
        /// <param name="quoteDecimal">The string includes quotedecimal sign.</param>
        /// <returns>String with ' sign</returns>
        public static string ReplaceQuote(this string quoteDecimal)
        {
            return quoteDecimal.Replace("&#39;", "'");
        }

        /// <summary>
        /// Replaces the quote and degree.
        /// </summary>
        /// <param name="locationString">The location string.</param>
        public static string ReplaceQuoteAndDegree(this string locationString)
        {
            return locationString.ReplaceDegree().ReplaceQuote();
        }

        /// <summary>
        /// Removes &nbsp; from string
        /// </summary>
        /// <param name="quoteDecimal">The string includes &nbsp; sign.</param>
        /// <returns>String without &nbsp;</returns>
        public static string RemoveNbsp(this string nbsp)
        {
            return nbsp.Replace("&nbsp;", "");
        }
    }
}
