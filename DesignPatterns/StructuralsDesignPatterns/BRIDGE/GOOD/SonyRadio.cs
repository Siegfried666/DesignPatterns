using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.BRIDGE.GOOD
{
    public class SonyRadio : IDevice
    {

        public void SetChannel(int channel)
        {
            Console.WriteLine("Setting Sony radio channel to : " + channel);
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off Sony radio");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on Sony radio");
        }
    }
}