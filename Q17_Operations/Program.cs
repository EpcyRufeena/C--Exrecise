using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q17_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter a first number" );
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a third number");
            int third = Convert.ToInt32(Console.ReadLine());

            int average = (first + second + third )/ 3;
            Console.WriteLine("Average of the given number is" + average );
            


        }
    }
}
