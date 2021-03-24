using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Elements;

namespace Visitor.Visitors
{
    public interface IVisitor
    {
        void Visit(Ramp ramp); 
        void Visit(Target target); 
        void Visit(Led led);
    }
}
