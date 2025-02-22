using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.MEDIATOR
{
    public abstract class DialogBox
    {
        public abstract void Changed(UIControl uIControl);
    }
}