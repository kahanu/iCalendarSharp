using System;
using System.Linq;

namespace iCalendarSharp.DomainObjects
{
    /// <summary>
    /// These are the basic properties needed for the simplest of messages.
    /// </summary>
    public class CalendarEventRequestBase
    {
        /// <summary>
        /// (Optional) This is the ID of the generating application, such as Outlook.
        /// </summary>
        /// <example>
        /// -//Microsoft Corporation//Outlook 14.0 MIMEDIR//EN
        /// </example>
        public string PRODID { get; set; }

        /// <summary>
        /// The default if left blank is 2.0.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// (Optional) This should be a unique identifier across the network.
        /// </summary>
        /// <example>
        /// UTC Date with a random number and a domain
        /// Example: 20140721T143000Z-A84TU@mydomain.com
        /// </example>
        public string UID { get; set; }

        /// <summary>
        /// The start date in UTC format.
        /// </summary>
        public string DateStart { get; set; }

        /// <summary>
        /// The end date in UTC format.
        /// </summary>
        public string DateEnd { get; set; }

        /// <summary>
        /// (Optional) The location information.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// (Optional) The description that is displayed in the body of the message.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// (Optional) The priorty of the event.  The default is 3.
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// This populates the Summary data of the .ics file, which is the Subject field in Outlook.
        /// </summary>
        public string Subject { get; set; }
    }
}
