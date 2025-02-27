using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.BRIDGE.BAD
{
    public abstract class AdvancedRemote : RemoteControl
    {
        public abstract void SetChannel(int channel);
    }
}