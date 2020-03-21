using System;
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
            this.TransactionCode = TransactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}