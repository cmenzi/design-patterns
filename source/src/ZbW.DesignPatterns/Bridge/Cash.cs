
namespace ZbW.DesignPatterns.Bridge
{
    public class Cash : IPaymentMethod
    {
        public string Pay(decimal amount)
        {
            return $"Payed {amount} Fr. with cash";
        }
    }
}
