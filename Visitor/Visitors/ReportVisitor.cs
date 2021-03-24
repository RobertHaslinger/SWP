using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Elements;

namespace Visitor.Visitors
{
    public class ReportVisitor : IVisitor
    {
        public void Visit(Ramp ramp)
        {
            Console.WriteLine(ramp.GetReport());
        }

        public void Visit(Target target)
        {
            Console.WriteLine(target.GetReport());
        }

        public void Visit(Led led)
        {
            Console.WriteLine(led.GetReport());
        }
    }
}
