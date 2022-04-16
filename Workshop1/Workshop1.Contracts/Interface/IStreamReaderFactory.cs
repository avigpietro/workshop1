using System.IO;

namespace Workshop1.Contracts.Interface
{
    /// <summary>
    /// Defines the <see cref="IStreamWriterFactory" />.
    /// </summary>
    public interface IStreamReaderFactory
    {
        /// <summary>
        /// The Create.
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string"/>.</param>
        /// <returns>The <see cref="StreamWriter"/>.</returns>
        StreamReader Create(string filePath);
    }
}
