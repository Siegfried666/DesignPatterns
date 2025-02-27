using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.ADAPTER.GOOD
{
    public class BackAndWhiteColor : IColor
    {
        public void Apply(Video video)
        {
            Console.WriteLine("Applying black and white color to video");
        }
    }
}