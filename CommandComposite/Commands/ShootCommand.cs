using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandComposite.Commands
{
    public class ShootCommand : ICommand
    {
        private PointsReceiver _pointsReceiver;

        public ShootCommand(PointsReceiver pointsReceiver)
        {
            _pointsReceiver = pointsReceiver;
        }

        public void Execute()
        {
            Console.WriteLine("The ball accelerates to an immense velocity. You gain 150 points");
            _pointsReceiver.AddPoints(150);
        }
    }
}
