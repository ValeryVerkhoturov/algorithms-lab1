namespace AlgorithmsLab1
{
    static class HoareSort
    {
        /// Сортировка Хоара без медианного элемета
        public static void QuicksortNoPivot(ref Queue<int> queue)
        {
            QuicksortNoPivot(ref queue, 0, queue.Length() - 1);
        }

        private static void QuicksortNoPivot(ref Queue<int> queue,
            int leftBound, int rightBound)
        {
            if (leftBound >= rightBound)
                return;
            (int i, int j) = (leftBound, rightBound);
            bool mode = true;
            while (i < j)
            {
                if (queue.ElementAt(i) > queue.ElementAt(j))
                {
                    // Перестановка начального и конечного элемента
                    queue.SwapElements(i, j);
                    // Смена сокращаемого конца
                    mode = !mode;
                }

                // Сокращение слева или справа
                // mode == true - сокращение начала очреди
                // mode == false - сокращение конца очреди
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