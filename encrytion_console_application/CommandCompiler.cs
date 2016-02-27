using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEC.CommandUtils
{
    #region Command Compiler
    /// <summary>
    /// Compiles a inputed command into command elements and a command
    /// </summary>
    /// <typeparam name="T">The generic type for this compiled command.(should be of type Command)</typeparam>
    internal abstract class CommandCompiler
    {
        protected char[] command;

        internal CommandCompiler(char[] commandData)
        {
            this.command = commandData;
        }

        /// <summary>
        /// Compiles the command and returns weather or not it was success or not
        /// 
        /// 
        /// if the command doesnt have any syntax errors while compiling it will be passed to 
        /// the command handler thats supplyed as a generic.
        /// </summary>
        /// <typeparam name="T">Command Handler</typeparam>
        /// <typeparam name="E">The Command Type</typeparam>
        internal abstract bool compileAs<T, E>(T handler) where T : CommandHandler where E : Command;

    }
    #endregion
}
