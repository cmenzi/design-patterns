using System;

using ZbW.DesignPatterns.Strategy;

namespace ZbW.DesignPatterns.Tests
{
    internal class TimeSource : ITimeSource
    {
        public TimeSource()
        {
        }

        public DateTime Now => DateTime.Now;
    }
}