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

        public ProxyWaiterAccount(string user, string password)
        {
            var acc = new WaiterAccount(user, password);
        }

        public void ExecuteOrder()
        {
            if (this.CheckAccess())
            {
                this._waiterAccount.ExecuteOrder();
                this.LogAccess();
            }
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