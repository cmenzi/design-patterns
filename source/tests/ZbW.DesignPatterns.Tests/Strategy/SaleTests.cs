namespace ZbW.DesignPatterns.Tests.Strategy
{
    using FluentAssertions;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Xunit;

    using ZbW.DesignPatterns.Strategy;

    public class SaleTests
    {
        [Fact]
        public void GetTotal_WhenTotal100And10PercentDiscount_Then90()
        {
            // Arrange
            var sale = new Sale(100, new PercentagePricingStrategy(10));

            // Act
            var result = sale.GetTotal();

            // Assert
            result.Should().Be(90);
        }
    }
}
