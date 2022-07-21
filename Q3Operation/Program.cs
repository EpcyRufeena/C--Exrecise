using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the volume of the rectangular length");
            float l = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the volume of the rectangular height");
            float w = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the volume of the rectangular width");
            float h = float.Parse(Console.ReadLine());
            float rectangle = l * w * h;
            Console.WriteLine("volume of a rectanglar water tank is"+ rectangle);


        }
    }
}
