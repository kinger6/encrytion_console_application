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
                Console.WriteLine(strOutput);

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
    }
}
