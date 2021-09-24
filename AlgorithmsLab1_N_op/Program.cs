﻿using System;
using System.Diagnostics;

namespace AlgorithmsLab1_N_op
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsNum = 300;
            for (int i = 0; i < 10; i++)
            {
                (long time, long N_op) = TestQuickSort(elementsNum);
                Console.WriteLine($"Номер сортировки: {i}, " +
                                  $"Количество элементов: {elementsNum}, " +
                                  $"Время сортировки (ms): {time}, " +
                                  $"Количество операций: {N_op}");
                elementsNum += 300;
            }
        }

        private static (long, long) TestQuickSort(int elementsNum)
        {
            Queue<int> queue = new Queue<int>();
            Random random = new Random();
            for (int i = 0; i < elementsNum; i++)
                queue.Enqueue(random.Next(Int32.MaxValue));
            Scorer.Nullify();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            HoareSort.QuicksortNoPivot(ref queue);
            stopwatch.Stop();
            long N_op = Scorer.getN_op();
            Scorer.Nullify();
            return (stopwatch.ElapsedMilliseconds, N_op);
        }
    }
}