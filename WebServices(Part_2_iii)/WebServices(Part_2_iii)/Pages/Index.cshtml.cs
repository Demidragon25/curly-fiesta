using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebServices_Part_2_iii.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IndexModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult OnGet()
        {
            var session = _httpContextAccessor.HttpContext.Session;

            session.SetString("Time", System.DateTime.Now.ToString());
            session.SetString("UserAgent", Request.Headers["User-Agent"].ToString());
            session.SetString("RemoteIP", Request.HttpContext.Connection.RemoteIpAddress.ToString());
            session.SetString("ProjectName", "CurlyFiesta");
            session.SetString("LambdaTest", "EddieGulay");

            Name = HttpContext.Request.Cookies["UserName"];
            return Page();
        }

        public string Name { get; set; }

        public IActionResult OnPost(string name)
        {
            Name = name;
            HttpContext.Response.Cookies.Append("UserName", name, new CookieOptions
            {
                Expires = System.DateTime.Now.AddMonths(1) // Set the cookie to expire in 1 month
            });
            return Page();
        }
    }
}
