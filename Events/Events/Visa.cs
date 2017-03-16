using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Visa
    {
        public Visa(PaymentManager pm)
        {
            pm.NewPayment += V_Payment;
        }

        private void V_Payment(object sender, NewPaymentEventArgs e)
        {
            if (e.cardType.ToString() == "Visa")
            {
                Console.WriteLine("Visa Payment has been executed!");
                Console.WriteLine($"Customer ID: {e.customerID}");
                Console.WriteLine($"Payment Amount: {e.paymentAmount}");
                Console.WriteLine($"Payment ID: {e.paymentID}");
            }
        }

        public void Unregister(PaymentManager pm)
        {
            pm.NewPayment -= V_Payment;
        }
    }
}
