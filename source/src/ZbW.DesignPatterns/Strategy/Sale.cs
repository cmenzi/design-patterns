using ZbW.DesignPatterns.Prototype;

namespace ZbW.DesignPatterns.Strategy
{
    public class Sale : Prototypes
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

        public override Prototypes ShallowCopy()
        {
            return (Sale) this.MemberwiseClone();
        }

        public override Prototypes DeepCopy()
        {
            // is ShallowCopy() Implemented, then call this.ShallowCopy()
            Sale _sale = (Sale)this.MemberwiseClone(); // --> I dont need this then
            // is Readonly (implement in the Constructor)
            //     --> @Cédric have you a other Implementation Idee for a Interface?
            // _sale._pricingStrategy = this._pricingStrategy;

            return new Sale(_sale.Amount, this._pricingStrategy);
        }
    }
}
