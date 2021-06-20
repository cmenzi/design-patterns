using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Facade
{
    public class SalesSystemFacade
    {
        protected PizzaStoreSubSystem _pizzaStoreSubSystem;
        protected PriceListSubSystem _priceListSubSystem;
        protected PrinterSubSystem _printerSubSystem;
        public SalesSystemFacade(PizzaStoreSubSystem pizzaStoreSubSystem, PriceListSubSystem priceListSubSystem, PrinterSubSystem printerSubSystem)
        {
            _pizzaStoreSubSystem = pizzaStoreSubSystem;
            _priceListSubSystem = priceListSubSystem;
            _printerSubSystem = printerSubSystem;
        }

        public bool BuyPizza(string[] pizzas)
        {
            Console.WriteLine("Facade führt Funktionalität der Subsysteme aus...");

            var orderText = _pizzaStoreSubSystem.Order(pizzas);
            var orderPrice = 0.0;

            foreach(string name in pizzas)
            {
                orderPrice += _priceListSubSystem.GetPriceForPizza(name);
            }
            

            return _printerSubSystem.PrintReceip(orderText, orderPrice);
        }

    }
}
