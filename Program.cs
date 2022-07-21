using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the field ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width of the field ");
            double width = Convert.ToDouble(Console.ReadLine());

            double field = (length * width);

            double acre = (field / 43560);

            Console.WriteLine("Area of a field is" + acre + "square feet");


        }
    }
}
