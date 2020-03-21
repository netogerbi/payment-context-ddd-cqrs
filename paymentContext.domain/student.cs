namespace paymentContext.domain.entities
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string document { get; set; }
        public string email { get; set; }
        public string shippingAddress { get; set; }
        public List<Subscription> subscription { get; set; }
        public boll active { get; set; }
    }
}