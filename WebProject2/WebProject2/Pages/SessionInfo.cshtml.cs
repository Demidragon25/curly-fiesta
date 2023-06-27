using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebProject2.Pages
{
    public class SessionInfoModel : PageModel
    {
        public string Time { get; set; }
        public string UserAgent { get; set; }
        public string RemoteIP { get; set; }

        public void OnGet()
        {
            Time = HttpContext.Session.GetString("Time");
            UserAgent = HttpContext.Session.GetString("UserAgent");
            RemoteIP = HttpContext.Session.GetString("RemoteIP");
        }
    }
}
