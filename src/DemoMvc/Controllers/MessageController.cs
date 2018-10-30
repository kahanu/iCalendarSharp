using System;
using System.Linq;
using System.Web.Mvc;
using DemoMvc.Mailers;
using DemoMvc.Models;
using iCalendarSharp;
using iCalendarSharp.Calendars;
using iCalendarSharp.DomainObjects;
using iCalendarSharp.Interfaces;

namespace DemoMvc.Controllers
{
    public class MessageController : BaseController
    {

        #region ctors

        public MessageController()
        {
            this._mailer = new CalendarMailer();
        }

        #endregion

        #region Public Properties

        private ICalendarMailer _mailer;

        public ICalendarMailer Mailer
        {
            get { return _mailer; }
            set { _mailer = value; }
        }


        #endregion


        // GET: Message
        public ActionResult Index()
        {
            return RedirectToAction("Create");
        }

        public ActionResult Create()
        {
            MessageModel model = new MessageModel();
            model.StartDate = DateTime.Now.AddDays(1);
            model.EndDate = DateTime.Now.AddDays(1).AddHours(1);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Create(MessageModel model)
        {
            string filePath = Server.MapPath("~/ics/Demo Message.ics");

            // Store the file path in the model that will be passed to the Mailer object.
            model.FileName = filePath;

            // First thing to do is populate the CalendarEventRequest object.
            CalendarEventRequest cEvent = new CalendarEventRequest();
            cEvent.PRODID = "-//Microsoft Corporation//Outlook 14.0 MIMEDIR//EN";
            cEvent.Version = "2.0";
            cEvent.DateStamp = model.StartDate.ToString("yyyyMMdd\\THHmmss");
            cEvent.DateStart = model.StartDate.ToString("yyyyMMdd\\THHmmss");
            cEvent.DateEnd = model.EndDate.ToString("yyyyMMdd\\THHmmss");
            cEvent.Description = model.Message;
            cEvent.Location = model.Location;
            cEvent.Priority = 3;
            cEvent.Subject = model.Subject;
            cEvent.FileName = filePath;


            try
            {
                // Now create an instance of the calendar object you want to use.  In this case
                // I just want to send a basic simple calendar message.
                ICalendar simple = new SimpleCalendar(cEvent);

                // Now create the Calendar instance and pass it the ICalendar interface implementation.
                Calendar calendar = new Calendar(simple);

                // This will save the ics file to disk where the Mailer object can retrieve it.
                calendar.Save();

                /******* Begin Mailer Functions *********/
                // Don't forget to update your web.config/smtp settings.
                Mailer.Success(model).Send();
            }
            catch (Exception ex)
            {
                string msg = string.Empty;

                if (ex.InnerException != null)
                {
                    msg = ex.InnerException.Message + " - ";
                }

                msg += ex.Message;

                ModelState.AddModelError("", msg);
                return RedirectToAction("Create");
            }

            return View("MessageSuccess");
        }

        public ActionResult MessageSuccess()
        {
            return View();
        }
    }
}