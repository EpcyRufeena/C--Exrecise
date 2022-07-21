using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a kilometer");
            double km = Convert.ToDouble(Console.ReadLine());

            double miles = km / 1.60934;
            Console.WriteLine(miles +  "Miles");
        }
    }
}
