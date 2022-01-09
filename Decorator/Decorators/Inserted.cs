using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Inserted : TextDecorator, IDecoration
    {
        public Inserted(IDecoration decoration)
        {
            Start = "<ins>";
            End = "</ins>";
            Decoration = decoration;
        }
    }
}
