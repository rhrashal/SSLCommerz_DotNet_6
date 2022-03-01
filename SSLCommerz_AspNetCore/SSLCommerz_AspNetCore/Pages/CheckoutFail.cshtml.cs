using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SSLCommerz_AspNetCore.Pages
{
    public class CheckoutFail : PageModel
    {
        private readonly ILogger<CheckoutFail> _logger;

        public CheckoutFail(ILogger<CheckoutFail> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}