using System;
using System.Collections.Generic;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int> { 1, 34, 23, 56, 12, 244 };

            var sortedList = new List<int>();
            var smallest = 0;

            var length = numberList.Count;
            for (int i = 0; i < length; i++)
            {
                var smallestNumberIndex = FindSmallestNumberIndex(numberList);
                sortedList.Add(numberList[smallestNumberIndex]);
                numberList.RemoveAt(smallestNumberIndex);
            }

            Console.WriteLine(string.Join(',', sortedList));
        }

        private static int FindSmallestNumberIndex(List<int> numberList)
        {
            var smallest = numberList[0];
            var smallestNumberIndex = 0;
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] < smallest)
                {
                    smallest = numberList[i];
                    smallestNumberIndex = i;
                }
            }

            return smallestNumberIndex;
        }
    }
}
