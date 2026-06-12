using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class PayPalAdapter : IOrderProcessor
    {
        private readonly PayPalService _payPalService;

        public PayPalAdapter(PayPalService payPalService)
        {
            _payPalService = payPalService;
        }

        public void ProcessPayment(string orderId, decimal amount)
        {
            // The adapter converts a single system method
            // into the multiple API calls required by PayPal.
            _payPalService.SetTransactionDetails(orderId);
            _payPalService.SendPayment(amount);
        }
    }
}
