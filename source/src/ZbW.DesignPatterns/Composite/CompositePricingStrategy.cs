namespace ZbW.DesignPatterns.Composite
{
    using System;
    using System.Collections.Generic;
    using System.Reflection.PortableExecutable;
    using System.Text;
    using System.Threading.Tasks;

    using ZbW.DesignPatterns.Strategy;

    public abstract class CompositePricingStrategy : IPricingStrategy
    {
        private readonly List<IPricingStrategy> _children;

        protected CompositePricingStrategy()
        {
            _children = new List<IPricingStrategy>();
        }

        public void Add(IPricingStrategy strategy)
        {
            _children.Add(strategy);
        }

        protected IReadOnlyCollection<IPricingStrategy> Children => _children;

        public abstract decimal GetDiscount(Sale sale);
    }
}
