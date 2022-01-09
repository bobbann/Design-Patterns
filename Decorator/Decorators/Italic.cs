using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Italic : TextDecorator, IDecoration
    {
        public Italic(IDecoration decoration)
        {
            Start = "<i>";
            End = "</i>";
            Decoration = decoration;
        }
    }
}
