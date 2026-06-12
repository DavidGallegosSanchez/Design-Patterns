using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    //External Interface
    public class PayPalService
    {
        public void SendPayment(decimal totalAmount)
        {
            Console.WriteLine($"[PayPal] Payment of ${totalAmount} processed successfully.");
        }

        public void SetTransactionDetails(string id)
        {
            Console.WriteLine($"[PayPal] Transaction associated with ID: {id}");
        }
    }
}
