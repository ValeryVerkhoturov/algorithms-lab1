using System;
using System.Diagnostics;

namespace AlgorithmsLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsNum = 300;
            for (int i = 0; i < 10; i++)
            {
                Stopwatch stopwatch = TestQuickSort(elementsNum);
                Console.WriteLine($"Номер сортировки: {i}, " +
                                  $"Количество элементов: {elementsNum}, " +
                                  $"Время сортировки (ms): " +
                                  $"{stopwatch.ElapsedMilliseconds}");
                elementsNum += 300;
            }
        }

        private static Stopwatch TestQuickSort(int elementsNum)
        {
            Queue<int> queue = new Queue<int>();
            Random random = new Random();
            for (int i = 0; i < elementsNum; i++)
                queue.Enqueue(random.Next(Int32.MaxValue));
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            HoareSort.QuicksortNoPivot(ref queue);
            stopwatch.Stop();
            return stopwatch;
        }
    }
}