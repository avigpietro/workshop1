using System.IO;
using Workshop1.Contracts.Interface;

namespace Workshop1.Factory
{
    /// <inheritdoc />
    public class StreamWriterFactory : IStreamWriterFactory
    {
        /// <inheritdoc />
        public StreamWriter Create(string filePath)
        {
            return new StreamWriter(filePath,true);
        }
    }
}
