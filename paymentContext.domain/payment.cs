namespace paymentContext.domain.entities
{
    public abstract class Payment
    {
        public int number { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime expireDate { get; set; }
        public decimal total { get; set; }
        public decimal totalPaid { get; set; }
        public string billingAddress { get; set; }
        public string owner { get; set; }
        public string document { get; set; }
        public string email { get; set; }
    }

    public abstract class BoletoPayment : Payment
    {
        public string barCode { get; set; }
        public int boletoNumber { get; set; }
    }

    public abstract class CreditCardPayment : Payment
    {
        public string cardHolderName { get; set; }
        public string cardNumber { get; set; }
        public string lastTransactionNumber { get; set; }
    }

    public abstract class PayPalPayment : Payment
    {
        
    }
}