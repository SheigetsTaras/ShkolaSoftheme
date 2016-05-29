using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Calculate
    {

        public void WhatDoing(string operat, double x, double y)
        {

            Calculate calculate = new Calculate();

            switch (operat)
            {
                case "+":
                    calculate.Plus(x, y);
                    break;

                case "-":
                    Minus(x, y);
                    break;

                case "*":
                    Multiplication(x, y);
                    break;

                case "/":
                    if (y == 0)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                    else
                    {
                        Division(x, y);
                    }
                    break;

                case "pov":
                    Pov(x, y);
                    break;

                default:
                    Console.WriteLine("Incorrect value!");
                    break;

            }
        }



        private void Plus(double x, double y)
        {
            Console.WriteLine("x " + "+" + " y = " + (x + y).ToString("0.00"));
        }

        private void Minus(double x, double y)
        {
            Console.WriteLine("x " + "-" + " y = " + (x - y).ToString("0.00"));
        }

        private void Multiplication(double x, double y)
        {
            Console.WriteLine("x " + "*" + " y = " + (x * y).ToString("0.00"));
        }

        private void Division(double x, double y)
        {
            Console.WriteLine("x " + "/" + " y = " + (x / y).ToString("0.00"));
        }

        private void Pov(double x, double y)
        {
            Console.WriteLine("x " + "pov" + " y = " + (Math.Pow(x, y)).ToString("0.00"));
        }

    }
}
