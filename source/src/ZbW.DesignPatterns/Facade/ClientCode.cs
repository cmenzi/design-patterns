using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Facade
{
    public class ClientCode
    {
        public void Run(SalesSystemFacade facade)
        {
            string[] pizzas = new string[3];
            pizzas[0] = "Funghi";
            pizzas[1] = "Salami";
            pizzas[2] = "Tonno";

            Console.WriteLine("Client gibt Bestellung in System ein...");
            facade.BuyPizza(pizzas);
        }
    }
}
