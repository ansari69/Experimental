using ExperimentalTask.Infrastructure;
using System;

namespace ExperimentalTask.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            TestInput testInput = new TestInput();

            string input = Console.ReadLine();

            Console.WriteLine("Answer: " + testInput.FuncCalculation(input));

            Console.ReadKey();
        }
    }
}
