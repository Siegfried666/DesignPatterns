using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.ADAPTER.BAD
{
    public class Rainbow
    {
         public void Update(Video video)
        {
            Console.WriteLine("Applying rainbow color to video");
        }
    }
}