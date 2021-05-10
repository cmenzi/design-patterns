namespace ZbW.DesignPatterns.Strategy
{
    public interface IPricingStrategy
    {
        decimal GetDiscount(Sale sale);
    }
}
