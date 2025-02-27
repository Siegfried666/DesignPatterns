using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.COMPOSITE.GOOD
{
    public class Microphone : IItem
    {
        private float _price = 29.99f;

        public float GetPrice()
        {
            return _price;
        }
    }
}