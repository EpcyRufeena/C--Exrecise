using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7Operations
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            double squareroot = Math.Sqrt(a);
            Console.WriteLine(squareroot);
        }
    }
}
