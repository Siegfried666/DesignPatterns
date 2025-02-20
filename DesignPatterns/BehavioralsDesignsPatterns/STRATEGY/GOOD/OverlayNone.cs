namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Strategy.GOOD
{
    public class OverlayNone : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying None overlay");
        }
    }
}
