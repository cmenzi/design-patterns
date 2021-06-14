using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ZbW.DesignPatterns.Iterator
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(5);
            ObjectIterator iterator = new ObjectIterator(myList);
            while (iterator.hasNext())
            {
                Console.WriteLine(iterator.next());
            }
        }
    }
}
