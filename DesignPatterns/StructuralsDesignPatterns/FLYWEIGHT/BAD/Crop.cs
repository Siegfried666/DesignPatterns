using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.FLYWEIGHT.BAD
{
    public class Crop
    {
        private int _x;
        private int _y;
        private CropType _cropType;
        private byte[] _icon;


        public Crop(int x, int y, CropType cropType, byte[] icon)
        {
            _x = x;
            _y = y;
            _icon = icon;
            _cropType = cropType;
        }

        public void Render()
        {
            Console.WriteLine($"Drawing {_cropType} at {_x}, {_y}");
        }
    }
}