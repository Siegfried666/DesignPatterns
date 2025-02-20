namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.State.GOOD
{
    public class PublishedState : IState
    {
        private Document _document;

        public PublishedState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            // do nothing;
        }
    }
}