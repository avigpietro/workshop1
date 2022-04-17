using Moq;
using NUnit.Framework;
using Workshop1.Contracts.Interface;

namespace Workshop1.Unit.Tests
{
    /// <summary>
    /// Defines the <see cref="Form1UnitTests" />.
    /// </summary>
    [TestFixture]
    public class Form1UnitTests
    {
        /// <summary>
        /// Gets or sets the Form1.
        /// </summary>
        public Form1 Form1 { get; set; }

        /// <summary>
        /// Gets or sets the FormFacadeMock.
        /// </summary>
        public Mock<ICustomerFacade> FormFacadeMock { get; set; }

        /// <summary>
        /// The SetUp.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            Form1 = new Form1
            {
                txtName = { Text = "Test" },
                txtAge = { Text = "Test" },
                txtAddress = { Text = "Test" },
                txtPhoneNumber = { Text = "Test" }
            };

            FormFacadeMock = new Mock<ICustomerFacade>();
            Form1.FormFacade = FormFacadeMock.Object;
        }

        [Test]
        public void OnShowForm1_WhenRun_ShouldSaveSuccessfully()
        {
            //Arrange
            FormFacadeMock.Setup(form =>
                form.SaveData(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(),
                    It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()));

            //Act
            Form1.button1_Click(null, null);

            //Assert
            FormFacadeMock.Verify(fun => fun.SaveData(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void OnShowForm1_WhenLoadCustomers_ShouldShowSuccessFully()
        {
            //Arrange
            FormFacadeMock.Setup(form =>
                form.ShowData()).Verifiable();

            //Act
            Form1.btnShowCustomers_Click(null, null);

            //Assert
            FormFacadeMock.Verify(fun => fun.ShowData(),Times.Once);
        }
    }
}
