using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.ChainOfResponsibility
{
    public class Intruder
    {        
        public static string IntruderDetected(Alarm alarm)
        {
            var _securitySteps = new List<string> { "LightsOn", "HandsUp"};

            var _whatToDo = "Intruders detected" + Environment.NewLine;

            foreach (var step in _securitySteps)
            {
                var result = alarm.Escalate(step);

                if (result != null)
                {
                    _whatToDo += result + Environment.NewLine;
                }
                else
                {
                    _whatToDo += "unknown Step" + Environment.NewLine;
                }
            }

            return _whatToDo;
        }
    }
}
