namespace DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD_TemplateMethodPattern
{
    public class Tea : Beverage
    {
        public Tea()
        {
            AddCondiments();
        }
        
        protected override void Brew()
        {
            System.Console.WriteLine("Brewing during 3 minutes");
        }

        protected override void AddCondiments()
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