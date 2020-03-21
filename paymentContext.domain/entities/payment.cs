using System;
namespace paymentContext.domain.entities
{
    public abstract class Payment
    {
        protected Payment(
            DateTime PaidDate, 
            DateTime ExpireDate, 
            decimal Total, 
            decimal TotalPaid, 
            string BillingAddress, 
            string Owner, 
            string Document, 
            string Email)
        {
            this.Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            this.PaidDate = PaidDate;
            this.ExpireDate = ExpireDate;
            this.Total = Total;
            this.TotalPaid = TotalPaid;
            this.BillingAddress = BillingAddress;
            this.Owner = Owner;
            this.Document = Document;
            this.Email = Email;
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string BillingAddress { get; private set; }
        public string Owner { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
    }
}