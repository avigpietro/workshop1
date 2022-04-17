using System.Collections.Generic;
using System.Text;
using Workshop1.Contracts.Interface;
using Workshop1.Contracts.Models;

namespace Workshop1.Services
{
    /// <inheritdoc/>
    public class PrintService : IPrintService
    {
        /// <inheritdoc/>
        public string PrintCustomers(IEnumerable<Customer> customers)
        {
            var stringBuilder = new StringBuilder();

            foreach (var customer in customers)
            {
                stringBuilder.AppendLine($" Name: {customer.Name} Age: {customer.Age} Address: {customer.Address} Phone: {customer.PhoneNumber}");
            }

            return stringBuilder.ToString();
        }
    }
}
