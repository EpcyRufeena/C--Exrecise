using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q23_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch,feet;
            Console.WriteLine("Enter a height of the person in cm ");
            Double height = Convert.ToInt32(Console.ReadLine());
            inch = height/ 2.54;
            feet = height * 0.3048;

            Console.WriteLine("Height in inch" + inch);
            Console.WriteLine("Height in feet" + feet);



            



        }
    }
}
