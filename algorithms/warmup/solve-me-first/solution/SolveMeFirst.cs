using System;

namespace HackerRank.Algorithms.Warmup
{
    public class SolveMeFirst
    {
        private static int Sum(int a, int b)
        {
            return a + b;
        }
        
        public static void Main(string[] args)
        {
            int firtsInput = Convert.ToInt32(Console.ReadLine());
            int secondInput = Convert.ToInt32(Console.ReadLine());

            int sum = Sum(firtsInput, secondInput);

            Console.WriteLine(sum);
        }
    }
}
