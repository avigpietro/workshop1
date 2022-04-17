using System;

namespace Workshop1.Unit.Tests.Services
{
    using FluentAssertions;
    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;
    using Workshop1.Contracts.Interface;
    using Workshop1.Contracts.Models;
    using Workshop1.Services;

    /// <summary>
    /// Defines the <see cref="PrintServiceUnitTests" />.
    /// </summary>
    [TestFixture]
    public class PrintServiceUnitTests
    {
        /// <summary>
        /// Gets or sets the PrintService.
        /// </summary>
        public IPrintService PrintService { get; set; }

        /// <summary>
        /// The Setup.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            PrintService = new PrintService();
        }

        /// <summary>
        /// The OnPrint_WhenPrint_ShouldReturnEquivalentString.
        /// </summary>
        [Test]
        public void OnPrint_WhenPrint_ShouldReturnEquivalentString()
        {
            var customers = PrintService.PrintCustomers(
                new List<Customer>
                {
                    new Customer
                    {
                        Address = "Green Avenue 1",
                        PhoneNumber = "1111111",
                        Age = "22",
                        CreditCardNumber = "98123918239",
                        Gender = "Male",
                        Id = "1",
                        LastName = "King",
                        Name = "Lion"
                    },

                    new Customer
                    {
                        Address = "Green Avenue 1",
                        PhoneNumber = "1111111",
                        Age = "33",
                        CreditCardNumber = "1231231321",
                        Gender = "Male",
                        Id = "1",
                        LastName = "King",
                        Name = "Scar"
                    },

                    new Customer
                    {
                        Address = "Green Avenue 1",
                        PhoneNumber = "1111111",
                        Age = "25",
                        CreditCardNumber = "1231231321",
                        Gender = "Female",
                        Id = "1",
                        LastName = "Queen",
                        Name = "Sarabi"
                    }
                });

            customers.Should().NotBeNull();
            customers.Should().BeOfType(typeof(string));
        }
    }
}
