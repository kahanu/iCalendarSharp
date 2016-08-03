using System;
using System.IO;
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
        /// Build the overall vCalendar formatted body using StringBuilder
        /// and the PropertyBuilder class. The body is then converted to a Stream to support
        /// for instance MailMessage and other distribution methods, without storing the file on
        /// a file system.
        /// </summary>
        /// <returns></returns>
        Stream BuildToStream();

        /// <summary>
        /// Get the full physical path to the .ics file.
        /// </summary>
        string FileName { get; }

        #endregion

    }
}
