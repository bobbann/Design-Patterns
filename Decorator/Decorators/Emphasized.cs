using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Emphasized : TextDecorator, IDecoration
    {
        public Emphasized(IDecoration decoration)
        {
            Start = "<em>";
            End = "</em>";
            Decoration = decoration;
        }
    }
}
