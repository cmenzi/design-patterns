using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.ChainOfResponsibility
{
    public class LightAlarm : Alarm
    {
        public override string Escalate(string message)
        {
            if(message == "LightsOn")
                return "Lights have done the swirly thing!";
            else
                return base.Escalate(message);
        }
    }
}
