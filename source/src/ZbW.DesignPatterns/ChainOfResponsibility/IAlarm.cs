using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.ChainOfResponsibility
{
    public interface IAlarm
    {
        IAlarm SetNext(IAlarm next);
        string Escalate(string message);
    }
}
