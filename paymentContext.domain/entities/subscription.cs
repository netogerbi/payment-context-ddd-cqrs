using System.Collections.Generic;
using System;
using System.Linq;
using paymentContext.domain.ValueObjects;

namespace paymentContext.domain.entities
{
    public class Subscription
    {
        private IList<Payment> _payments;
        public Subscription(DateTime? ExpiredAt)
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.ExpiredAt = ExpiredAt;
            this.Active = true;
            this._payments = new List<Payment>();
        }

        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public DateTime? ExpiredAt  { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get { return this._payments.ToArray(); } }
        public bool Active { get; private set; }

        public void AddPayment(Payment payment)
        {
            _payments.Add(payment);
        }

        public void Activate()
        {
            Active = true;
            UpdatedAt = DateTime.Now;
        }

        public void Deactivate()
        {
            Active = false;
            UpdatedAt = DateTime.Now;
        }
    }
}