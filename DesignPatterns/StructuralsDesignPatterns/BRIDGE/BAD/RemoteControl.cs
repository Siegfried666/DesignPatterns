using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.BRIDGE.BAD
{
    public abstract class RemoteControl
    {
        public abstract void TurnOn();

        public abstract void TurnOff();

        public abstract void VolumeUp();

        public abstract void VolumeDown();
    }
}