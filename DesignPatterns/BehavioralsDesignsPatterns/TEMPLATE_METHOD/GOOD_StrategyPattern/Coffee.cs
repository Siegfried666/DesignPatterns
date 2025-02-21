using DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD.StrategyPattern;

namespace DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD_StrategyPattern
{
    public class Coffee : IBeverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        public void Brew()
        {
            System.Console.WriteLine("Brewing coffee for 5 minutes");
        }

        private void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                System.Console.WriteLine("Add cream to the coffee");
            }
        }

        private bool CustomerWantsCondiments()
        {
            System.Console.WriteLine("Would you like cream with your coffee (y/n)");
            string input = Console.ReadLine();
            return input.Equals("y", StringComparison.CurrentCultureIgnoreCase);
        }
    }
}