using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.BRIDGE.BAD
{
    public abstract class RadioAndTVRemote : RemoteControl
    {
        public abstract void ControlTV();
        public abstract void ControlRadio();
    }
}