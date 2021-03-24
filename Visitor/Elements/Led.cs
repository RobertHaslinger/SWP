using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitors;

namespace Visitor.Elements
{
    public class Led : IElement
    {
        private int _number;
        private bool _active;
        private Color _color;
        private int _points;

        public Led(int number, bool active, Color color, int points)
        {
            _number = number;
            _active = active;
            _color = color;
            _points = points;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Reset()
        {
            _active = false;
        }

        public int GetPoints()
        {
            if (_color == Color.Red)
            {
                return _points;
            }

            return 0;
        }

        public string GetReport()
        {
            string active = (_active) ? "active" : "inactive";
            return $"LED {_number}: {active} => {_color}, {_points} points";
        }
    }
}
