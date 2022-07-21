using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q19_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter tax percentage");
            float tax = float.Parse(Console.ReadLine());
             double netamount=(amount/(1+tax/100));            
             Console.WriteLine("Net amount is" + netamount);


        }
    }
}
