using System.IO;

namespace Workshop1.Contracts.Interface
{
    /// <summary>
    /// Defines the <see cref="IStreamWriterFactory" />.
    /// </summary>
    public interface IStreamWriterFactory
    {
        /// <summary>
        /// The Create.
        /// </summary>
        /// <returns>The <see cref="StreamWriter"/>.</returns>
        StreamWriter Create(string filePath);
    }
}
