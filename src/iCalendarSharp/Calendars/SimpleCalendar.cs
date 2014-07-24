using System;
using System.Linq;
using System.Text;
using iCalendarSharp.DomainObjects;
using iCalendarSharp.Helpers;
using iCalendarSharp.Infrastructure;
using iCalendarSharp.Interfaces;

namespace iCalendarSharp.Calendars
{
    public class SimpleCalendar : ICalendar
    {
        #region ctors

        private readonly CalendarEventRequest _request;

        public SimpleCalendar(CalendarEventRequest request)
        {
            this._request = request;
        }

        #endregion

        /// <summary>
        /// The full physical path to the .vcs file.
        /// </summary>
        public string FileName
        {
            get { return _request.FileName; }
        }

        /// <summary>
        /// Build the appointment message.
        /// </summary>
        /// <returns></returns>
        public string Build()
        {
            StringBuilder sb = new StringBuilder();
            FormatHelper helper = new FormatHelper();
            PropertyBuilder prop = new PropertyBuilder(sb);

            // These are the basic message header properties needed for every message.
            prop.BeginCalendar();
            prop.Version(_request.Version);
            prop.BeginEvent();

            // These are the message specific properties needed just for my particular purpose.
            // In this case, it's just a basic calendar appointment with no bells-and-whistles.
            prop.DateStart(_request.DateStart);
            prop.DateEnd(_request.DateEnd);
            prop.Location(_request.Location);
            prop.Description(helper.FixLineBreaksFromHTML(_request.Description));
            prop.Subject(_request.Subject);
            prop.Priority(_request.Priority);

            // These are the basic footer message properties.
            prop.EndEvent();
            prop.EndCalendar();

            string calendar = sb.ToString();

            return calendar;
        }



    }
}
