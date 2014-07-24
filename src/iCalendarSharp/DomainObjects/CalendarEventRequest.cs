using System;
using System.Linq;

namespace iCalendarSharp.DomainObjects
{
    /// <summary>
    /// Add properties to this class as is necessary.
    /// </summary>
    public class CalendarEventRequest : CalendarEventRequestBase
    {
        /// <summary>
        /// The full file path to the .vcs file on the file system.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// This is used in the Full Calendar concrete class.
        /// </summary>
        public bool IsRecurring { get; set; }
    }
}
