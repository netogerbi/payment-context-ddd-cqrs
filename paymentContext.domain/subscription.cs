namespace paymentContext.domain.entities
{
    public class Subscription
    {
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime? expiredAt  { get; set; }
        public List<Payment> payments { get; set; }
    }
}