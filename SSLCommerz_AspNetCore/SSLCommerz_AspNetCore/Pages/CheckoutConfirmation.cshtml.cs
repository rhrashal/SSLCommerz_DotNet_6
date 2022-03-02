using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSLCommerz_AspNetCore.PaymentGateway;

namespace SSLCommerz_AspNetCore.Pages
{
    public class CheckoutConfirmation : PageModel
    {
        private readonly ILogger<CheckoutConfirmation> _logger;

        public CheckoutConfirmation(ILogger<CheckoutConfirmation> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //if (!(!String.IsNullOrEmpty(Request.Form["status"]) && Request.Form["status"] == "VALID"))
            //{
            //    //ViewBag.SuccessInfo = "There some error while processing your payment. Please try again.";
            //    //return View();
            //}

            string TrxID = Request.Form["tran_id"];
            // AMOUNT and Currency FROM DB FOR THIS TRANSACTION
            string amount = "85000";
            string currency = "BDT";

            var storeId = "u621de8b235d25";
            var storePassword = "u621de8b235d25@ssl";

            SSLCommerzGatewayProcessor sslcz = new SSLCommerzGatewayProcessor(storeId, storePassword, true);
            var resonse = sslcz.OrderValidate(TrxID, amount, currency, Request);
            var successInfo = $"Validation Response: {resonse}";
            //ViewBag.SuccessInfo = successInfo;

            //return View();

        }
    }
}