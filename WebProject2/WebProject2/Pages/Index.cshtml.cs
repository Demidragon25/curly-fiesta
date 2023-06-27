using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace WebProject2.Pages
{
    public class IndexModel : PageModel
    {
        public string Name { get; set; }

        public IActionResult OnGet()
        {
            Name = HttpContext.Request.Cookies["UserName"];

            HttpContext.Session.SetString("Time", System.DateTime.Now.ToString());
            HttpContext.Session.SetString("UserAgent", HttpContext.Request.Headers["User-Agent"].ToString());
            HttpContext.Session.SetString("RemoteIP", HttpContext.Connection.RemoteIpAddress.ToString());

            return Page();
        }

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
