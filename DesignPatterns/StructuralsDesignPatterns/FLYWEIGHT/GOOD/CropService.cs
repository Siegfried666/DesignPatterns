using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.FLYWEIGHT.GOOD
{
    public class CropService
    {
        private CropIconFactory _iconFactory;

        public CropService(CropIconFactory iconFactory)
        {
            _iconFactory = iconFactory;
        }

        public List<Crop> GetCrops()
        {
            List<Crop> crops = new List<Crop>();

            // fetching from db
            var carrot = new Crop(1, 4, _iconFactory.GetCropIcon(CropType.Carrot));
            var carrot2 = new Crop(1, 5, _iconFactory.GetCropIcon(CropType.Carrot));
            var carrot3 = new Crop(1, 6, _iconFactory.GetCropIcon(CropType.Carrot));

            crops.Add(carrot);
            crops.Add(carrot2);
            crops.Add(carrot3);

            return crops;
        }
    }
}