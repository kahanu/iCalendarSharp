using System;
using System.Linq;
using iCalendarSharp.DomainObjects;
using iCalendarSharp.Interfaces;

namespace iCalendarSharp.Calendars
{
    public class FullCalendar : ICalendar
    {
        #region ctors

        private readonly CalendarEventRequest _request;

        public FullCalendar(CalendarEventRequest request)
        {
            this._request = request;
        }

        #endregion

        public string Build()
        {
            // This is just a demo to show that different concrete classes can implement different properties.
            // For it to work correctly, all the necessary PropertyBuilder methods would have to be
            // implemented here, like in the SimpleCalendar class.
            return string.Format("IsRecurring:{0}", _request.IsRecurring);
        }

        public string FileName
        {
            get { return _request.FileName; }
        }
    }
}
