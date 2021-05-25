using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.ChainOfResponsibility
{
    public class PoliceAlarm : Alarm
    {
        protected override string GetToDo(string message)
        {
            return _next?.ToDo("Tü ta tü ta... Police! Open the Door!") ?? message + "Tü ta tü ta... Police! Open the Door!";
        }
    }
}
