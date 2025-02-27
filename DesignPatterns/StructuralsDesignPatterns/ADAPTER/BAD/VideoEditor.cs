using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.ADAPTER.BAD
{
    public class VideoEditor
    {
        private Video _video;

        public VideoEditor(Video video)
        {
            _video = video;
        }

        public void ApplyColor(IColor color)
        {
            color.Apply(_video);
        }
    }
}