namespace DSA_BasicProgramms_Practice_Library
{
    public class FibonacciSequence
    {
        public IEnumerable<int> Fibonacci(int n)
        {
            var vals = new List<int>();

            for (int i = 0, n1 = 0, n2 = 1; i < n; i++)
            {
                int fib = n1 + n2;
                n1 = n2;
                vals.Add(fib);
                n2 = fib;
            }

            return vals;
        }
    }
}