using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using ZbW.DesignPatterns.Adapter;
using ZbW.DesignPatterns.Strategy;

namespace ZbW.DesignPatterns.Tests.Prototype
{

    public class SalesPrototypTests
    {
        [Fact]
        public void GetSale_WhenDoShallowCopy_ThenChangeTheObjectReference()
        {
            // Arrange
            var sale = new Sale(100, new PercentageDiscountStrategy(50));

            // Act
            var result = sale.ShallowCopy();

            // Assert
            Assert.True(!sale.Equals(result));
        }

        //[Fact]
        //public void GetSale_WhenDoShallowCopy_ThenPricingStrategyHaveTheSameReferance()
        //{
        //    // Arrange
        //    var sale = new Sale(100, new PercentageDiscountStrategy(50));

            // Act
            var result = (Sale)sale.ShallowCopy();

            // Assert
            Assert.True(sale._pricingStrategy.Equals(result._pricingStrategy));
        }

        [Fact]
        public void GetSale_WhenDoDeepCopy_ThenPricingStrategyReferenceChange()
        {
            // Arrange
            var sale = new Sale(100, new PercentageDiscountStrategy(50));

            // Act
            var result = (Sale)sale.DeepCopy();

            // Assert
            Assert.False(sale._pricingStrategy.Equals(result._pricingStrategy));
        }
    }
}
