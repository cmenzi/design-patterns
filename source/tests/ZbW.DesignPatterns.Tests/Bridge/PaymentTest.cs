using ZbW.DesignPatterns.Bridge;

namespace ZbW.DesignPatterns.Tests.Bridge
{
    using FluentAssertions;

    using Xunit;

    public class PaymentTest
    {
        [Fact]
        public void InstantPaymentPay_WhenTwintPaymentStrategy_ThenCorrectString()
        {
            // Arrange
            var instantPayment = new InstantPayment();
            instantPayment.paymentMethod = new Twint();
            instantPayment.amount = 200;

            // Act
            var result = instantPayment.Pay();

            // Assert
            result.Should().Be("Sofortbezahlung | Payed 200 Fr. with Twint");
        }

        [Fact]
        public void InstantPaymentPay_WhenCashPaymentStrategy_ThenCorrectString()
        {
            // Arrange
            var instantPayment = new InstantPayment();
            instantPayment.paymentMethod = new Cash();
            instantPayment.amount = 200;

            // Act
            var result = instantPayment.Pay();

            // Assert
            result.Should().Be("Sofortbezahlung | Payed 200 Fr. with cash");
        }

        [Fact]
        public void BilledPaymentPay_WhenCreditCardPaymentStrategy_ThenCorrectString()
        {
            // Arrange
            var instantPayment = new BilledPayment();
            instantPayment.paymentMethod = new CreditCard();
            instantPayment.amount = 200;

            // Act
            var result = instantPayment.Pay();

            // Assert
            result.Should().Be("Bezahlung auf Rechnung | Payed 200 Fr. with credit card");
        }
    }
}