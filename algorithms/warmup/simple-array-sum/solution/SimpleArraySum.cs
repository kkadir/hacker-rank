using System;
using System.Linq;

namespace HackerRank.Algorithms.Warmup
{
    public class SimpleArraySum
    {
        public static void Main(string[] args)
        {
            try
            {
                var arraySize = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException) 
            {
                Console.WriteLine($"Input is outside the range of the Int32 type.");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Input is not in a recognizable format.");
                return;
            }   

            var inputArray = Console.ReadLine()?.Split(' ');

            if (inputArray == null)
            {
                Console.WriteLine("Input array not provided.");
                return;
            }

            var sumArray = Array.ConvertAll(inputArray, TryParseInt32);

            Console.WriteLine(sumArray.Sum());
        }

        private static int? TryParseInt32(string element)
        {
            int value;

            return int.TryParse(element, out value)
                   ? value
                   : 0;
        }
    }
}
