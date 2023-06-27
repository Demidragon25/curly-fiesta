using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace WebProject1ii.Pages
{
    public class ErrorModel : PageModel
    {
        public string ErrorMessage { get; set; }

        public void OnGet(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}