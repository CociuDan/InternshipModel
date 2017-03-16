using System;

namespace Events
{
    public class NewPaymentEventArgs : EventArgs
    {
        public enum CardType { MasterCard, Visa}
        public readonly string cardType;
        public readonly int customerID;
        public readonly double paymentAmount;
        public readonly int paymentID;

        public NewPaymentEventArgs(CardType cardType, int customerID, double paymentAmount, int paymentID)
        {
            this.cardType = cardType.ToString();
            this.customerID = customerID;
            this.paymentAmount = paymentAmount;
            this.paymentID = paymentID;
        }
    }
}
