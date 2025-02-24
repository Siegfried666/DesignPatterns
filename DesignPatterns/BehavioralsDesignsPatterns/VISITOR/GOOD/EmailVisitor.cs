using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DesignPatterns.BehavioralsDesignsPatterns.VISITOR.GOOD.Client;

namespace DesignPatterns.BehavioralsDesignsPatterns.VISITOR.GOOD
{
    public class EmailVisitor : IVisitor
    {
        public void VisitLaw(LawClient lawClient)
        {
            System.Console.WriteLine("Sending law marketing tips email to " + lawClient.GetEmail());
        }

        public void VisitRestaurant(RestaurantClient restaurantClient)
        {
            System.Console.WriteLine("Sending restaurant marketing tips email to " + restaurantClient.GetEmail());
        }

        public void VisitRetail(RetailClient retailClient)
        {
            System.Console.WriteLine("Sending retail marketing tips email to " + retailClient.GetEmail());
        }
    }
}