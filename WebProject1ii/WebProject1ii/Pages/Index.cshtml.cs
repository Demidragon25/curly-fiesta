using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebProject1ii.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPostGenerateException()
        {
            GenerateException();
            return RedirectToPage("Error", new { ErrorMessage = "An error occurred." });
        }

        private void GenerateException()
        {
            int[] arr = new int[5];
            int value = arr[10]; // Index out of range
        }
    }
}
