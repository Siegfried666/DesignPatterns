using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.MEDIATOR.GOOD
{
    public class ListBox : UIControl
    {

        private string _selection = "";


        public ListBox(DialogBox owner) : base(owner)
        {
        }

        public string GetSelection()
        {
            return _selection;
        }

        public void SetSelection(string selection)
        {
            _selection = selection;
            _owner.Changed(this);
        }
    }
}