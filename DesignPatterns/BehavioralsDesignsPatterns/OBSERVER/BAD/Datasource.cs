using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.OBSERVER.BAD
{
    public class Datasource
    {
        private List<int> _values = new List<int>();

        private List<Object> _dependents = new List<object>();

        public List<int> GetValues()
        {
            return _values;
        }

        public void SetValues(List<int> values)
        {
            _values = values;

            foreach (var dependent in _dependents)
            {
                if (dependent is Sheet2)
                    (dependent as Sheet2).CalculateTotal(_values);
                else if (dependent is BarChart)
                    (dependent as BarChart).Render(_values);
            }
        }

        public void AddDependent(Object dependent)
        {
            _dependents.Add(dependent);
        }

        public void RemoveDependent(Object dependent)
        {
            _dependents.Remove(dependent);
        }
    }
}