using System;
using paymentContext.domain.ValueObjects;

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
            Address address, 
            string Owner, 
            Document Document, 
            Email Email) : base(
                PaidDate, 
                ExpireDate, 
                Total, 
                TotalPaid, 
                address, 
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