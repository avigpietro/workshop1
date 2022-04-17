namespace Workshop1.Contracts.Interface
{
    using System.Collections.Generic;
    using Models;

    /// <summary>
    /// Defines the <see cref="IPrint" />.
    /// </summary>
    public interface IPrint
    {
        /// <summary>
        /// The Print.
        /// </summary>
        /// <param name="customers">The customers<see cref="IEnumerable{Customer}"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        string PrintCustomer(IEnumerable<Customer> customers);
    }
}
