using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.TEMPLATE_METHOD.BAD
{
    public class Tea
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