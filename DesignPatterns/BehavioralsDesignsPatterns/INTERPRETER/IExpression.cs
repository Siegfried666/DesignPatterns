using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralsDesignsPatterns.INTERPRETER
{
    public interface IExpression
    {
        int Interpret(Context context);
    }
}