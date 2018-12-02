using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Func
    {

        public string TestInteger(string choice)
        {

            var nmbrAsString = choice;

            int numberX; //test int

            while (int.TryParse(nmbrAsString, out numberX) == false) //test if input not number
            {

                Console.WriteLine("This is not a number!"); //error not number
                nmbrAsString = Console.ReadLine(); //input again

            }

            choice = Convert.ToString(numberX);
            Console.WriteLine("Your number is: " + numberX); //output number
            return choice;

        }

    }

}

    
