using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandComposite.Commands
{
    public class MovingFerrariCommand : CompositeCommand
    {
        public MovingFerrariCommand(PointsReceiver pointsReceiver) : base(pointsReceiver)
        {
            AddICommand(new DisappearCommand(pointsReceiver));
            AddICommand(new DragBallCommand());
            AddICommand(new ShootCommand(pointsReceiver));
        }

        public override void Execute()
        {
            Console.WriteLine("As the ball hits the moving ferrari, it disappears inside of it...");
            base.Execute();
        }
    }
}
