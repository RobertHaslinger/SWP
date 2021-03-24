using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitors;

namespace Visitor.Elements
{
    public interface IElement
    {
        public void Accept(IVisitor visitor);
        public void Reset();
        public int GetPoints();
        public string GetReport();
    }
}
