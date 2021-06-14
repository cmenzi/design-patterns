
namespace ZbW.DesignPatterns.Bridge
{
    public class BilledPayment : Payment
    {
        public override string Pay()
        {
            return $"Bezahlung auf Rechnung | {paymentMethod.Pay(amount)}";
        }
    }
}
