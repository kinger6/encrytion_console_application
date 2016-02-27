using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CEC
{
    
    #region core application internal class
    /// <summary>
    /// Core class and also the input handler.
    /// </summary>
    internal class CECApplication
    {

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
        /// make a new CEC program with configurations.
        /// </summary>
        /// <param name="config">The configuration for this instance of the application</param>
        internal CECApplication()
        {
            // create a new thread and start it
            (CECMainThread = new Thread(() => ApplicationThreadEntryPoint())).Start();
        }

        private void ApplicationThreadEntryPoint()
        {
            // start init stuff here
            string currentInput;
            // thread loop
            while (running = true)
                // if user enters e
                if (printCommandPrefix() && (currentInput = Console.ReadLine()).Length > 0)
                {
                    resetConsoleColor();
                    runEncrytion(currentInput);
                }
        }
        
        /// <summary>
        /// Resets the console color to the default console color.
        /// </summary>
        /// <returns></returns>
        private bool resetConsoleColor()
        {
            if ((Console.ForegroundColor = ConsoleColor.DarkCyan) == ConsoleColor.DarkCyan)
                return true;
            return false;        
        }


        /// <summary>
        /// Prints Command: or what ever you want to be your command prefix
        /// </summary>
        /// <returns></returns>
        private bool printCommandPrefix()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Text to encrypt: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            return true;
        }

        /// <summary>
        /// Constructs a command from a char array
        /// 
        /// if command is vaild / exists return true;
        /// </summary>
        /// <param name="textToEncrypt"></param>
        private bool runEncrytion(string textToEncrypt)
        {
            Console.WriteLine(" == Start == \n");
            string encryptedText;
            bool decy_text;
            Console.WriteLine("Encrypting text: {0}\n", textToEncrypt);
            Console.WriteLine("Encrpyted text: {0}\n", encryptedText = TextEncryptionUtil.getEncryptedText(textToEncrypt));
            Console.WriteLine("Would you like to decrypt the string: {0}, y = yes, any other\n key for no.\n", encryptedText);
            if (decy_text = Console.ReadLine() == "y")
                Console.WriteLine("Decrypted text: {0}\n", encryptedText);
            Console.WriteLine(" == End == \n");
            return true;
        }
    }
    #endregion


    #region EncrytedText class

    internal static class TextEncryptionUtil
    {
        internal static string getEncryptedText(string textToEncrypt)
        {
            return null;
        }

        /// <summary>
        /// Returns decypted version of the text
        /// </summary>
        /// <param name="en_txt"></param>
        /// <returns></returns>
        internal static string getDecryptedText(string textToDecrypt)
        {
            return null;
        } 

    }

    #endregion

}
