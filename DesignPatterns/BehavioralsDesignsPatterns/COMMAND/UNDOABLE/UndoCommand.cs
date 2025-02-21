using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.COMMAND.UNDOABLE
{
    public class UndoCommand : ICommand
    {
        History _history;

        public UndoCommand(History history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.Size() > 0)
            {
                var lastCommand = _history.Pop();
                lastCommand.Unexecute();
            }
        }
    }
}