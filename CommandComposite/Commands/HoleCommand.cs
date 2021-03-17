using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandComposite.Commands
{
    public class HoleCommand : CompositeCommand
    {
        public HoleCommand(PointsReceiver pointsReceiver) : base(pointsReceiver)
        {
            AddICommand(new DisappearCommand(pointsReceiver));
            AddICommand(new ShootCommand(pointsReceiver));
        }

        public override void Execute()
        {
            Console.WriteLine("The ball entered the hole. Ding doooooong!");
            base.Execute();
        }
    }
}
