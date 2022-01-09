using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Assignment.Decorator;

namespace Design_Patterns_Assignment.Decorator
{
    class Bold : TextDecorator, IDecoration
    {
        public Bold(IDecoration decoration)
        {
            Start = "<b>";
            End = "</b>";
            Decoration = decoration;
        }
    }
}
