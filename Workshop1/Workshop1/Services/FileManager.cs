using System.Collections.Generic;
using Newtonsoft.Json;
using Ninject;
using Workshop1.Contracts.Interface;
using Workshop1.Contracts.Models;

namespace Workshop1.Services
{
    using System.IO;

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
        public void Write(Customer customer)
        {
            if (!File.Exists(FileLoc)) return;
            using (var sw = StreamWriterFactory.Create(FileLoc))
            {
                sw.BaseStream.Seek(0, SeekOrigin.End);
                sw.WriteLine(JsonConvert.SerializeObject(customer));
            }
        }

        /// <inheritdoc/>
        public IEnumerable<Customer> Read()
        {
            var responseValue = new List<Customer>();

            if (!File.Exists(FileLoc)) return responseValue;
            
            using (TextReader tr = StreamReaderFactory.Create(FileLoc))
            {
                string line;
                while ((line = tr.ReadLine()) != null)
                {
                    responseValue.Add(JsonConvert.DeserializeObject<Customer>(line));
                }
            }

            return responseValue;
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