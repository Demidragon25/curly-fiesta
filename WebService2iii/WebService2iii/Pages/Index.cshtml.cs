using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;


namespace WebService2iii.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Add values to the Session dictionary
            HttpContext.Session.SetString("Time", System.DateTime.Now.ToString());
            HttpContext.Session.SetString("UserAgent", Request.Headers["User-Agent"]);
            HttpContext.Session.SetString("RemoteIP", HttpContext.Connection.RemoteIpAddress.ToString());
        }
    }
}
