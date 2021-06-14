using System;

namespace ZbW.DesignPatterns.Facade
{
    public class PrinterSubSystem
    {
        internal bool PrintReceip(string orderText, double orderPrice)
        {
            Console.WriteLine($"Bestellung: {orderText} \r\nTotalpreis: {orderPrice}.-");
            return true;
        }
    }
}