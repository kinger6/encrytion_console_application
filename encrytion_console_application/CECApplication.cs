using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CEC
{
    
    #region core application internal class
    internal class CECApplication
    {
        private static CECApplication _singleton;

        /// <summary>
        /// User defined variables via command line.
        /// this will be useful in future when i get command's working i will allow users to refer 
        /// to these so they can sort of save commands.
        /// </summary>
        private Dictionary<string, object> _userDefined = new Dictionary<string, object>();

        /// <summary>
        /// Add a command or value to the _userDefined Dictionary.
        /// 
        /// Reason it returns the value you inputed is because it allows you to do more things in one expression.
        /// For example with the unity game engine:
        /// if you wanted a local ref to a componenet you just added you could do
        /// =====================================================================
        /// this.controller = gameobject.addComponent<PlayerController>();
        /// 
        /// rather then doing 
        /// 
        /// gameobject.addComponent<PlayerController>();
        /// this.controller = gameobject.getComponent<PlayerController>();
        /// =====================================================================
        /// 
        /// See what i mean? its alot more efficient and easy to read.
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="valueOrCommand"></param>
        internal T AddUserDefined<T>(string key, T valueOrCommand) where T : class
        {
            _userDefined.Add(key, valueOrCommand);
            return valueOrCommand;
        }

        /// <summary>
        /// Get from the _user defined dictionary
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        internal T GetUserDefined<T>(string key) where T : class
        {
            return _userDefined[key] as T;
        }

        private Thread CECMainThread = null;

        private bool _running;

        private bool running
        {
            get
            {
                return _running;
            }
            set
            {
                _running = value;
            }
        }

        /// <summary>
        /// get the core singleton of the CECApplication
        /// </summary>
        internal static CECApplication singleton
        {
            get
            {
                return (_singleton != null) ? _singleton : null;
            }
            set
            {
                Console.WriteLine("Sorry you can only set singleton's privately.");
            }
        }

        /// <summary>
        /// make a new CEC program with configurations.
        /// </summary>
        /// <param name="config">The configuration for this instance of the application</param>
        internal CECApplication(CECApplicationConfig config)
        {
            // create a new thread and start it
            (CECMainThread = new Thread(() => Start(config))).Start();
        }

        private void Start(CECApplicationConfig config)
        {
            // start init stuff here
            string currentInput;
            // thread loop
            while (running = true)
                // if user enters e
                if ((currentInput = Console.ReadLine()).Length > 0)
                    readCommand(currentInput.ToCharArray());
        }

        /// <summary>
        /// Constructs a command from a char array
        /// </summary>
        /// <param name="command"></param>
        private void readCommand(char[] command)
        {

        }

        /// <summary>
        /// Creates a new CEC application with no configurations
        /// </summary>
        internal CECApplication() : this(CECApplicationConfig.DEFAULT)
        {
        }

        /// <summary>
        /// Ends Application
        /// </summary>
        public void dispose(int exitCode)
        {

        }
    }
    #endregion
}
