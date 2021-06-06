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
        public void GetSale_WhenDoShallowCopy_ThenChangeTheObjectReferance()
        {
            // Arrange
            var sale = new Sale(100, new PercentageDiscountStrategy(50));

            // Act
            var result = sale.ShallowCopy();

            // Assert
            Assert.True(!sale.Equals(result));
        }

        [Fact]
        public void GetSale_WhenDoShallowCopy_ThenPricingStrategyHaveTheSameReferance()
        {
            // Arrange
            var sale = new Sale(100, new PercentageDiscountStrategy(50));

            FieldInfo _pricingStrategyOriginal = typeof(Sale).GetField(
                                                                "_pricingStrategy",
                                                                BindingFlags.Instance | BindingFlags.NonPublic);

            var pricingStrategyOriginal = (IPricingStrategy)_pricingStrategyOriginal.GetValue(sale);

            // Act
            FieldInfo _pricingStrategyShallowCopy = typeof(Sale).GetField(
                                                                "_pricingStrategy",
                                                                BindingFlags.Instance | BindingFlags.NonPublic);

            var result = (IPricingStrategy)_pricingStrategyShallowCopy.GetValue(sale);

            // Assert
            Assert.True(pricingStrategyOriginal.Equals(result));
        }

        [Fact]
        public void GetSale_WhenDoDeepCopy_ThenPricingStrategyReferanceChange()
        {
            // Arrange
            var sale = new Sale(100, new PercentageDiscountStrategy(50));

            FieldInfo _pricingStrategyOriginal = typeof(Sale).GetField(
                                                                "_pricingStrategy",
                                                            BindingFlags.Instance | BindingFlags.NonPublic);

            var pricingStrategyOriginal = (IPricingStrategy)_pricingStrategyOriginal.GetValue(sale);

            // Act
            var _deepCopy = (Sale)sale.DeepCopy();
            FieldInfo _pricingStrategyDeepCopy = typeof(Sale).GetField(
                                                            "_pricingStrategy",
                                                            BindingFlags.Instance | BindingFlags.NonPublic);

            var result = (IPricingStrategy)_pricingStrategyDeepCopy.GetValue(_deepCopy);

            // Assert
            Assert.True(pricingStrategyOriginal.Equals(result));
        }
    }
}
