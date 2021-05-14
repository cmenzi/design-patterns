namespace ZbW.DesignPatterns.Composite
{
    using System.Linq;

    using ZbW.DesignPatterns.Strategy;

    public class BestForCustomerPricingStrategy : CompositePricingStrategy
    {
        public override decimal GetDiscount(Sale sale)
        {
            return Children.Max(x => x.GetDiscount(sale));
        }
    }
}
