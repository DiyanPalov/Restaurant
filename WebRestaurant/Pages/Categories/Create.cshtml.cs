using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRestaurant.Model;

namespace WebRestaurant.Pages.Categories
{
    public class CreateModel : PageModel
    {
        public Category Category { get; set; }

        public void OnGet()
        {
        }
    }
}
