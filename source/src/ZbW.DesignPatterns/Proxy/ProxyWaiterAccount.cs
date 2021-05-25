using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Proxy
{
    public class ProxyWaiterAccount : IOrder
    {
        private WaiterAccount _waiterAccount;

        public ProxyWaiterAccount(WaiterAccount waiterAccount)
        {
            this._waiterAccount.ExecuteOrder();
        }

        public void ExecuteOrder()
        {
            throw new NotImplementedException();
        }

        public bool CheckAccess()
        {
            // Some real checks should go here.
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}