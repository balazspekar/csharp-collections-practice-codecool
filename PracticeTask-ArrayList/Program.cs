// Task 1: Create a program that organizes the strings given by the user! Use the ArrayList collection!

using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new ArrayList();
            myList.Add("Element One");
            myList.Add("Element Two");
            myList.Add("Element Three");
            myList.Add(5);
            myList.Add(DateTime.Now);
            // here we can use the Console.ReadLine() as well to populate the ArrayList
            // the point is that an ArrayList can hold any kind of object, it's not typesafe

            foreach (var element in myList)
            {
                Console.WriteLine(element);
            }

        }
    }
}
