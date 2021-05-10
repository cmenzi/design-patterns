namespace ZbW.DesignPatterns.Strategy
{
    public class Sale
    {
        private readonly IPricingStrategy _pricingStrategy;

        public Sale(decimal amount, IPricingStrategy pricingStrategy)
        {
            Amount = amount;

            _pricingStrategy = pricingStrategy;
        }

        public decimal Amount { get; }

        public decimal GetTotal()
        {
            var discount = _pricingStrategy.GetDiscount(this);
            return Amount - discount;
        }
    }
}
