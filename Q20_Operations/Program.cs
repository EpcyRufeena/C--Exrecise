using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q18_Opearations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the basic pay");
            int Basic_salary= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter DA ");
            float da = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter TA");
            float ta = float.Parse(Console.ReadLine());
           
            float pf = 8/ 100;
            float Grosspay = Basic_salary + da + ta - pf;           
            Console.WriteLine("Basic salary " + Basic_salary);
            Console.WriteLine("Dearness Allowence " + da);
            Console.WriteLine("Travel Allowence " + ta);
            Console.WriteLine("Provident Fund " + pf);
            Console.WriteLine("Grosspay is " + Grosspay);
             




        }
    }
}
