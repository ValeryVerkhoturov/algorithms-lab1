namespace AlgorithmsLab1
{
    static class HoareSort
    {
        public static void QuicksortNoPivot(ref Queue<int> queue)
        {
            QuicksortNoPivot(ref queue, 0, queue.Length());
        }

        public static void QuicksortNoPivot(ref Queue<int> queue, int leftBound,
            int rightBound)
        {
            int i = leftBound, j = rightBound;
            while (i != j)
            {
                while (i != j)
                {
                    if (queue.ElementAt(i) <= queue.ElementAt(j))
                        --j;
                    else
                        queue.SwapElements(i, j);
                }

                while (i != j)
                {
                    if (queue.ElementAt(i) <= queue.ElementAt(j))
                        ++i;
                    else
                        queue.SwapElements(i, j);
                }
            }
            if (i - j > leftBound)
                QuicksortNoPivot(ref queue, leftBound, i - 1);
            if (j + 1 < rightBound)
                QuicksortNoPivot(ref queue, j + 1, rightBound);
        }
    }
}