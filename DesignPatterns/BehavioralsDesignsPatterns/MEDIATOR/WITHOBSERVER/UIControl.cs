using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.BehavioralsDesignsPatterns.MEDIATOR.WITHOBSERVER.UIFramework;

namespace DesignPatterns.BehavioralsDesignsPatterns.MEDIATOR.WITHOBSERVER
{
    public class UIControl
    {
        private List<UIFramework.EventHandler> _eventHandlers = new List<UIFramework.EventHandler>();

        public void AddEventHandler(UIFramework.EventHandler eventHandler)
        {
            _eventHandlers.Add(eventHandler);
        }

        public void NotifyEventHandlers()
        {
            foreach (var handler in _eventHandlers)
            {
                handler();
            }
        }
    }
}