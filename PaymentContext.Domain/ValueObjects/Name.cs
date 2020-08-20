using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstname, string lastName)
        {
            FirstName = firstname;
            LastName = lastName;

            if(string.IsNullOrEmpty(FirstName))
                AddNotification("Name.FirstName", "Nome inválido");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }

}