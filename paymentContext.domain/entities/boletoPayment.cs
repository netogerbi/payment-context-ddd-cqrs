using System;
namespace paymentContext.domain.entities
{
    

    public abstract class BoletoPayment : Payment
    {
        protected BoletoPayment(
            string BarCode, 
            int BoletoNumber, 
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
            this.BarCode = BarCode;
            this.BoletoNumber = BoletoNumber;
        }

        public string BarCode { get; private set; }
        public int BoletoNumber { get; private set; }
    }
}