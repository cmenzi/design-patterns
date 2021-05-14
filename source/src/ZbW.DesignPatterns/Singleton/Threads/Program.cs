using System;
using System.Collections.Generic;
using System.Text;

using ZbW.DesignPatterns.Singleton.Threads;

namespace ZbW.DesignPatterns.Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintSpooler.GetInstance().Start();
            
            using var numberPrinter = new NumberPrinter();
            using var textPrinter = new TextPrinter();
            
            Console.ReadLine();
            PrintSpooler.GetInstance().Stop();
            Console.ReadLine();
        }
    }
}
