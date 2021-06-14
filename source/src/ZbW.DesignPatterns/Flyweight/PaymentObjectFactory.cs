
using System.Collections.Generic;

namespace ZbW.DesignPatterns.Flyweight
{
    public class PaymentObjectFactory
    {
        Dictionary<string, IPaymentMethod> paymentMethods = new Dictionary<string, IPaymentMethod>();

        public int TotalObjectsCreated
        {
            get { return paymentMethods.Count; }
        }

        public IPaymentMethod GetPaymentMethod(string PaymentName)
        {
            IPaymentMethod paymentMethod = null;
            if (paymentMethods.ContainsKey(PaymentName))
            {
                paymentMethod = paymentMethods[PaymentName];
            }
            else
            {
                switch (PaymentName)
                {
                    case "Twint":
                        paymentMethod = new Twint();
                        paymentMethods.Add("Twint", paymentMethod);
                        break;
                    case "CreditCard":
                        paymentMethod = new CreditCard();
                        paymentMethods.Add("CreditCard", paymentMethod);
                        break;
                    default:
                        throw new System.Exception("Factory cannot create the object specified");
                }
            }
            return paymentMethod;
        }

    }
}
