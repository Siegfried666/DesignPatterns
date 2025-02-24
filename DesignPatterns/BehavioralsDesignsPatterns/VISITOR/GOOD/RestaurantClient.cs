
namespace DesignPatterns.BehavioralsDesignsPatterns.VISITOR.GOOD
{
    public class RestaurantClient: Client
    {
        public RestaurantClient(string name, string email) : base(name, email)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitRestaurant(this);
        }
    }
}
