namespace ZbW.DesignPatterns.Tests.Adapter
{
    using FluentAssertions;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Xunit;

    using ZbW.DesignPatterns.Adapter;

    public class EmployeeManagerTests
    {
        [Fact]
        public void GetSalaryObjectAdapter_WhenEmployeeAndPresident_ThenAllSalariesListed()
        {
            // Arrange
            var employeeManager = new EmployeeManager();

            employeeManager.Add(new Employee(100_000m));
            employeeManager.Add(new Employee(060_000m));
            employeeManager.Add(new EmployeeObjectAdapter(new PresidentOfTheBoard(1_000_000m)));

            // Act
            var result = employeeManager.PaySalaries();

            // Assert
            result.Should().Be(1_160_000m);
        }

        [Fact]
        public void GetSalaryClassAdapter_WhenEmployeeAndPresident_ThenAllSalariesListed()
        {
            // Arrange
            var employeeManager = new EmployeeManager();

            employeeManager.Add(new Employee(100_000m));
            employeeManager.Add(new Employee(060_000m));
            employeeManager.Add(new EmployeeClassAdapter(1_000_000));

            // Act
            var result = employeeManager.PaySalaries();

            // Assert
            result.Should().Be(1_160_000m);
        }
    }
}
