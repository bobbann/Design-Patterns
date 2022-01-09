using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class SubScript : TextDecorator, IDecoration
    {
        public SubScript(IDecoration decoration)
        {
            Start = "<sub>";
            End = "</sub>";
            Decoration = decoration;
        }
    }
}
