﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int second= Convert.ToInt32(Console.ReadLine());

            int sum = first + second;
            int product = first * second;
            int difference = Math.Abs(first - second);


            Console.WriteLine("The sum of" + first + "and " + second + "is :" + sum);
            Console.WriteLine("The product of" + first + "and " + second + "is :" + product);
            Console.WriteLine("The difference of" + first + "and " + second + "is :" + difference);
            

        }
    }
}
