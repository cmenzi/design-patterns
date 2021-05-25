using System;
using FluentAssertions;
using ZbW.DesignPatterns.Interpreter;

namespace ZbW.DesignPatterns.InterpreterTests
{
    using Xunit;
    using ZbW.DesignPatterns.Factory;

    public class InterpreterTests
    {
        [Fact]
        public void Evaluate_Year_2020()
        {
            // Arrange
            Context context = new Context(new DateTime(2020, 12, 31));
            context.expression = "YYYY";
            AbstractExpression expression = new YearExpression();

            // Act
            expression.Evaluate(context);

            // Assert
            context.expression.Should().Be("2020");
        }

        [Fact]
        public void Evaluate_Month_12()
        {
            // Arrange
            Context context = new Context(new DateTime(2020, 12, 31));
            context.expression = "MM";
            AbstractExpression expression = new MonthExpression();

            // Act
            expression.Evaluate(context);

            // Assert
            context.expression.Should().Be("12");
        }

        [Fact]
        public void Evaluate_Day_31()
        {
            // Arrange
            Context context = new Context(new DateTime(2020, 12, 31));
            context.expression = "DD";
            AbstractExpression expression = new DayExpression();

            // Act
            expression.Evaluate(context);

            // Assert
            context.expression.Should().Be("31");
        }

        [Fact]
        public void Evaluate_Year_Month_Day_2020_12_31()
        {
            Context context = new Context(new DateTime(2020, 12, 31));
            AbstractExpression expression;


            context.expression = "YYYY";
            expression = new YearExpression();
            expression.Evaluate(context);

            context.expression = "MM";
            expression = new MonthExpression();
            expression.Evaluate(context);

            context.expression = "DD";
            expression = new DayExpression();
            expression.Evaluate(context);

            context.expression.Should().Be("20201231");
        }
    }
}
