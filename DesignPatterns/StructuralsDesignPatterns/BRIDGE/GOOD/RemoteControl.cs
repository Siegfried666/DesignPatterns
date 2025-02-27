using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.BRIDGE.GOOD
{
    public class RemoteControl
    {
        private IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            _device.TurnOn();
        }

        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}