using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.BAD
{
    // BAD: On voit ici que le code est quasiment le même que pour la classe Tea
    public class Coffee
    {
        public void MakeBeverage()
        {
            BoilWater();
            PourWaterIntoCup();
            Brew();
            AddCondiments();
        }

        public void BoilWater()
        {
            System.Console.WriteLine("Boiling water");
        }

        public void PourWaterIntoCup()
        {
            System.Console.WriteLine("pouring water into cup");
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