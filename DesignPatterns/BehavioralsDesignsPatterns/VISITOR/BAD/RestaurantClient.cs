using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.VISITOR.BAD
{
    public class RestaurantClient : Client
    {
        public RestaurantClient(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            System.Console.WriteLine("Sending restaurant marketing tips email to " + _email);
        }
    }
}