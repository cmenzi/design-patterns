
namespace ZbW.DesignPatterns.Bridge
{
    public abstract class Payment
    {
        public IPaymentMethod paymentMethod;
        public decimal amount;

        public abstract string Pay();
    }
}
