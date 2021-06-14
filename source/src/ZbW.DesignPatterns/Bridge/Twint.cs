
namespace ZbW.DesignPatterns.Bridge
{
    public class Twint : IPaymentMethod
    {
        public string Pay(decimal amount)
        {
            return $"Payed {amount} Fr. with Twint";
        }
    }
}
