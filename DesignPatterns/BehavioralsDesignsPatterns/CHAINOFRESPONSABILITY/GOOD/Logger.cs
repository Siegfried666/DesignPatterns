using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.CHAINOFRESPONSABILITY.GOOD
{
    public class Logger : Handler
    {
        public override bool DoHandle(HttpRequest request)
        {

            System.Console.WriteLine("Logging");

            return false;
        }
    }
}