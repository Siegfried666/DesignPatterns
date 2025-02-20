
namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Strategy.GOOD
{
    public class CompressorMP4 : ICompressor
    {
        public void Compress()
        {
             Console.WriteLine("Compressing using MP4");
        } 
    }
}
