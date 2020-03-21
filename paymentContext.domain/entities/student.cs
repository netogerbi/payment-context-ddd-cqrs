using System.Linq;
using System.Collections.Generic;

namespace paymentContext.domain.entities
{
    public class Student
    {
        private IList<Subscription> _subscriptions;
        
        public Student(string firstName, string lastName, string document, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Document = document;
            this.Email = email;
            this._subscriptions = new List<Subscription>();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string ShippingAddress { get; private set; }
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