using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.WriteLine("Enter the radius");
            double radius =Convert.ToDouble(Console.ReadLine());

            double perimeter = 2 * pi * radius;
            Console.WriteLine("Perimeter of a circle is" + perimeter);

        }
    }
}
