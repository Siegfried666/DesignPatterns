namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Strategy.GOOD
{
    public class OverlayBlur : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying Blur overlay");
        }
    }
}
