// Task 4: Create your own generic storage to solve the problem described in Task 1.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask_GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<string>();
            myList.Add("string One");
            myList.Add("string Two");
            myList.Add("string Three");
            // myList.Add(DateTime.Now); this line cannot be executed if List type is set to string
            // the point of a List<> is that it's type safe
            // if we want to store all kinds of objects we should go the ArrayList route

            foreach (var element in myList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
