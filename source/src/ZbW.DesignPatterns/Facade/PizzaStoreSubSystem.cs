using System;

namespace ZbW.DesignPatterns.Facade
{
    public class PizzaStoreSubSystem
    {
        internal string Order(string[] pizzas)
        {
            string orderText = string.Empty;
            foreach(var pizza in pizzas)
            {
                orderText += pizza + ",";
            }

            return orderText;
        }
    }
}