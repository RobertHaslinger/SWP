using System;
using System.Collections.Generic;
using Visitor.Elements;
using Visitor.Visitors;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IElement> elements = new List<IElement>();
            elements.Add(new Ramp("Airramp", true, 20, 3, true));
            elements.Add(new Led(69, true, Color.Red, 10));
            elements.Add(new Target('Y', false, 15));

            Console.WriteLine("Report state at the beginning:");
            IVisitor reportVisitor = new ReportVisitor();
            VisitorClient.ElementsAcceptVisitor(elements, reportVisitor);

            Console.WriteLine("\nGet points:");
            IVisitor pointVisitor = new PointVisitor();
            VisitorClient.ElementsAcceptVisitor(elements, pointVisitor);

            Console.WriteLine("\nReset elements");
            IVisitor resetVisitor = new ResetVisitor();
            VisitorClient.ElementsAcceptVisitor(elements, resetVisitor);

            Console.WriteLine("\nReport state at the end:");
            VisitorClient.ElementsAcceptVisitor(elements, reportVisitor);
        }
    }
}
