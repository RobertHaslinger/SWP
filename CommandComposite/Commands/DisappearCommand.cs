using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandComposite.Commands
{
    public class DisappearCommand : ICommand
    {
        private PointsReceiver _pointsReceiver;

        public DisappearCommand(PointsReceiver pointsReceiver)
        {
            _pointsReceiver = pointsReceiver;
        }
        
        public void Execute()
        {
            Console.WriteLine("The ball disappeared, but the game is not over yet! You receive 20 points.");
            _pointsReceiver.AddPoints(20);
        }
    }
}
