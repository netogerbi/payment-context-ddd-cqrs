using System;
using paymentContext.domain.ValueObjects;

namespace paymentContext.domain.entities
{
    public abstract class PayPalPayment : Payment
    {
        protected PayPalPayment(
            string TransactionCode, 
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
            this.TransactionCode = TransactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}