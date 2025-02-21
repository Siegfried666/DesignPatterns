using DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD.StrategyPattern;

namespace DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD_StrategyPattern
{
    public class Tea : IBeverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }
        
        public void Brew()
        {
            System.Console.WriteLine("Brewing tea for 3 minutes");
        }

        private void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                System.Console.WriteLine("Add lemon to the tea");
            }
        }

        private bool CustomerWantsCondiments()
        {
            System.Console.WriteLine("Would you like lemon with your tea (y/n)");
            string input = Console.ReadLine();
            return input.Equals("y", StringComparison.CurrentCultureIgnoreCase);
        }
    }
}