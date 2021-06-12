using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using ZbW.DesignPatterns.Prototype;

[assembly: InternalsVisibleTo("ZbW.DesignPatterns.Tests")]

namespace ZbW.DesignPatterns.Strategy
{
    [Serializable]
    public class Sale : Prototypes
    {
        internal readonly IPricingStrategy _pricingStrategy;

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
            using (MemoryStream memoryStream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, this);
                memoryStream.Seek(0, SeekOrigin.Begin);
                return (Sale)binaryFormatter.Deserialize(memoryStream);
            }
        }
    }
}
