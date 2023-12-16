using System;

namespace Binery_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
            int numberToCount = 4;
            int count = countOccurrences(array, numberToCount);
            Console.WriteLine($"The number {numberToCount} appears {count} times in array.");
        }
        static int countOccurrences(int[] array, int number)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
