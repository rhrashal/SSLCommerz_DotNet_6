using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SSLCommerz_AspNetCore.Pages
{
    public class CheckoutCancel : PageModel
    {
        private readonly ILogger<CheckoutCancel> _logger;

        public CheckoutCancel(ILogger<CheckoutCancel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //ViewBag.FailInfo = "There some error while processing your payment. Please try again.";
        }
    }
}