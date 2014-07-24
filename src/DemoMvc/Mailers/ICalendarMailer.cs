using DemoMvc.Models;
using Mvc.Mailer;

namespace DemoMvc.Mailers
{ 
    public interface ICalendarMailer
    {
			MvcMailMessage Success(MessageModel model);
	}
}