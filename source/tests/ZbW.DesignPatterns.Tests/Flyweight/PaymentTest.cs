using ZbW.DesignPatterns.Flyweight;

namespace ZbW.DesignPatterns.Tests.Flyweight
{
    using FluentAssertions;

    using Xunit;

    public class PaymentTest
    {
        [Fact]
        public void PaymentObjectFactory_WhenTwintPaymentStrategy_ThenReturnsOnly1Instance()
        {
            // Arrange
            PaymentObjectFactory paymentObjectFactory = new PaymentObjectFactory();

            // Act
            IPaymentMethod paymentMethod = paymentObjectFactory.GetPaymentMethod("Twint");
            paymentMethod.Pay(200);
            paymentMethod = paymentObjectFactory.GetPaymentMethod("Twint");
            paymentMethod.Pay(230);
            paymentMethod = paymentObjectFactory.GetPaymentMethod("Twint");
            paymentMethod.Pay(290);
            var result = paymentObjectFactory.TotalObjectsCreated;

            // Assert
            result.Should().Be(1);
        }

    }
}