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

            Console.WriteLine("Choices:\n");
            Console.WriteLine("1 Look for Food");
            Console.WriteLine("Please input a Selection");
            choice = Console.ReadLine();

            newFunc.TestInteger(choice);

            intChoice = Convert.ToInt32(choice);

            

            Console.WriteLine("Press Button to Continue");
            Console.ReadKey(); //waiting for key press

        }
    }
}
