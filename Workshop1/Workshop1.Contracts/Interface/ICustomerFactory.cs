using Workshop1.Contracts.Models;

namespace Workshop1.Contracts.Interface
{
    /// <summary>
    /// Defines the <see cref="ICustomerFactory" />.
    /// </summary>
    public interface ICustomerFactory
    {
        /// <summary>
        /// The Create.
        /// </summary>
        /// <returns>The <see cref="Customer"/>.</returns>
        Customer Create(string address, string age, string creditCardNumber, string gender, string id,
            string lastName, string name, string phoneNumber);
    }
}
