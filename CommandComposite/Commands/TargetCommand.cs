using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandComposite.Commands
{
    public class TargetCommand : ICommand
    {
        private PointsReceiver _pointsReceiver;

        public TargetCommand(PointsReceiver pointsReceiver)
        {
            _pointsReceiver = pointsReceiver;
        }

        public void Execute()
        {
            Console.WriteLine("The ball hits one of the targets. You receive 30 points!");
            _pointsReceiver.AddPoints(30);
        }
    }
}
