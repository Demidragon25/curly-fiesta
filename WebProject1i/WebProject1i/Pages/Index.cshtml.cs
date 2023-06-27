using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebProject1i.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Comment { get; set; }

        public bool Submitted { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Submitted = false;
        }

        public void OnPost()
        {
            Submitted = true;

            _logger.LogDebug($"Name: {Name}, Comment: {Comment}");
        }
    }
}
