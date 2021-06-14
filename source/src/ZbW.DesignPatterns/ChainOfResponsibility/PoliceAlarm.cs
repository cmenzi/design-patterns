using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.ChainOfResponsibility
{
    public class PoliceAlarm : Alarm
    {
        public override string Escalate(string message)
        {
            if (message == "HandsUp")
                return "Tü ta tü ta... Police! Open the Door!";
            else
                return base.Escalate(message);
        }
    }
}
