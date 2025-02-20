namespace DESIGNPATTERNS.BehavioralsDesignsPatterns.Iterator.BAD
{

    public class ShoppingList
    {
        private List<string> _list = new List<string>();
        //private string[] _list = new string[50]; // On change la structure d'un élement de l'objet ici, dans le client Count n'existe pas pour ce type

        public void Push(string itemName)
        {
            _list.Add(itemName);
        }

        public string Pop()
        {
            var last = _list.Last();
            _list.Remove(last);
            return last;
        }

        public List<string> GetList()
        {
            return _list;
        }
    }
}