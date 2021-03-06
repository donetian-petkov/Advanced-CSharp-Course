using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            List<Box<string>> listOfBoxes = new List<Box<string>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                
                listOfBoxes.Add(box);
            }

            int[] swapIndexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int firstIndex = swapIndexes[0];
            int secondIndex = swapIndexes[1];

            SwapElements(listOfBoxes, firstIndex, secondIndex);

            foreach (var box in listOfBoxes)
            {
                Console.WriteLine(box.ToString());
            }

        }

        public static void SwapElements<T>(List<T> list, int firstIndex, int secondIndex)
        {
            T tempElement = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = tempElement;
        }
    }
}