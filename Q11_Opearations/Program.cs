using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11_Opearations
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 10 ;

            int b = 5;
            Console.WriteLine("Before swap a="+ a+"b="+ b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swap a="+ a+"b="+ b);
            

        }
    }
}
