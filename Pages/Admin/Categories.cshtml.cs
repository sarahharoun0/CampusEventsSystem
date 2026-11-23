using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Campus_event.Pages.Admin
{
    [Authorize(Roles = "Administrator")]
    public class CategoriesModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
