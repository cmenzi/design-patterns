namespace ZbW.DesignPatterns.Decorator
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using ZbW.DesignPatterns.Strategy;

    public class LoggingPricingStrategyDecorator : IPricingStrategy
    {
        private readonly IPricingStrategy _strategy;

        public LoggingPricingStrategyDecorator(IPricingStrategy pricingStrategy)
        {
            _strategy = pricingStrategy;
        }

        public decimal GetDiscount(Sale sale)
        {
            var swatch = Stopwatch.StartNew();
            
            var result = _strategy.GetDiscount(sale);
            
            swatch.Stop();

            Trace.WriteLine($"Time used:'{swatch.ElapsedMilliseconds} ms'");

            return result;
        }
    }
}
