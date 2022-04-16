using System.IO;
using Workshop1.Contracts.Interface;

namespace Workshop1.Factory
{
    /// <inheritdoc />
    public class StreamReaderFactory : IStreamReaderFactory
    {
        /// <inheritdoc />
        public StreamReader Create(string filePath)
        {
            return new StreamReader(filePath);
        }
    }
}
