﻿using System.Linq;

namespace _02._Selection_Sort
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SelectionSort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var min = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[min])
                    {
                        min = j;
                    }
                }

                Swap(numbers, i, min);
            }
        }

        private static void Swap(int[] numbers, int first, int second)
        {
            var temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }
    }
}
