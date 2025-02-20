namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.State.BAD
{

    public class Document
    {
        public DocumentStates State { get; set; }
        public UserRoles CurrentUserTole { get; set; }

        public void Publish()
        {
            if (State == DocumentStates.Draft)
            {
                State = DocumentStates.Moderation;
            }
            else if (State == DocumentStates.Moderation)
            {
                if (CurrentUserTole == UserRoles.Admin)
                {
                    State = DocumentStates.Published;
                }
            }
            else if (State == DocumentStates.Published)
            {
                // nothing
            }
        }
    }
}