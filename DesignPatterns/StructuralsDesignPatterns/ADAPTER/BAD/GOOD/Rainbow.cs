using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.ADAPTER.GOOD
{
    public class Rainbow
    {
        public void Setup()
        {
            System.Console.WriteLine("Setup oject rainbow");
        }
        public void Update(Video video)
        {
            Console.WriteLine("Applying rainbow color to video");
        }
    }
}