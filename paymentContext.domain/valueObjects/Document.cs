using paymentContext.domain.Enum;
using PaymentContext.Shared.ValueObjects;

namespace paymentContext.domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number)
        {
            Number = number;
        }

        public string Number { get; private set; }

        public EDocumentType Type { get; private set; }
    }
}