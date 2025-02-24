
namespace DesignPatterns.BehavioralsDesignsPatterns.VISITOR.GOOD
{
    public abstract partial class Client
    {
        public interface IVisitor
        {
            void VisitRetail(RetailClient retailClient);

            void VisitLaw(LawClient lawClient);

            void VisitRestaurant(RestaurantClient restaurantClient);
        }
    }
}
