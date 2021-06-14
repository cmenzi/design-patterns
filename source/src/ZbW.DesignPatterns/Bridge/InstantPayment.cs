
namespace ZbW.DesignPatterns.Bridge
{
    public class InstantPayment : Payment
    {
        public override string Pay()
        {
            return $"Sofortbezahlung | {paymentMethod.Pay(amount)}";
        }
    }
}
