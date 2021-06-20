namespace ZbW.DesignPatterns.Strategy
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Serializable]
    public class NullDiscountStrategy : IPricingStrategy
    {
        public decimal GetDiscount(Sale sale)
        {
            return 0m;
        }
    }

    interface ILogger
    {
        void Debug(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void Debug(string message)
        {
            Console.WriteLine(message);
        }
    }

    class NullLogger : ILogger
    {
        public void Debug(string message)
        {
            // Do nothing
        }
    }

}
