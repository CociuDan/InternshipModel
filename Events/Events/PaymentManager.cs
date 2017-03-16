using System;
using static Events.NewPaymentEventArgs;

namespace Events
{
    public class PaymentManager
    {
        public event EventHandler<NewPaymentEventArgs> NewPayment;

        protected virtual void OnNewPayment(NewPaymentEventArgs e)
        {
            NewPayment?.Invoke(this, e);
        }

        public void SimulateExecutingPayment(CardType cardType, int customerID, double paymentAmount, int paymentID)
        {
            NewPaymentEventArgs e = new NewPaymentEventArgs(cardType, customerID, paymentAmount, paymentID);
            OnNewPayment(e);
        }
    }
}
