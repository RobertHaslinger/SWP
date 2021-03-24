using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitors;

namespace Visitor.Elements
{
    public class Ramp : IElement
    {
        private string _name;
        private bool _opened;
        private int _points;
        private int _runs;
        private bool _blinks;

        public Ramp(string name, bool opened, int points, int runs, bool blinks)
        {
            _name = name;
            _opened = opened;
            _points = points;
            _runs = runs;
            _blinks = blinks;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Reset()
        {
            _opened = false;
            _points = 0;
        }

        public int GetPoints()
        {
            return _runs * _points;
        }

        public string GetReport()
        {
            string open = (_opened) ? "opened" : "closed";
            string blink = (_blinks) ? "blinks" : "dark";
            return $"Ramp {_name}: {open}, {_points} points, {_runs} runs, {blink}";
        }
    }
}
