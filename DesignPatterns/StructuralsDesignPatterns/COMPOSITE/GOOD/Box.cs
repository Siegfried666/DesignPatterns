using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.COMPOSITE.GOOD
{
    public class Box : IItem
    {
        private List<IItem> _items = new List<IItem>();

        public void Add(IItem item)
        {
            _items.Add(item);
        }

        public float GetPrice()
        {
            float total = 0f;

            foreach (var item in _items)
            {
                total += item.GetPrice();
            }

            return total;
        }
    }
}