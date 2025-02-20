namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD
{
    public class ModerationState : IState
    {
        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
           if(_document.CurrentUserTole == UserRoles.Admin){
            _document.State = new PublishedState(_document);
           }
        }
    }
}