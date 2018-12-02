using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Func
    {
        public static void Add()
        {

            int nmbr1; //random number 1 
            int nmbr2; //random number 2
            int total; //Total

            Console.WriteLine("Input Number 1");
            nmbr1 = Convert.ToInt32(Console.ReadLine()); //input for number 1

            Console.WriteLine("Input Number 2");
            nmbr2 = Convert.ToInt32(Console.ReadLine()); //input for number 2

            total = nmbr1 + nmbr2; //adding number 1 and 2

            Console.WriteLine("Total is: " + total); //output total
            Console.WriteLine("Press Button to Continue");
            Console.ReadKey(); //waiting for key press
            
        }

        public int TestInteger(string choice)
        {

            var nmbrAsString = choice;

            int numberX; //return number

            while (int.TryParse(nmbrAsString, out numberX) == false) //test if input not number
            {

                Console.WriteLine("This is not a number!"); //error not number
                nmbrAsString = Console.ReadLine(); //input again

            }

            Console.WriteLine("Your number is: " + numberX); //output number
            return numberX;

        }

    }

}

    
