using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.ChainOfResponsibility
{
    public abstract class Alarm
    {
        protected Alarm _next {  get; set; }

        public Alarm SetNext(Alarm nextAlarm)
        {
            Alarm lastAlarm = this;
            while (lastAlarm._next != null)
            {
                lastAlarm = lastAlarm._next;
            }
            lastAlarm._next = nextAlarm;
            return this;
        }

        public string ToDo(string message)
        {
            if (_next != null)
            {
                return _next.ToDo(message);
            }

            return GetToDo(message + Environment.NewLine);
        }

        protected abstract string GetToDo(string message);
    }
}
