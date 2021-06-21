using System;

namespace ZbW.DesignPatterns.Strategy
{
    [Serializable]
    public class AbsoluteDiscountOverThresholdStrategy : IPricingStrategy
    {
        private readonly decimal _threshold;
        private readonly decimal _absoluteDiscount;

        public AbsoluteDiscountOverThresholdStrategy(decimal threshold, decimal absoluteDiscount)
        {
            _threshold = threshold;
            _absoluteDiscount = absoluteDiscount;
        }

        public decimal GetDiscount(Sale sale)
        {
            if (sale.Amount >= _threshold)
            {
                return _absoluteDiscount;
            }

            return 0m;
        }
    }
}
