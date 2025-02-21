namespace DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD_TemplateMethodPattern
{
    public class Camomile : Beverage
    {
        protected override void Brew()
        {
            System.Console.WriteLine("Brew camomile for 3 minutes");
        }
    }
}