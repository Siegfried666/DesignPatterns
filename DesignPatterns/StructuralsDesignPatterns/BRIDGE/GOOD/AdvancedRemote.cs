using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.BRIDGE.GOOD
{
    public class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(IDevice device) : base(device)
        {

        }

        public void SetChannel(int channel)
        {
            Console.WriteLine("Setting channel to " + channel);
        }
    }
}