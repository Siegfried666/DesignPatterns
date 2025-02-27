using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralsDesignPatterns.PROXY.GOOD.Package
{
    public class YoutubeVideo : IVideo
    {
        private string _videoId;

        public YoutubeVideo(string videoId)
        {
            _videoId = videoId;
            Download();
        }

        private void Download()
        {
            System.Console.WriteLine("Downloading video with id " + _videoId + " from Youtube API");
        }
        public string GetVideoId()
        {
            return _videoId;
        }

        public void Render()
        {
            System.Console.WriteLine("Rendering video " + _videoId);
        }
    }
}