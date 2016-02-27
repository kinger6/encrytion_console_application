using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEC.CommandUtils
{
    internal abstract class CommandHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="E">Compiler type</typeparam>
        /// <param name="cmdCompiler"></param>
        /// <param name="cmd"></param>
        /// <returns></returns>
        internal bool handle<E> (E cmdCompiler, Command cmd) where E : CommandCompiler
        {

            return false;
        }
    }
}
