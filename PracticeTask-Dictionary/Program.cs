// Task 3: Create a program that changes the written numbers in a text to numerals ( e.g.: “three” - 3)
// The string and the numerical pairs should be stored in a Dictionary type!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var numWordsAsNumerals = new Dictionary<string, int>();
            var someText = "I am offering you two apples for sale, five cents a piece.";

            Console.WriteLine("Original text:");
            Console.WriteLine(someText);

            numWordsAsNumerals.Add("zero", 0);
            numWordsAsNumerals.Add("one", 1);
            numWordsAsNumerals.Add("two", 2);
            numWordsAsNumerals.Add("three", 3);
            numWordsAsNumerals.Add("four", 4);
            numWordsAsNumerals.Add("five", 5);
            numWordsAsNumerals.Add("six", 6);
            numWordsAsNumerals.Add("seven", 7);
            numWordsAsNumerals.Add("eight", 8);
            numWordsAsNumerals.Add("nine", 9);

            string[] splitted = someText.Split(' ');
            var sb = new StringBuilder();

            foreach (var word in splitted)
            {
                if (numWordsAsNumerals.ContainsKey(word))
                {
                    sb.Append(numWordsAsNumerals[word]);
                    sb.Append(" ");
                }
                else
                {
                    sb.Append(word);
                    sb.Append(" ");
                }
            }

            Console.WriteLine("Modified text:");
            Console.WriteLine(sb);
        }
    }
}
