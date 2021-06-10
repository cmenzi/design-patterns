using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZbW.DesignPatterns.Adapter;
using ZbW.DesignPatterns.Factory;

namespace ZbW.DesignPatterns.Builder
{
    public class OrderBuilder
    {
        private Order _order = new Order();

        public OrderBuilder SetPizza(Pizza pizza)
        {
            _order.Pizza = pizza;
            return this;
        }
        public OrderBuilder SetPrice(double price)
        {
            _order.Price = price;
            return this;
        }

        public OrderBuilder SetEmployee(Employee employee)
        {
            _order.Employee = employee;
            return this;
        }
        public OrderBuilder SetBuyer(string buyer)
        {
            _order.Buyer = buyer;
            return this;
        }

        public Order Build() => _order;
    }
}
