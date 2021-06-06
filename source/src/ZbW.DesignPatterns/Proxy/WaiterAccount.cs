using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZbW.DesignPatterns.Factory;

namespace ZbW.DesignPatterns.Proxy
{
    public class WaiterAccount : IOrder
    {
        public string User { get; set; }
        public string Password { get; set; }

        public WaiterAccount(string user, string pw)
        {
            User = user;
            Password = pw;
        }

        public void ExecuteOrder()
        {
            Console.WriteLine("Ordering Pizza...");
        }
    }
}