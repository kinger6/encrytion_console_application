using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEC.CommandUtils
{
    internal class HomeShellCommandCompiler : CommandCompiler
    {

        internal HomeShellCommandCompiler(char[] data) : base(data)
        {
            // do custom compiler stuff here.

        }

        internal override bool compileAs<T, E>(T handler)
        {
            E cmd = null;

            return handler.handle<E>(cmd);
            throw new NotImplementedException();
        }
    }
}
