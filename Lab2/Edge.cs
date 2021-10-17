namespace Lab2
{
    public class Edge
    {
        public int From { get; }
        public int To { get; }
        public double Weight { get; }

        public Edge(double weight, int from, int to)
        {
            Weight = weight;
            From = from;
            To = to;
        }

        public override string ToString()
        {
            return $"{{w={Weight};f={From};t={To}}}";
        }
    }
}