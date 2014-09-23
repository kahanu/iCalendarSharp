using System;
using System.Linq;

namespace iCalendarSharp.Interfaces
{
    /// <summary>
    /// All concrete calendars should implement this interface.
    /// </summary>
    public interface ICalendar
    {

        #region Interface Members

        /// <summary>
        /// Build the overall vCalendar formatted body using StringBuilder
        /// and the PropertyBuilder class.
        /// </summary>
        /// <returns></returns>
        string Build();

        /// <summary>
        /// Get the full physical path to the .ics file.
        /// </summary>
        string FileName { get; }

        #endregion

    }
}
