using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.MEDIATOR.GOOD
{
    public class UIControl
    {
        protected DialogBox _owner;

        public UIControl(DialogBox owner)
        {
            _owner = owner;
        }
    }

}