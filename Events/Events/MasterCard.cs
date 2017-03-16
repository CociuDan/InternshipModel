using System;

namespace Events
{
    public class MasterCard
    {
        public MasterCard(PaymentManager pm)
        {
            pm.NewPayment += MC_Payment;
        }

        private void MC_Payment(object sender, NewPaymentEventArgs e)
        {
            if(e.cardType.ToString() == "MasterCard")
            {
                Console.WriteLine("MasterCard Payment has been executed!");
                Console.WriteLine($"Customer ID: {e.customerID}");
                Console.WriteLine($"Payment Amount: {e.paymentAmount}");
                Console.WriteLine($"Payment ID: {e.paymentID}");
            }
        }

        public void Unregister(PaymentManager pm)
        {
            pm.NewPayment -= MC_Payment;
        }
    }
}
