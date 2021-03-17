using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandComposite.Commands
{
    public class CompositeCommand : ICommand
    {
        private readonly List<ICommand> _commands = new List<ICommand>();
        protected PointsReceiver PointsReceiver;

        public CompositeCommand(PointsReceiver pointsReceiver)
        {
            PointsReceiver = pointsReceiver;
        }

        public void AddICommand(ICommand command)
        {
            _commands.Add(command);
        }

        public bool RemoveICommand(ICommand command)
        {
            return _commands.Remove(command);
        }

        public virtual void Execute()
        {
            _commands.ForEach(command  => command.Execute());
        }
    }
}
