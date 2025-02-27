using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.StructuralsDesignPatterns.ADAPTER.BAD;
using DesignPatterns.StructuralsDesignPatterns.PROXY.BAD.Package;

namespace DesignPatterns.StructuralsDesignPatterns.PROXY.BAD
{
    public class VideoList
    {
        private Dictionary<string, IVideo> _videoList = new Dictionary<string, IVideo>();

        public void Add(IVideo video)
        {
            _videoList.Add(video.GetVideoId(), video);
        }

        public void Watch(string videoId)
        {
            var video = _videoList[videoId];
            video.Render();
        }
    }
}