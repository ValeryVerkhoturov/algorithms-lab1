using System;
using System.Diagnostics;

namespace AlgorithmsLab1_N_op
{
    public delegate long CountFn(int n);

    public delegate long CountOfn(int n);
    class Program
    {
        static void Main(string[] args)
        {
            CountFn countFn = i => (long)((14 + 134 * i + 208 * Math.Pow(i, 2))
             * Math.Log2(i));
            CountOfn countOfn = i => (long)(Math.Pow(i, 2) * Math.Log2(i)); 
            for (int n = 300; n <= 3000; n+=300)
            {
                (long tn, long n_op) = TestQuickSort(n);
                long fn = countFn(n);
                long ofn = countOfn(n);
                double c1 = Math.Round(Convert.ToDouble(fn) / tn, 3);
                double c2 = Math.Round(Convert.ToDouble(ofn) / tn, 3);
                double c3 = Math.Round(Convert.ToDouble(fn) / n_op, 3);
                double c4 = Math.Round(Convert.ToDouble(ofn) / n_op, 3);
                Console.WriteLine($"n= {n}\tfn= {fn}\tofn= {ofn}\ttn= " +
                                  $"{Math.Round(Convert.ToDouble(tn)/1000, 2)}\tnop= {n_op}\t" +
                                  $"c1= {c1}\tc2= {c2}\tc3= {c3}\tc4= {c4}");
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