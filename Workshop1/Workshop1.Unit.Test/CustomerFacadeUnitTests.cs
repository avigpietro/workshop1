namespace Workshop1.Unit.Tests
{
    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;
    using Contracts.Models;
    using Contracts.Interface;
    using Interfaces;

    /// <summary>
    /// Defines the <see cref="CustomerFacadeUnitTests" />.
    /// </summary>
    [TestFixture]
    public class CustomerFacadeUnitTests
    {
        /// <summary>
        /// Gets or sets the PrintMock.
        /// </summary>
        public Mock<IPrintService> PrintMock { get; set; }

        /// <summary>
        /// Gets or sets the PrintPopUpFactoryMock.
        /// </summary>
        public Mock<IPrintPopUpFactory> PrintPopUpFactoryMock { get; set; }

        /// <summary>
        /// Gets or sets the FileManagerMock.
        /// </summary>
        public Mock<IFileManager> FileManagerMock { get; set; }

        /// <summary>
        /// Gets or sets the CustomerFactoryMock.
        /// </summary>
        public Mock<ICustomerFactory> CustomerFactoryMock { get; set; }
        /// <summary>
        /// Gets or sets the CustomerFacade.
        /// </summary>
        public ICustomerFacade CustomerFacade { get; set; }

        /// <summary>
        /// The Setup.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            //Behavior strict will ensure there are setups for all calls on that mock
            //Loose is the default, will return default values, never thrown exception

            PrintMock = new Mock<IPrintService>(MockBehavior.Strict);
            PrintPopUpFactoryMock = new Mock<IPrintPopUpFactory>(MockBehavior.Strict);
            CustomerFactoryMock = new Mock<ICustomerFactory>(MockBehavior.Strict);
            FileManagerMock = new Mock<IFileManager>(MockBehavior.Strict);

            CustomerFacade = new CustomerFacade
            {
                CustomerFactory = CustomerFactoryMock.Object,
                FileManager = FileManagerMock.Object,
                PrintPopUpFactory = PrintPopUpFactoryMock.Object,
                Print = PrintMock.Object
            };
        }

        static IEnumerable<Customer> TestCustomers()
        {
            yield return new Customer
            {
                Address = "Green Avenue 1",
                PhoneNumber = "1111111",
                Age = "22",
                CreditCardNumber = "98123918239",
                Gender = "Male",
                Id = "1",
                LastName = "King",
                Name = "Lion"
            };

            yield return new Customer
            {
                Address = "Green Avenue 1",
                PhoneNumber = "1111111",
                Age = "33",
                CreditCardNumber = "1231231321",
                Gender = "Male",
                Id = "1",
                LastName = "King",
                Name = "Scar"
            };

            yield return new Customer
            {
                Address = "Green Avenue 1",
                PhoneNumber = "1111111",
                Age = "25",
                CreditCardNumber = "1231231321",
                Gender = "Female",
                Id = "1",
                LastName = "Queen",
                Name = "Sarabi"
            };
        }

        [Test]
        public void OnShowData_WhenShowSuccessFull_ShouldPrintPopUp()
        {
            //Arrange
            var printPopUp = new PrintPopUp();
            FileManagerMock.Setup(func => func.Read()).Returns(new List<Customer>());
            PrintMock.Setup(func => func.PrintCustomers(It.IsAny<List<Customer>>())).Returns("Test");
            PrintPopUpFactoryMock.Setup(func => func.Create()).Returns(printPopUp);
            
            //Act
            CustomerFacade.ShowData();

            //Assert
            PrintPopUpFactoryMock.Verify(func=>func.Create(), Times.Once);
        }

        [Test]
        [TestCaseSource(nameof(TestCustomers))]
        public void OnSaveData_WhenHaveMultipleCustomers_MustWriteData(Customer customer)
        {
            //Arrange
            CustomerFactoryMock.Setup(func => func.Create(customer.Address, customer.Age, customer.CreditCardNumber,
                customer.Gender, customer.Id, customer.LastName, customer.Name, customer.PhoneNumber)).Returns(new Customer
            {
                Address = customer.Address,
                Age = customer.Age,
                CreditCardNumber = customer.CreditCardNumber,
                Gender = customer.Gender,
                Id = customer.Id,
                LastName = customer.LastName,
                Name = customer.Name,
                PhoneNumber = customer.PhoneNumber
            });

            FileManagerMock.Setup(func => func.Write(It.IsAny<Customer>()));
            
            //Act
            CustomerFacade.SaveData(customer.Address, customer.Age, customer.CreditCardNumber,
                customer.Gender, customer.Id, customer.LastName, customer.Name, customer.PhoneNumber);
            
            //Assert
            CustomerFactoryMock.Verify(func=> func.Create(customer.Address, customer.Age, customer.CreditCardNumber,
                customer.Gender, customer.Id, customer.LastName, customer.Name, customer.PhoneNumber), Times.Once);
            
            FileManagerMock.VerifyAll();
        }
    }
}
