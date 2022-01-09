using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Important : TextDecorator, IDecoration
    {
        public Important(IDecoration decoration)
        {
            Start = "<strong>";
            End = "</strong>";
            Decoration = decoration;
        }
    }
}
