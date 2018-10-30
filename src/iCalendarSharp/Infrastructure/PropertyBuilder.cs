using System;
using System.Linq;
using System.Text;

namespace iCalendarSharp.Infrastructure
{
    /// <summary>
    /// This is the class used to write to and access the properties you need
    /// for your derived Calendar class instance.
    /// </summary>
    public class PropertyBuilder
    {
        #region ctors

        private readonly StringBuilder _sb;

        public PropertyBuilder(StringBuilder sb)
        {
            this._sb = sb;
        }

        #endregion

        #region Public Value Methods

        public void ProdId(string value)
        {
            _sb.AppendFormat("PRODID:{0}", value);
            _sb.AppendLine();
        }

        public void Version(string value = "2.0")
        {

            _sb.AppendFormat("VERSION:{0}", value);
            _sb.AppendLine();
        }

        public void DateStart(string value)
        {
            _sb.AppendFormat("DTSTART:{0}", value);
            _sb.AppendLine();
        }

        public void DateEnd(string value)
        {
            _sb.AppendFormat("DTEND:{0}", value);
            _sb.AppendLine();
        }

        public void DateStamp(string value)
        {
            _sb.AppendFormat("DTSTAMP:{0}", value);
            _sb.AppendLine();
        }

        public void Location(string value)
        {
            _sb.AppendFormat("LOCATION:{0}", value);
            _sb.AppendLine();
        }

        public void Description(string value)
        {
            _sb.AppendFormat("DESCRIPTION;ENCODING=QUOTED-PRINTABLE:={0}{1}", System.Environment.NewLine, value);
            _sb.AppendLine();
        }

        public void Subject(string value)
        {
            _sb.AppendFormat("SUMMARY:{0}", value);
            _sb.AppendLine();
        }

        public void Priority(int value)
        {
            _sb.AppendFormat("PRIORITY:{0}", value);
            _sb.AppendLine();
        }

        /// <summary>
        /// RFC 5545 compliant - legacy
        /// </summary>
        /// <param name="date"></param>
        /// <param name="domain"></param>
        public void UID(string date, string domain)
        {
            _sb.AppendFormat("UID: {0}{1}", date, domain);
            _sb.AppendLine();
        }

        /// <summary>
        /// RFC 7986 compliant
        /// </summary>
        public void UID()
        {
            _sb.AppendFormat("UID:{0}", Guid.NewGuid());
            _sb.AppendLine();
        }

        public void Categories(string value)
        {
            _sb.AppendFormat("CATEGORIES:{0}", value);
            _sb.AppendLine();
        }


        #endregion

        #region Enumerable Methods



        #endregion

        #region Begin Methods

        public void BeginCalendar()
        {
            _sb.AppendLine("BEGIN:VCALENDAR");
        }

        public void BeginEvent()
        {
            _sb.AppendLine("BEGIN:VEVENT");
        }


        #endregion

        #region End Methods

        public void EndEvent()
        {
            _sb.AppendLine("END:VEVENT");
        }

        public void EndCalendar()
        {
            _sb.AppendLine("END:VCALENDAR");
        }

        #endregion
    }
}
