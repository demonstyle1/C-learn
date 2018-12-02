using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace TestConsole
{
    class Program
    {
        static void Main()
        {

            Func newFunc = new Func();

            string choice;
            int intChoice;

            // Console.WriteLine("Functions:\n");
            // Console.WriteLine("1 Add");
            Console.WriteLine("Please input a Selection");
            choice = Console.ReadLine();

            newFunc.TestInteger(choice);

            intChoice = Convert.ToInt32(choice);

            switch (intChoice)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            Console.WriteLine("Press Button to Continue");
            Console.ReadKey(); //waiting for key press

        }
    }
}
