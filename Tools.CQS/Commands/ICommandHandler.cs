using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.CQS.Commands
{
    public interface ICommandHandler<TCommand>
        where TCommand : ICommandDefinition
    {
        CommandResult Execute(TCommand command);
    }
}
