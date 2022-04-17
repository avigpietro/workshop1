namespace Workshop1.Contracts.Interface
{
    using System.Collections.Generic;
    using Models;

    /// <summary>
    /// Defines the <see cref="IPrintService" />.
    /// </summary>
    public interface IPrintService
    {
        /// <summary>
        /// The Print.
        /// </summary>
        /// <param name="customers">The customers<see cref="IEnumerable{Customer}"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        string PrintCustomers(IEnumerable<Customer> customers);
    }
}
