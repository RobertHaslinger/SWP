using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandComposite.Commands
{
    public class GreetingCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Beep boooop. Welcome to the Mighty Moving Ferrari Flipper.\n This flipper is not for everyone. Be careful though, you might not yet know what happens if you hit the ferrari...");
        }
    }
}
