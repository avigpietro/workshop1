using Workshop1.Contracts.Interface;

namespace Workshop1
{
    using Ninject;
    using System;
    using System.Windows.Forms;
    using Services;

    /// <summary>
    /// Defines the <see cref="Form1" />.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Gets or sets the Kernel.
        /// </summary>
        public IKernel Kernel { get; set; }

        /// <summary>
        /// An form facade with all necessary scope
        /// </summary>
        public ICustomerFacade FormFacade { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            var module = new CustomModule();
            Kernel = new StandardKernel(module);
            FormFacade = Kernel.Get<ICustomerFacade>();
        }

        /// <summary>
        /// The button1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormFacade.SaveData(txtAddress.Text, txtAge.Text, txtCreditCard.Text,
                    txtGender.Text, txtIdNumber.Text, txtLastName.Text, txtName.Text, txtPhoneNumber.Text);
            }
            catch (Exception exception)
            {
                throw new Exception("Error found:" + exception.Message);

                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnShowCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                FormFacade.ShowData();

            }
            catch (Exception exception)
            {
                throw new Exception("Error found:" + exception.Message);
            }
        }
    }
}
