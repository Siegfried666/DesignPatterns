using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.FLYWEIGHT.GOOD
{
    public class CropIconFactory
    {
        // cache
        private Dictionary<CropType, CropIcon> _icons = new Dictionary<CropType, CropIcon>();

        public CropIcon GetCropIcon(CropType type)
        {
            if (!_icons.ContainsKey(type))
            {
                var icon = new CropIcon(type, null);
                _icons.Add(type, icon);
            }
            return _icons[type];
        }
    }
}