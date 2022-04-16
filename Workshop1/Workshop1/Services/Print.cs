using Workshop1.Contracts.Interface;

namespace Workshop1.Services
{
    /// <inheritdoc/>
    public class Print : IPrint
    {
        /// <inheritdoc/>
        public string PrintCustomer(string name, string age, string address, string phone)
        {
            return $" Name: {name} Age: {age} Address: {address} Phone: {phone}";
        }
    }
}
