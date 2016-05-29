using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size: ");
            int size = int.Parse(Console.ReadLine());
            for(int i = 0; i< size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            int center = size / 2;
            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j <= size; j++)
                {
                    if (i <= center)
                    {
                        if (j >= center - i && j <= center + i)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    else
                    {
                        if (j >= center + i - size + 1 && j <= center - i + size - 1)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
