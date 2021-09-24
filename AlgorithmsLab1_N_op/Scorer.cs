namespace AlgorithmsLab1_N_op
{
    public static class Scorer
    {
        private static long N_op = 0;

        public static long getN_op()
        {
            return N_op;
        }

        public static void Nullify()
        {
            N_op = 0;
        }

        public static void Increment()
        {
            N_op++;
        }

        public static void Increment(int increment)
        {
            N_op += increment;
        }
    }
}