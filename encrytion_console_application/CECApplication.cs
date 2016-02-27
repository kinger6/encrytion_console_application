using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CEC
{
    internal class CECApplication
    {
        private static CECApplication _singleton;

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
            CECMainThread.Join();

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
}
