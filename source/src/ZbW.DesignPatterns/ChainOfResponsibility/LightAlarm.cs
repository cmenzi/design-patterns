using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.ChainOfResponsibility
{
    public class LightAlarm : Alarm
    {
        protected override string GetToDo(string message)
        {
            return this?._next.ToDo("Lights have done the swirly thing!") ?? message + "Lights have done the swirly thing!";
        }
    }
}
