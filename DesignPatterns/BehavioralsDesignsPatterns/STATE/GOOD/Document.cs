namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD
{

    public class Document
    {
        public IState State { get; set; }
        public UserRoles CurrentUserTole { get; set; }

        public Document(UserRoles currentUserRole)
        {
            State = new DraftState(this);
            CurrentUserTole = currentUserRole;
        }
        public void Publish()
        {
            State.Publish();
        }
    }
}