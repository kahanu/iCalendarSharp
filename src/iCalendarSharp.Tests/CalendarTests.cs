using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iCalendarSharp.Calendars;
using iCalendarSharp.DomainObjects;
using iCalendarSharp.Interfaces;

namespace iCalendarSharp.Tests
{
    [TestClass]
    public class CalendarTests
    {
        [TestMethod]
        public void simple_calendar_test()
        {
            // Arrange
            CalendarEventRequest cEvent = new CalendarEventRequest();
            cEvent.PRODID = "-//Microsoft Corporation//Outlook 14.0 MIMEDIR//EN";
            cEvent.DateStamp = DateTime.Parse("7/26/2014 7:30AM").ToString("yyyyMMdd\\THHmmss");
            cEvent.DateStart = DateTime.Parse("7/26/2014 7:30AM").ToString("yyyyMMdd\\THHmmss");
            cEvent.DateEnd = DateTime.Parse("7/26/2014 11:30AM").ToString("yyyyMMdd\\THHmmss");
            cEvent.Description = "Important Reminders \r\n" +
                "Please arrive at the course at least 30 minutes prior to Shotgun start time.\r\n" +
                "CASH ONLY for payment of green fees and guest fees!!!\r\n" +
                "Slow play is not permitted. Please be courteous to all golfers and keep on pace.\r\n" +
                "If you have any questions please contact either:\r\n" +
                "communityservices@la-quinta.org - 760-777-7090";
            cEvent.Location = "Classic Club Golf Course - Palm Desert";
            cEvent.Priority = 2;
            cEvent.Subject = "Classic Club Golf Course";
            //cEvent.UID = "something@mydomain.com";
            cEvent.Version = "2.0";
            cEvent.FileName = "Classic Club Golf Course.ics";

            ICalendar simple = new SimpleCalendar(cEvent);

            Calendar calendar = new Calendar(simple);

            // Act
            calendar.Save();

            // Assert
            //Console.WriteLine(actual);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            // Arrange
            CalendarEventRequest cEvent = new CalendarEventRequest();
            cEvent.PRODID = "-//Microsoft Corporation//Outlook 14.0 MIMEDIR//EN";
            cEvent.DateEnd = DateTime.Parse("7/21/2014 9:39PM").ToString("yyyyMMdd\\THHmmss\\Z");
            cEvent.DateStart = DateTime.Parse("7/21/2014 8:39PM").ToString("yyyyMMdd\\THHmmss\\Z");
            cEvent.Description = "This is the description that will end up as the body of the message.<br />This is more stuff.\r\n";
            cEvent.Location = "This is the location";
            cEvent.Priority = 2;
            cEvent.Subject = "This is the subject";
            cEvent.UID = "something@mydomain.com";
            cEvent.Version = "1.0";
            cEvent.FileName = "Recurring Golf Course";
            cEvent.IsRecurring = true;  // this is the new property used in the FullCalendar

            ICalendar simple = new FullCalendar(cEvent);

            Calendar calendar = new Calendar(simple);

            // Act
            calendar.Save();
        }
    }
}
