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

        internal CommandCompiler(char[] commandData)
        {

        }

        /// <summary>
        /// Compiles the command and returns weather or not it was success or not
        /// 
        /// 
        /// if the command doesnt have any syntax errors while compiling it will be passed to 
        /// the command handler thats supplyed as a generic.
        /// </summary>
        /// <typeparam name="T">Command Handler</typeparam>
        internal bool compileAs<T>(T handler) where T : CommandHandler
        {
            Command cmd;


            // Pass to the command Handler, the handler will return weather or not the command went through.
            return handler.handle<CommandCompiler>(this, cmd = null);
        }

    }
    #endregion
}
