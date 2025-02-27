using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.ADAPTER.GOOD
{
    public class RainbowColor : IColor
    {
        private Rainbow _rainbow;

        public RainbowColor(Rainbow rainbow)
        {
            _rainbow = rainbow;
        }

        public void Apply(Video video)
        {
            _rainbow.Setup();
            _rainbow.Update(video);
        }
    }
}