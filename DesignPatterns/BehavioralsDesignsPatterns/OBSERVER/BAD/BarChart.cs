using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.OBSERVER.BAD
{
    public class BarChart
    {
        public void Render(List<int> values)
        {
            System.Console.WriteLine("Rendering bar chart with new values");
        }
    }
}