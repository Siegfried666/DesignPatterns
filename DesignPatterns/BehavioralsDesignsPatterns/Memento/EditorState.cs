namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Memento
{
    public class EditorState
    {
        public readonly string _title;
        public readonly string _content;


        // State meta data
        private readonly DateTime _stateCreatedAt;

        public EditorState(string title, string content)
        {
            _title = title;
            _content = content;
            _stateCreatedAt = DateTime.Now;
        }

        public string GetTile()
        {
            return _title;
        }

        public DateTime GetDate()
        {
            return _stateCreatedAt;
        }

        public string GetContent()
        {
            return _content;
        }

        public string GetName()
        {
            return $"{_stateCreatedAt} / {_title}";
        }
    }
}