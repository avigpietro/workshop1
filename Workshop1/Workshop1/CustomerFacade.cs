using Ninject;
using Workshop1.Contracts.Interface;
using Workshop1.Interfaces;
using Workshop1.Services;

namespace Workshop1
{
    ///<inheritdoc/>
    public class CustomerFacade : ICustomerFacade
    {
        /// <summary>
        /// Gets or sets the Print.
        /// </summary>
        public IPrintService Print { get; set; }

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

        /// <summary>
        /// Returns a new instance of a customer
        /// </summary>
        public ICustomerFactory CustomerFactory { get; set; }
        
        public CustomerFacade()
        {
            var module = new CustomModule();
            Kernel = new StandardKernel(module);
            InitializeComponent();
        }

        ///<inheritdoc/>
        public void SaveData(string address, string age, string creditCardNumber, string gender, string id,
            string lastName, string name, string phoneNumber)
        {
            var customer = CustomerFactory.Create(address, age, creditCardNumber, gender, id,
                lastName, name, phoneNumber);
            
            FileManager.Write(customer);
        }

        ///<inheritdoc/>
        public void ShowData()
        {
            var printPhrase = Print.PrintCustomers(FileManager.Read());

            var printPopUp = PrintPopUpFactory.Create();

            printPopUp.lblPrintText.Text = printPhrase;

            printPopUp.Show();
        }

        private void InitializeComponent()
        {
            Print = Kernel.Get<IPrintService>();
            PrintPopUpFactory = Kernel.Get<IPrintPopUpFactory>();
            CustomerFactory = Kernel.Get<ICustomerFactory>();
            FileManager = Kernel.Get<IFileManager>();
        }
    }
}
