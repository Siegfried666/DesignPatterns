using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.MEDIATOR.GOOD
{
    public class Button : UIControl
    {

        private bool _isEnabled;

        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool IsEnabled()
        {
            return _isEnabled;
        }

        public void SetEnabled(bool isEnabled)
        {
            _isEnabled = isEnabled;
            _owner.Changed(this);
        }
    }
}