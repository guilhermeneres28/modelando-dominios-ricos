using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstname, string lastName)
        {
            Firstname = firstname;
            LastName = lastName;
        }

        public string Firstname { get; private set; }
        public string LastName { get; private set; }
    }

}