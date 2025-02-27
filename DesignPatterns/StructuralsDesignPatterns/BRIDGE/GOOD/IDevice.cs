using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.BRIDGE.GOOD
{
    public interface IDevice
    {
        public void TurnOn();
        public void TurnOff();
        public void SetChannel(int channel);
    }
}