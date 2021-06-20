
namespace ZbW.DesignPatterns.Flyweight
{
    public class Twint : IPaymentMethod
    {
        public string Pay(decimal amount)
        {
            return $"Payed {amount} Fr. with Twint";
        }
    }
}
