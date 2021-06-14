using System;
using System.Configuration;
using System.Reflection;

namespace ZbW.DesignPatterns.Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {

            PizzaStoreSubSystem pizzaStoreSubSystem = new PizzaStoreSubSystem();
            PriceListSubSystem priceListSubSystem = new PriceListSubSystem();
            PrinterSubSystem printerSubSystem = new PrinterSubSystem();

            SalesSystemFacade salesSystemFacade = new SalesSystemFacade(pizzaStoreSubSystem, priceListSubSystem, printerSubSystem);

            var clientCode = new ClientCode();
            clientCode.Run(salesSystemFacade);
            Console.ReadLine();
        }
    }
}
