using Ninject;
using Workshop1.Contracts.Interface;

namespace Workshop1.Services
{
    using System.IO;
    using System.Text;

    /// <inheritdoc/>
    public class FileManager : IFileManager
    {
        /// <summary>
        /// Defines the FileLoc.
        /// </summary>
        private const string FileLoc = @"c:\sample1.txt";

        /// <summary>
        /// Gets or sets the StreamWriterFactory.
        /// </summary>
        public IStreamWriterFactory StreamWriterFactory { get; set; }

        /// <summary>
        /// Gets or sets the StreamReaderFactory.
        /// </summary>
        public IStreamReaderFactory StreamReaderFactory { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileManager"/> class.
        /// </summary>
        public FileManager()
        {
            Initialize();

            if (File.Exists(FileLoc)) return;
            File.Create(FileLoc);
        }
        
        /// <inheritdoc/>
        public void Write(string entity)
        {
            if (!File.Exists(FileLoc)) return;
            using (var sw = StreamWriterFactory.Create(FileLoc))
            {
                sw.WriteLine(entity);
            }
        }

        /// <inheritdoc/>
        public string Read()
        {
            if (!File.Exists(FileLoc)) return string.Empty;

            var stringBuilder = new StringBuilder();

            using (TextReader tr = StreamReaderFactory.Create(FileLoc))
            {
                stringBuilder.Append(tr.ReadLine());
            }

            return stringBuilder.ToString();
        }

        private void Initialize()
        {
            var module = new CustomModule();
            IKernel kernel = new StandardKernel(module);
            StreamWriterFactory = kernel.Get<IStreamWriterFactory>();
            StreamReaderFactory = kernel.Get<IStreamReaderFactory>();
        }
    }
}