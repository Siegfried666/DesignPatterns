using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.StructuralsDesignPatterns.PROXY.GOOD.Package;

namespace DesignPatterns.StructuralsDesignPatterns.PROXY.GOOD
{
    public class YoutubeVideoProxy : IVideo
    {
        private string _videoId;
        private YoutubeVideo _youtubeVideo;

        public YoutubeVideoProxy(string videoId)
        {
            _videoId = videoId;
        }

        public string GetVideoId()
        {
            return _videoId;
        }

        public void Render()
        {
            // Lazy Loading
            if (_youtubeVideo == null)
            {
                _youtubeVideo = new YoutubeVideo(_videoId);
            }

            _youtubeVideo.Render();
        }
    }
}