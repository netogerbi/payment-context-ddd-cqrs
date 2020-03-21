using System;
namespace paymentContext.domain.entities
{
    public abstract class CreditCardPayment : Payment
    {
        protected CreditCardPayment(
            string CardHolderName, 
            string CardNumber, 
            string LastTransactionNumber, 
            DateTime PaidDate, 
            DateTime ExpireDate, 
            decimal Total, 
            decimal TotalPaid, 
            string BillingAddress, 
            string Owner, 
            string Document, 
            string Email) : base(
                PaidDate, 
                ExpireDate, 
                Total, 
                TotalPaid, 
                BillingAddress, 
                Owner, 
                Document, 
                Email)
        {
            this.CardHolderName = CardHolderName;
            this.CardNumber = CardNumber;
            this.LastTransactionNumber = LastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}