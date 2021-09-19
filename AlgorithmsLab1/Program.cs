﻿using System;

namespace AlgorithmsLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)
            {
                TestQuickSort();
            }
        }

        static void TestQuickSort()
        {
            Queue<int> queue = new Queue<int>();
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                queue.Enqueue(random.Next(100));
            }
            HoareSort.QuicksortNoPivot(ref queue);
            Console.WriteLine(queue.ToString());
        }
    }
}
