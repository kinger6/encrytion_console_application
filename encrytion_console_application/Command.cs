using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEC.CommandUtils
{
    /// <summary>
    /// Is a command. 
    /// 
    /// </summary>
    /// <typeparam name="T">This command type</typeparam>
    /// <typeparam name="B">THis command element child type</typeparam>
    internal abstract class Command<T, B>
    {

        protected Dictionary<string, B> elements = new Dictionary<string, B>();

        /// <summary>
        /// Returns all command elements, name, etc.
        /// basiclly a summer of what this command is
        /// </summary>
        /// <returns></returns>
        internal string read()
        {
            StringBuilder builder = new StringBuilder();



            return builder.ToString();
        }
    }

    /// <summary>
    /// Is a command element. so if you type help that keyword would be a command element or help -u that command would have two elements
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal abstract class CommandElement<T>
    {

    }

}
