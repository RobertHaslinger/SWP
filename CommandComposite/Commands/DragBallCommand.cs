using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandComposite.Commands
{
    public class DragBallCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("The car drags the ball to a different location....");
        }
    }
}
