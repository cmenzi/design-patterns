using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.ChainOfResponsibility
{
    public abstract class Alarm : IAlarm
    {
        private IAlarm _next {  get; set; }

        public virtual string Escalate(string message)
        {
            if (_next != null)
                return _next.Escalate(message);
            else
                return null;
        }

        public IAlarm SetNext(IAlarm nextAlarm)
        {
            _next = nextAlarm;
            return _next;
        }
    }
}
