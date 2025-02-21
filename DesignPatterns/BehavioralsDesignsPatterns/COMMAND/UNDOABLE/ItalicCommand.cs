using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.COMMAND.UNDOABLE
{
    public class ItalicCommand : IUndoableCommand
    {
        private HtmlDocument _doc;
        private string _previousContent = "";
        private History _history;

        public ItalicCommand(HtmlDocument doc, History history)
        {
            _doc = doc;
            _history = history;
        }

        public void Execute()
        {
            _previousContent = _doc.Content;
            _doc.MakeItalic(); // delegating the work to the doc business object
            _history.Push(this);
        }

        public void Unexecute()
        {
            _doc.Content = _previousContent;
        }
    }
}