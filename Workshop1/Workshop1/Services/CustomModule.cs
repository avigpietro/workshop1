using Workshop1.Contracts.Interface;
using Workshop1.Factory;
using Workshop1.Interfaces;

namespace Workshop1.Services
{
    using Ninject.Modules;

    /// <summary>
    /// Defines the <see cref="CustomModule" />.
    /// </summary>
    public class CustomModule : NinjectModule
    {
        /// <summary>
        /// Maps all dependencies with Ninject
        /// </summary>
        public override void Load()
        {
            Bind<IPrintService>().To<PrintService>().InSingletonScope();
            Bind<IFileManager>().To<FileManager>().InSingletonScope();
            Bind<IPrintPopUpFactory>().To<PrintPopUpFactory>().InSingletonScope();
            Bind<IStreamReaderFactory>().To<StreamReaderFactory>().InSingletonScope();
            Bind<IStreamWriterFactory>().To<StreamWriterFactory>().InSingletonScope();
            Bind<ICustomerFacade>().To<CustomerFacade>().InSingletonScope();
            Bind<ICustomerFactory>().To<CustomerFactory>().InSingletonScope();
        }
    }
}
