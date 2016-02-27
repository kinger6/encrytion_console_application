using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEC
{
    internal class CECApplicationConfig
    {
        private bool _debugging;
        internal bool debugging
        {
            get
            {
                return _debugging;
            }
            set
            {
                Console.WriteLine("Please use new instance to set debug status.");
            }
        }

        private static CECApplicationConfig _DEFAULT = null;

        /// <summary>
        /// Returns the default application config
        /// </summary>
        internal static CECApplicationConfig DEFAULT
        {
            get
            {
                return (_DEFAULT != null) ? _DEFAULT : null;
            }
            set
            {
                Console.WriteLine("you can not edit the Default settings of a CECApplication.");
            }
        }

        static CECApplicationConfig()
        {
            _DEFAULT = new CECApplicationConfig(true);
        }

        internal CECApplicationConfig(bool debuggingEnabled)
        {
            this._debugging = debuggingEnabled;
        }

    }
}
