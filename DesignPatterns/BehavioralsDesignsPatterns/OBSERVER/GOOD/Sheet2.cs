using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.OBSERVER.GOOD
{
    public class Sheet2 : IObserver
    {
        private Datasource _datasource;

        public Sheet2(Datasource datasource)
        {
            _datasource = datasource;
        }

        private int _total;
        public int GetTotal()
        {
            return _total;
        }

        public void Update()
        {
            _total = CalculateTotal(_datasource.GetValues());
        }

        public int CalculateTotal(List<int> values)
        {
            var sum = 0;

            foreach (var value in values)
                sum += value;

            System.Console.WriteLine("Total: " + sum);

            return sum;
        }
    }
}