using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Elements;

namespace Visitor.Visitors
{
    public class ResetVisitor : IVisitor
    {
        public void Visit(Ramp ramp)
        {
            ramp.Reset();
        }

        public void Visit(Target target)
        {
            target.Reset();
        }

        public void Visit(Led led)
        {
            led.Reset();
        }
    }
}
