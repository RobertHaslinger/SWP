using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Elements;

namespace Visitor.Visitors
{
    public class PointVisitor : IVisitor
    {
        public void Visit(Ramp ramp)
        {
            Console.WriteLine($"Ramp-Points: {ramp.GetPoints()}");
        }

        public void Visit(Target target)
        {
            Console.WriteLine($"Target-Points: {target.GetPoints()}");
        }

        public void Visit(Led led)
        {
            Console.WriteLine($"LED-Points: {led.GetPoints()}");
        }
    }
}
