using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.BRIDGE.BAD
{
    public class LGRemote : RemoteControl
    {
        public override void TurnOff()
        {
            Console.WriteLine("Turing off LG radio");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Turing on LG radio");
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