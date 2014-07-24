using System;
using System.Linq;
using iCalendarSharp.Helpers;
using iCalendarSharp.Interfaces;

namespace iCalendarSharp
{
    /// <summary>
    /// This is the main message creator class.
    /// </summary>
    public class Calendar
    {
        #region ctors

        private readonly ICalendar _calendar;

        public Calendar(ICalendar calendar)
        {
            this._calendar = calendar;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Save the message to the file system.
        /// </summary>
        public void Save()
        {
            FileManager.SaveFile(_calendar.FileName, _calendar.Build());
        }

        #endregion
    }
}
