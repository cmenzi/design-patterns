using ZbW.DesignPatterns.Adapter;
using ZbW.DesignPatterns.Factory;

namespace ZbW.DesignPatterns.Builder
{
    public class Order
    {
        public Pizza Pizza { get; set; }
        public double Price { get; set; }
        public Employee Employee { get; set; }
        public string Buyer { get; set; }
    }
}
