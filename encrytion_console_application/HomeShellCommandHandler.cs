using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEC.CommandUtils
{
    /// <summary>
    /// THe Home shell screen command handler(all commands that are ran on the home screen)
    /// </summary>
    internal class HomeShellCommandHandler : CommandHandler
    {
        internal override bool handle<T>(T command)
        {
            Console.WriteLine("Ended at HomeSheel handler with command: {0}", command.read());

            return false;
            throw new NotImplementedException();
        }
    }
}
