using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.BRIDGE.BAD
{
    public class AdvancedLGRemote : AdvancedRemote
    {
        public override void SetChannel(int channel)
        {
            Console.WriteLine("Setting channel to : " + channel);
        }

        public override void TurnOff()
        {
            Console.WriteLine("Turning off LG radio");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Turning on LG radio");
        }

        public override void VolumeDown()
        {
            Console.WriteLine("Turing LG radio volume down");
        }

        public override void VolumeUp()
        {
            Console.WriteLine("Turing LG radio volume up");
        }
    }
}