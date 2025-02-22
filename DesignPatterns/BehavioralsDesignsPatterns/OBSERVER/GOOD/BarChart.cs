using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.OBSERVER.GOOD
{
    public class BarChart : IObserver
    {

        private Datasource _datasource;

        public BarChart(Datasource datasource)
        {
            _datasource = datasource;
        }
        public void Update()
        {
            System.Console.WriteLine("Rendering bar chart with new values");
        }
    }
}