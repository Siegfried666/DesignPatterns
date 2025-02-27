using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.COMPOSITE.GOOD
{
    public class Mouse : IItem
    {
        private float _price = 18.00f;

        public float GetPrice()
        {
            return _price;
        }
    }
}