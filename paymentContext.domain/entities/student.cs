using System.Linq;
using System.Collections.Generic;
using paymentContext.domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace paymentContext.domain.entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;
        
        public Student(Name name, Document document, Email email)
        {
            this.Name = name;
            this.Document = document;
            this.Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return this._subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            foreach (var sub in _subscriptions)
            {
                sub.Deactivate();
            }
            _subscriptions.Add(subscription);
        }
    }
}