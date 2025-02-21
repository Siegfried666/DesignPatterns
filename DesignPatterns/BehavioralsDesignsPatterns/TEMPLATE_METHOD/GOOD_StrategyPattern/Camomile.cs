using DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD.StrategyPattern;

namespace DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD_StrategyPattern
{
    public class Camomile : IBeverage
    {
        public void Prepare()
        {
            throw new NotImplementedException();
        }

        public void Brew()
        {
            System.Console.WriteLine("Brewing camomile for 3 minutes");
        }
    }
}