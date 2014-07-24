using System;
using System.Linq;

namespace iCalendarSharp.Helpers
{
    class FormatHelper
    {
        /// <summary>
        /// This is necessary for any line breaks in the description to display correctly in Outlook.
        /// </summary>
        /// <param name="description">The string for the body.</param>
        /// <returns></returns>
        public string FixLineBreaksFromHTML(string description)
        {
            string result = string.Empty;

            result = description.Replace("\n", "=0D=0A");
            result = result.Replace("<br />", "=0D=0A");

            return result;
        }
    }
}
