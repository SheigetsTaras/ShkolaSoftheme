using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();

            for (int i = 1; i < 10; i++)
            {
                stack1.Push(i);
            }

            for (int i = 1; i < 10; i++)
            {
                stack2.Push(stack1.Pop());
            }

            for (int i = 1; i < 10; i++)
            {
                Console.Write(stack2.Pop());
            }

        }
    }
}
