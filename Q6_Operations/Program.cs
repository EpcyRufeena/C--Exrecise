using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double a = Convert.ToDouble(Console.ReadLine());
            //int square = a * a;
            double square = Math.Pow(a,2);
            Console.WriteLine(square);
        }
    }
}
