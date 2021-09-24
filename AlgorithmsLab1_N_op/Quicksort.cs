
namespace AlgorithmsLab1_N_op
{
    static class HoareSort
    {
        /// Сортировка Хоара без медианного элемета
        public static void QuicksortNoPivot(ref Queue<int> queue)
        {
            Scorer.Increment(2);
            QuicksortNoPivot(ref queue, 0, queue.Length() - 1);
        }

        private static void QuicksortNoPivot(ref Queue<int> queue,
            int leftBound, int rightBound)
        {
            Scorer.Increment();
            if (leftBound >= rightBound)
            {
                return;
            }
            (int i, int j) = (leftBound, rightBound); Scorer.Increment(2);
            bool mode = true; Scorer.Increment();
            Scorer.Increment();
            while (i < j)
            {
                Scorer.Increment();
                if (queue.ElementAt(i) > queue.ElementAt(j))
                {
                    // Перестановка начального и конечного элемента
                    queue.SwapElements(i, j); Scorer.Increment(2);
                    // Смена сокращаемого конца
                    mode = !mode; Scorer.Increment(2);
                }

                // Сокращение слева или справа
                // mode == true - сокращение начала очреди
                // mode == false - сокращение конца очреди
                Scorer.Increment();
                if (mode)
                {
                    j--; Scorer.Increment();
                }
                else
                {
                    i++; Scorer.Increment();
                }
                Scorer.Increment();
            }

            QuicksortNoPivot(ref queue, leftBound, i - 1); Scorer.Increment(3);
            QuicksortNoPivot(ref queue, i + 1, rightBound); Scorer.Increment(3);
        }
    }
}