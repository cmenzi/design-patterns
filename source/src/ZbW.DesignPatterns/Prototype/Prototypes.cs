using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Prototype
{
    public abstract class Prototypes
    {
        public abstract Prototypes ShallowCopy();
        public abstract Prototypes DeepCopy();
    }
}
