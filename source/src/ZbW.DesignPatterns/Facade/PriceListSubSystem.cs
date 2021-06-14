using System;

namespace ZbW.DesignPatterns.Facade
{
    public class PriceListSubSystem
    {
        internal double GetPriceForPizza(string name)
        {
            var price = 0.0;
            switch (name)
            {
                case "Funghi":
                    price = 15.50;
                    break;
                case "Salami":
                    price = 18.50;
                    break;
                case "Tonno":
                    price = 17.50;
                    break;

            }

            return price;
        }
    }
}