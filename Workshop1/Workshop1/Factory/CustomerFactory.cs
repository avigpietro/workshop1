using Workshop1.Contracts.Interface;
using Workshop1.Contracts.Models;

namespace Workshop1.Factory
{
    public class CustomerFactory : ICustomerFactory
    {
        public Customer Create(string address, string age, string creditCardNumber, string gender, string id,
            string lastName, string name, string phoneNumber) =>
            new Customer
            {
                Address = address,
                Age = age,
                CreditCardNumber = creditCardNumber,
                Gender = gender,
                Id = id,
                LastName = lastName,
                Name = name,
                PhoneNumber = phoneNumber
            };
    }
}
