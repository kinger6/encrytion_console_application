using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEC.CommandUtils
{
    internal abstract class CommandHandler
    {
        internal abstract bool handle<T>(T command) where T : Command;
    }
}
