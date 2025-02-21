using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.COMMAND.UNDOABLE
{
    public class HtmlDocument
    {
        public string Content { get; set; }
        public void MakeItalic()
        {
            Content = "<i>" + Content + "</i>";
        }
    }
}