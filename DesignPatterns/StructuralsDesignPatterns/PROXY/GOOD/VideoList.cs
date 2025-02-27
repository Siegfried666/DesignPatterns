
using DesignPatterns.StructuralsDesignPatterns.PROXY.GOOD.Package;

namespace DesignPatterns.StructuralsDesignPatterns.PROXY.GOOD
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