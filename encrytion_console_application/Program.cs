using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // DECLARATION
            string strUserInput;
            bool ContinueApp = true;
            bool TryAgain = true;

           
            // INPUT
            Console.WriteLine("Encription Console Application");
            Console.WriteLine("==============================");
            Console.Write("Please enter a text to encrypt:");


            // PROCCESS
            do
            {
                // INPUT
                Console.Clear();
                Console.WriteLine("Encription Console Application");
                Console.WriteLine("-------------------------------------");
                Console.Write("Please enter a text to encrypt, type \"exit\" to close: ");

                strUserInput = Console.ReadLine(); // Grabs data from user

                //Convertion Begins Here 

                Encrypt(ref strUserInput);

                Console.WriteLine(strUserInput);

                do
                {
                    Console.Write("Would you like to convert another string?(y/n): ");
                    strUserInput = Console.ReadLine();
                    if (strUserInput == "y") {
                        TryAgain = false;
                    }
                    else if (strUserInput == "n")
                    { 
                        ContinueApp = false;
                    }
                } while (TryAgain);


            }while(ContinueApp);

            Environment.Exit(0);
        }

        /// <summary>
        /// Ref outs a encrypted version of the string
        /// </summary>
        /// <param name="EncryptedValue"></param>
        private static void Encrypt(ref string EncryptedValue)
        {
            // convert to bytes
            byte[] data = Encoding.ASCII.GetBytes(EncryptedValue.ToCharArray());

            // final hex value
            string hexData;

            // get a string builder
            StringBuilder hex = new StringBuilder();

            // loop through all bytes of data that the value contatins
            foreach (byte b in data)
                hex.AppendFormat("{0:x2}", b);
            hexData = hex.ToString();

            // convert hex to binary

            string binarystring = String.Join(String.Empty, hexData.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));


            Console.WriteLine(binarystring);

        }

    }
}
