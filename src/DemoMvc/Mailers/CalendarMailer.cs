using DemoMvc.Models;
using Mvc.Mailer;

namespace DemoMvc.Mailers
{ 
    public class CalendarMailer : MailerBase, ICalendarMailer 	
	{
		public CalendarMailer()
		{
			MasterName="_Layout";
		}

        public virtual MvcMailMessage Success(MessageModel model)
		{
            ViewData.Model = model;

            System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(model.FileName);
            attachment.ContentType = new System.Net.Mime.ContentType("text/calendar");

			return Populate(x =>
			{
				x.Subject = model.Subject;
				x.ViewName = "Success";
                x.Attachments.Add(attachment);
				x.To.Add(model.Email);
			});
		}
 	}
}