namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Strategy.GOOD
{
    public class OverlayBlackAndWhite : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying BlackAndWhite overlay");
        }
    }
}
