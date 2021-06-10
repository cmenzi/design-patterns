using ZbW.DesignPatterns.Adapter;
using ZbW.DesignPatterns.Builder;
using ZbW.DesignPatterns.Factory;

namespace ZbW.DesignPatterns.Tests.Strategy
{
    using FluentAssertions;

    using Moq;

    using System;
    using System.IO;
    using System.Linq;

    using Xunit;


    public class OrderBuilderTests
    {
        [Fact]
        public void OrderBuilder_AddBuyer_ShouldJohnnyFrank()
        {
            // Arrange
            var orderBuilder = new OrderBuilder();

            // Act
            var result = orderBuilder
                .SetBuyer("Johnny Frank")
                .Build()
                .Buyer;

            // Assert
            result.Should().Be("Johnny Frank");
        }

        [Fact]
        public void OrderBuilder_AddPizza_ShouldBeSaintGall()
        {
            // Arrange
            var orderBuilder = new OrderBuilder();
            var pizza = new SaintGallPizza();

            // Act
            var result = orderBuilder
                .SetPizza(pizza)
                .Build()
                .Pizza;

            // Assert
            result.Should().Be(pizza);
        }

        [Fact]
        public void OrderBuilder_AddPrice_ShouldBe100()
        {
            // Arrange
            var orderBuilder = new OrderBuilder();
     

            // Act
            var result = orderBuilder
                .SetPrice(100)
                .Build()
                .Price;

            // Assert
            result.Should().Be(100);
        }

        [Fact]
        public void OrderBuilder_AddEmployee_ShouldBeEmployeeWithSalary2000()
        {
            // Arrange
            var orderBuilder = new OrderBuilder();
            var employee = new Employee(2000);

            // Act
            var result = orderBuilder
                .SetEmployee(employee)
                .Build()
                .Employee;

            // Assert
            result.Should().Be(employee);
        }
    }
}
