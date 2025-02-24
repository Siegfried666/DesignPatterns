using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DesignPatterns.BehavioralsDesignsPatterns.VISITOR.GOOD.Client;

namespace DesignPatterns.BehavioralsDesignsPatterns.VISITOR.GOOD
{
    public class PDFExportVisitor : IVisitor
    {
        public void VisitLaw(LawClient lawClient)
        {
            System.Console.WriteLine("Exporting law client as PDF");
        }

        public void VisitRestaurant(RestaurantClient restaurantClient)
        {
            System.Console.WriteLine("Exporting restaurant client as PDF");
        }

        public void VisitRetail(RetailClient retailClient)
        {
            System.Console.WriteLine("Exporting retail client as PDF");
        }
    }
}