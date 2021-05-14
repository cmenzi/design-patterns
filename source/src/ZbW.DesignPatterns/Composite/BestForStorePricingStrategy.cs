namespace ZbW.DesignPatterns.Composite
{
    using System.Linq;

    using ZbW.DesignPatterns.Strategy;

    public class BestForStorePricingStrategy : CompositePricingStrategy
    {
        public override decimal GetDiscount(Sale sale)
        {
            return Children.Min(x => x.GetDiscount(sale));
        }
    }
}
