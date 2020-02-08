using System;
using System.Collections.Generic;

namespace ListTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> {"Brian", "Jamie", "Lee"};
            // foreach (var name in names)
            // {
            // 	Console.WriteLine($"The name is {name}");
            // }

            names.Add("Maria");
            names.Remove("Jamie");

            names.Sort();
            // foreach (var name in names)
            // {
            // 	Console.WriteLine($"The name is {name.ToUpper()}");
            // }            


            var fibonacciNumbers = new List<int> {1, 1};

            for (int i = 0; i < 20; i++) {
	            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
	            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            	fibonacciNumbers.Add(previous + previous2);
            	Console.WriteLine(fibonacciNumbers[i]);
            }


        }
    }
}