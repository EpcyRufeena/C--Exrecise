using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base number");
            double base1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter exponent number");
            double exponent = Convert.ToDouble(Console.ReadLine());
            double n  = Math.Pow(base1,exponent);
            Console.WriteLine(n);
        }
    }
}
