using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace newOlfonet.com_web.Pages
{
    public class itStandarts : PageModel
    {
        private readonly ILogger<ServiceModel> _logger;

        public itStandarts(ILogger<ServiceModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}