using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.ADAPTER.BAD
{
    public class MidnightColor : IColor
    {
        public void Apply(Video video)
        {
            Console.WriteLine("Applying midnight-purple color to video");
        }
    }
}