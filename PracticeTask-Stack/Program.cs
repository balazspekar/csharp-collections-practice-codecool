// Task 2: Create a program that shows the integers - given by the user - in reverse sequence! Use Stack to change the sequence!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new Stack<int>();

            Console.WriteLine("Enter three numbers!");

            for (int i = 1; i <= 3; i++)
            {
                myStack.Push(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("The entered numbers in reverse order:");

            // since a stack is LIFO...
            foreach (var number in myStack)
            {
                Console.Write(number + ", ");
            }
        }
    }
}
