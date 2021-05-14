namespace ZbW.DesignPatterns.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Xunit;

    using ZbW.DesignPatterns.Factory;

    public class FactoryTests
    {
        [Fact]
        public void Reflection_Factory_Demo()
        {
            var princingStrategyFactory = new PrincingStrategyFactory();
            var strategy = princingStrategyFactory.Create("DoubleDiscountAfterLunch", new TimeSource(), 10m);
            var sale = new DesignPatterns.Strategy.Sale(100, strategy);

            sale.GetTotal();
        }
    }
}
