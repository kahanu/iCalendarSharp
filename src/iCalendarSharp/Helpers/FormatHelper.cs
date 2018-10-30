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

            result = BreakLineAt70Chars(description);

            return result;
        }

        /// <summary>
        /// The RFC states the description cannot have any line over 75 characters long,
        /// so the lines must break before that length and end with a line feed and a space.  "\n "
        /// The broken lines will be reassembled in the calendar application.
        /// </summary>
        /// <param name="input">The full message body text.</param>
        /// <returns>The same message body broken short of 75 characters.</returns>
        public string BreakLineAt70Chars(string input)
        {
            string result = string.Empty;

            // =0D=0A is the character code for CRLF in calendars
            string temp = input.Replace("<br />", "=0D=0A")
                               .Replace("\r\n", "=0D=0A");

            while (temp.Length > 70)
            {
                // recursively break the line into 70 character lengths
                // and append a CRLF.
                string first = temp.Substring(0, 70);
                result += first + "\n ";
                temp = temp.Substring(70);
            }

            if (temp.Length > 0)
            {
                result += temp;
            }
            else
            {
                result = temp;
            }

            return result;
        }
    }
}
