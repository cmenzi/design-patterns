using System.Data.SqlTypes;

namespace ZbW.DesignPatterns.Strategy
{
    public class PercentagePricingStrategy : IPricingStrategy
    {
        private readonly decimal _percentage;

        public PercentagePricingStrategy(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal GetDiscount(Sale sale)
        {
            return sale.Amount * _percentage / 100;
        }
    }
}
