namespace AlgorithmsLab1
{
    static class HoareSort
    {
        public static void Quicksort(ref Queue<int> queue)
        {
            Quicksort(ref queue, 0, queue.Length());
        }
        public static void Quicksort(ref Queue<int> queue, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(ref queue, p, r);
                Quicksort(ref queue, p, q - 1);
                Quicksort(ref queue, q + 1, r);
            }
        }
        
        static int Partition(ref Queue<int> queue, int p, int r)
        {
            int x = queue.ElementAt(r);
            int i = p - 1;
            for (int j = p; j <= r - 1; j++)
            {
                if (queue.ElementAt(j) <= x)
                {
                    i ++;
                    queue.InvertElements(i, j);
                }
            }

            queue.InvertElements(i + 1, r);
            return i + 1;
        }
    }
}