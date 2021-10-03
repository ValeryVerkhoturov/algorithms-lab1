using System;
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
                (long time, long n_op) = TestQuickSort(elementsNum);
                Console.WriteLine($"Номер сортировки: {i}" +
                                  $"\tКоличество элементов: {elementsNum}" +
                                  $"\tВремя сортировки (ms): {time}" +
                                  $"\tКоличество операций: {n_op}");
                elementsNum += 300;
            }
            
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }

        private static (long, long) TestQuickSort(int elementsNum)
        {
            Queue<int> queue = new Queue<int>();
            Random random = new Random();
            for (int i = 0; i < elementsNum; i++)
                queue.Enqueue(random.Next(Int32.MaxValue));
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            HoareSort.QuicksortNoPivot(ref queue);
            stopwatch.Stop();
            return (stopwatch.ElapsedMilliseconds, Scorer.PopN_op());
        }
    }
}