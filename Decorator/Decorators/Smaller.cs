using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Smaller : TextDecorator, IDecoration
    {
        public Smaller(IDecoration decoration)
        {
            Start = "<small>";
            End = "</small>";
            Decoration = decoration;
        }
    }
}
