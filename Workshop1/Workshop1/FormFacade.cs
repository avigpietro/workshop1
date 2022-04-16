using Ninject;
using Workshop1.Contracts.Interface;
using Workshop1.Interfaces;
using Workshop1.Services;

namespace Workshop1
{
    ///<inheritdoc/>
    public class FormFacade : IFormFacade
    {
        /// <summary>
        /// Gets or sets the Print.
        /// </summary>
        public static IPrint Print { get; set; }

        /// <summary>
        /// Gets or sets the Kernel.
        /// </summary>
        public IKernel Kernel { get; set; }

        /// <summary>
        /// Gets or sets the PrintPopUpFactory.
        /// </summary>
        public IPrintPopUpFactory PrintPopUpFactory { get; set; }

        /// <summary>
        /// File manager that helps to write and read files
        /// </summary>
        public IFileManager FileManager { get; set; }


        public FormFacade()
        {
            var module = new CustomModule();
            Kernel = new StandardKernel(module);
            InitializeComponent();
        }

        ///<inheritdoc/>
        public void ShowData(string name, string age, string address, string phoneNumber)
        {
            var printPhrase = Print.PrintCustomer(name, age, address, phoneNumber);

            var printPopUp = PrintPopUpFactory.Create();

            printPopUp.lblPrintText.Text = printPhrase;

            printPopUp.Show();

            FileManager.Write(printPhrase);
        }
        
        private void InitializeComponent()
        {
            Print = Kernel.Get<IPrint>();
            PrintPopUpFactory = Kernel.Get<IPrintPopUpFactory>();
            FileManager = Kernel.Get<IFileManager>();
        }
    }
}
