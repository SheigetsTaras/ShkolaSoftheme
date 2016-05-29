using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();

            string example = "";

            Console.WriteLine("Options: +, -, *, /, pov, sqrt");
            Console.Write("Please enter numbers(x,xx + y,yy) or other: ");

            example = Console.ReadLine();
            string[] split = example.Split(' ');

            double x = double.Parse(split[0]);
            double y = double.Parse(split[2]);

            calculate.WhatDoing(split[1], x, y);
        }


        

        
    }
}
