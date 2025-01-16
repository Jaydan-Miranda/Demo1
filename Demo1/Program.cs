using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // print out the prompt to ask for the name
            Console.WriteLine("What is your name?");
            // declare a string variable to hold the user input
            string name = Console.ReadLine();
            // print out the prompt to ask for the color
            Console.WriteLine("What is your favorite color");
            // declare a string variable to hold the user input for the color
            string color = Console.ReadLine();

            //print out some comfirm message
            Console.WriteLine("Hello " + name + " your favorite color is " + color);

            //stop the screen for user to see the result
            Console.ReadLine();
        }
    }
}
