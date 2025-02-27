using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.BRIDGE.GOOD
{
    public class LGRadio : IDevice
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine("Setting LG radio channel to : " + channel);
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off LG radio");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on LG radio");
        }
    }
}