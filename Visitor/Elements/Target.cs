using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitors;

namespace Visitor.Elements
{
    public class Target : IElement
    {
        private char _letter;
        private bool _up;
        private int _points;

        public Target(char letter, bool up, int points)
        {
            _letter = letter;
            _up = up;
            _points = points;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Reset()
        {
            _up = true;
        }

        public int GetPoints()
        {
            if (!_up)
            {
                return _points;
            }

            return 0;
        }

        public string GetReport()
        {
            string up = _up ? "up" : "down";
            return $"Target {_letter}: {up}, {_points} points";
        }
    }
}
