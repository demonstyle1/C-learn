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
            Player defPlayer = new Player("Default", 1, 10, 5, 5, 5);

            defPlayer.CreatePlayer();

            string choice;
            int intChoice;

            Console.WriteLine("Choices:\n");
            Console.WriteLine("1 Check Inventory");
            Console.WriteLine("2 Change Equip");
            Console.WriteLine("3 Fight Stuff");
            Console.WriteLine("4 Search for Stuff");
            Console.WriteLine("5 Exit");
            Console.WriteLine("Please input a Selection");
            choice = Console.ReadLine();

            choice = newFunc.TestInteger(choice);

            intChoice = Convert.ToInt32(choice);

            switch (intChoice)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                case 4:
                    Console.WriteLine("Case 4");
                    break;
                case 5:
                    Console.WriteLine("Case 5");
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
