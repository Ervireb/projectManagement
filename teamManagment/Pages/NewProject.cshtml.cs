using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace teamManagment.Pages
{
    [Authorize]
    public class webModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
