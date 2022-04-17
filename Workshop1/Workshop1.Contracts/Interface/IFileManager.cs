using System.Collections.Generic;
using Workshop1.Contracts.Models;

namespace Workshop1.Contracts.Interface
{
    /// <summary>
    /// Defines the <see cref="IFileManager" />.
    /// </summary>
    public interface IFileManager
    {
        /// <summary>
        /// The Write.
        /// </summary>
        void Write(Customer customer);

        /// <summary>
        /// The Read.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Customer> Read();
    }
}
