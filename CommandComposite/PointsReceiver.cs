using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandComposite
{
    public class PointsReceiver
    {
        private int _points;

        public PointsReceiver(int points = 0)
        {
            _points = points;
        }

        public void AddPoints(int amount)
        {
            if (amount<=0) return;
            _points += amount;
        }

        public int GetCurrentPoints()
        {
            return _points;
        }
    }
}
