using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            Func<List<int>, List<int>> add = number => numbers.Select(n => n + 1).ToList();
            Func<List<int>, List<int>> multiply = number => numbers.Select(n => n*2).ToList();
            Func<List<int>, List<int>> subtract = number => numbers.Select(n => n - 1).ToList();
            Func<List<int>, string> print = numbers => string.Join(" ", numbers);
            Func<string, bool> end = endInput => (endInput == "end") ? return false : return true;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "add")
                {
                    
                }
            }
        }
        
    }
}
