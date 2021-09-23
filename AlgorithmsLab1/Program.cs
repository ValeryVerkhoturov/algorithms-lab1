using System;
using System.Diagnostics;

namespace AlgorithmsLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestQuickSort(1000);
            
        }

        static void TestQuickSort(int elementsNum)
        {
            Queue<int> queue = new Queue<int>();
            Random random = new Random();
            for (int i = 0; i < elementsNum; i++)
            {
                queue.Enqueue(random.Next(Int32.MaxValue));
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            HoareSort.QuicksortNoPivot(ref queue);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds / 1000f);
        }
    }
}
