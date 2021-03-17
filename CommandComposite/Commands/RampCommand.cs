using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandComposite.Commands
{
    public class RampCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Dum dumm dummmmm, the ball enters the ramp.... and leaves it even faster!");
        }
    }
}
