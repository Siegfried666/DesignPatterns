using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.COMMAND.UNDOABLE
{
    public interface IUndoableCommand: ICommand
    {
        void Unexecute();
    }
}