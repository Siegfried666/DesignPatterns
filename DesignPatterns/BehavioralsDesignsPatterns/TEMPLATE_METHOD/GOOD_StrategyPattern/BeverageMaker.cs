using DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD.StrategyPattern;

namespace DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.GOOD_StrategyPattern
{
    public class BeverageMaker
    {
        private IBeverage _beverage;

        public BeverageMaker(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public void MakeBeverage()
        {
            BoilWater();
            PourIntoCup();

            _beverage.Prepare();
        }

        public void SetBeverage(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public void BoilWater()
        {
            System.Console.WriteLine("Boiling water");
        }

        private void PourIntoCup()
        {
            System.Console.WriteLine("Pouring boiled water into cup");
        }
    }
}