using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    abstract class TextDecorator
    {
        public string Start { get; set; }
        public string End { get; set; }
        public IDecoration Decoration { get; set; }

        public string Content()
        {
            return Start + Decoration.Content() + End;
        }
    }
}
