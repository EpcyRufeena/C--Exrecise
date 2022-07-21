using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base value");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "Enter the height value" );
            int h=Convert.ToInt32(Console.ReadLine());

            double Triangle = (1/2.0 * (b * h));
            Console.WriteLine("Area of a triangle is" + Triangle);
        }
        }
       
}
