using FluentAssertions;
using Xunit;
using ZbW.DesignPatterns.Command;

namespace ZbW.DesignPatterns.Tests
{
    public class CommandTests
    {
        [Fact]
        public void OpenRegister()
        {
            // Arrange
            var openCloseButton = new OpenCloseButton();
            var register = new CashRegister(
                new OpenCashRegisterCommand(openCloseButton),
                new CloseCashRegisterCommand(openCloseButton)
            );

            // Act
            register.Open();

            //Assert
            openCloseButton.IsOpen.Should().Be(true);
        }

        [Fact]
        public void CloseRegister()
        {
            // Arrange
            var openCloseButton = new OpenCloseButton();
            var register = new CashRegister(
                new OpenCashRegisterCommand(openCloseButton),
                new CloseCashRegisterCommand(openCloseButton)
            );

            // Act
            register.Close();

            //Assert
            openCloseButton.IsOpen.Should().Be(false);
        }
    }
}
