
namespace AlgorithmsLab1
{
    static class HoareSort
    {
        public static void QuicksortNoPivot(ref Queue<int> queue)
        {
            QuicksortNoPivot(ref queue, 0, queue.Length() - 1);
        }

        public static void QuicksortNoPivot(ref Queue<int> queue, int leftBound, 
            int rightBound)
        {
            if (leftBound >= rightBound)
                return;
            (int i, int j) = (leftBound, rightBound);
            bool mode = true;
            while (i < j)
            {
                if (queue.ElementAt(i) > queue.ElementAt(j))
                {
                    // Перестанока начального и конечного элемента
                    queue.SwapElements(i, j);
                    // Смена сокращаемого конца
                    mode = !mode;
                }
                // Сокращение слева или справа
                if (mode)
                    j--;
                else
                    i++;
            }
            QuicksortNoPivot(ref queue, leftBound, i - 1);
            QuicksortNoPivot(ref queue, i + 1, rightBound);
        }
    }
}