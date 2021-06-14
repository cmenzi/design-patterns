using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Login = new ProxyWaiterAccount("waiter1", "123");
            Login.ExecuteOrder();
        }
    }
}
