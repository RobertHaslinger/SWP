using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandComposite.Commands
{
    public class GameOverCommand : ICommand
    {
        private PointsReceiver _pointsReceiver;

        public GameOverCommand(PointsReceiver pointsReceiver)
        {
            _pointsReceiver = pointsReceiver;
        }

        public void Execute()
        {
            Console.WriteLine($"Do-do-dooooooo. You lost! Your score is {_pointsReceiver.GetCurrentPoints()}");
        }
    }
}
