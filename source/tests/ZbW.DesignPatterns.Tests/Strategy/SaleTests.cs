namespace ZbW.DesignPatterns.Tests.Strategy
{
    using FluentAssertions;

    using Moq;

    using System;

    using Xunit;

    using ZbW.DesignPatterns.Strategy;

    public class SaleTests
    {
        [Fact]
        public void PercentageDiscountStrategy_When100and10Percent_Then90()
        {
            // Arrange
            var percentageDiscountStrategy = new PercentageDiscountStrategy(10);

            // Act
            var result = new Sale(100, percentageDiscountStrategy).GetTotal();

            // Assert
            result.Should().Be(90);
        }

        [Theory]
        [InlineData("100", "100", "90")]
        [InlineData("100", "99", "99")]
        [InlineData("100", "101", "91")]
        public void AbsoluteDiscountOverThresholdStrategy(string threshold, string amount, string expectedResult)
        {
            // Arrange
            var absoluteDiscountOverThresholdStrategy = new AbsoluteDiscountOverThresholdStrategy(decimal.Parse(threshold), 10m);

            // Act
            var result = new Sale(decimal.Parse(amount), absoluteDiscountOverThresholdStrategy).GetTotal();

            // Assert
            result.Should().Be(decimal.Parse(expectedResult));
        }

        [Fact]
        public void DoubleDiscountAfterLunchStrategy_WhenBefore12_ThenSingleDiscount()
        {
            // Arrange
            var timeSourceMock = new Mock<ITimeSource>();
            timeSourceMock.Setup(x => x.Now).Returns(new DateTime(2018, 1, 1, 11, 59, 59));

            var doubleDiscountAfterLunchStrategy = new DoubleDiscountAfterLunchStrategy(timeSourceMock.Object, 10m);

            // Act
            var result = new Sale(100, doubleDiscountAfterLunchStrategy).GetTotal();

            timeSourceMock.Verify(x => x.Now, Times.Once);
            result.Should().Be(90);
        }

        [Fact]
        public void DoubleDiscountAfterLunchStrategy_WhenAfter12_ThenDoubleDiscount()
        {
            // Arrange
            var timeSourceMock = new Mock<ITimeSource>();
            timeSourceMock.Setup(x => x.Now).Returns(new DateTime(2018, 1, 1, 12, 01, 00));

            var doubleDiscountAfterLunchStrategy = new DoubleDiscountAfterLunchStrategy(timeSourceMock.Object, 10m);

            // Act
            var result = new Sale(100, doubleDiscountAfterLunchStrategy).GetTotal();

            // Assert
            result.Should().Be(80);
        }

        public class BeforeLunchTimeSource : ITimeSource
        {
            public DateTime Now => throw new NotImplementedException();
        }
    }
}
