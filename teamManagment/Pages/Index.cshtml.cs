using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace teamManagment.Pages // Make sure the namespace matches
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // Add the 'Message' property
        public string Message { get; private set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }
    }
}