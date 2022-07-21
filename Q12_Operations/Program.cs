using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine("Before swap a: " +a+ "b:"+b);

            int  temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After swap a: " +a+ "b:"+b);



        }
    }
}
