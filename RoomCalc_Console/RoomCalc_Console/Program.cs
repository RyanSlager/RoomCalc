using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalc_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y";
            double width;
            double length;

            while(cont == "y")
            {
                Console.WriteLine("Please enter the width of the room");
                while (!double.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Please enter the width in numerical format");
                }

                Console.WriteLine("Please enter the length of the room");
                while (!double.TryParse(Console.ReadLine(), out length))
                {
                    Console.WriteLine("Please enter the length in numerical format");
                }

                Console.WriteLine("The area of the room is: {0}", width * length);
                Console.WriteLine("The perimeter of the room is: {0}", (2 * width) + (2 * length));

                Console.WriteLine("Continue? (y/n)");
                cont = Console.ReadLine();

                while (cont != "y" && cont != "n")
                {
                    Console.WriteLine("Please enter y to continue or n to quit.");
                    cont = Console.ReadLine();
                }
            }

        }
    }
}
