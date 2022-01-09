using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Marked : TextDecorator, IDecoration
    {
        public Marked(IDecoration decoration)
        {
            Start = "<mark>";
            End = "</mark>";
            Decoration = decoration;
        }
    }
}
