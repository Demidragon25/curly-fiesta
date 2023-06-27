using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace WebServices_Part_2_iii.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IndexModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void OnGet()
        {
            var session = _httpContextAccessor.HttpContext.Session;

            session.SetString("Time", System.DateTime.Now.ToString());
            session.SetString("UserAgent", Request.Headers["User-Agent"].ToString());
            session.SetString("RemoteIP", Request.HttpContext.Connection.RemoteIpAddress.ToString());
            session.SetString("ProjectName", "CurlyFiesta");
            session.SetString("LambdaTest", "EddieGulay");
        }
    }
}
