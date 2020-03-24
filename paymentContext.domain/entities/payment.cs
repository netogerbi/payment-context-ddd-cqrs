using System;
using paymentContext.domain.ValueObjects;

namespace paymentContext.domain.entities
{
    public abstract class Payment
    {
        protected Payment(
            DateTime PaidDate, 
            DateTime ExpireDate, 
            decimal Total, 
            decimal TotalPaid, 
            Address address, 
            string Owner, 
            Document Document, 
            Email Email)
        {
            this.Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            this.PaidDate = PaidDate;
            this.ExpireDate = ExpireDate;
            this.Total = Total;
            this.TotalPaid = TotalPaid;
            this.Address = address;
            this.Owner = Owner;
            this.Document = Document;
            this.Email = Email;
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public Address Address { get; private set; }
        public string Owner { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
    }
}