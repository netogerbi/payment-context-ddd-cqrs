using System;
using paymentContext.domain.ValueObjects;

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
            this.BarCode = BarCode;
            this.BoletoNumber = BoletoNumber;
        }

        public string BarCode { get; private set; }
        public int BoletoNumber { get; private set; }
    }
}