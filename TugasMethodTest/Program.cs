using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TugasMethodTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 9, 5 };
            int[] numbers2 = { 2, 6, 5 };
            int biggestNumber = numbers.Max();
            int biggestNumber2 = numbers2.Max();
            int smallestNumber = numbers.Min();
            int smallestNumber2 = numbers2.Min();

            Console.WriteLine("Maximum #1: {0}", biggestNumber);
            Console.WriteLine("Maximum #2: {0}", biggestNumber2);
            Console.WriteLine();
            Console.WriteLine("Minimum #1: {0}", smallestNumber);
            Console.WriteLine("Minimum #2: {0}", smallestNumber2);

            Console.ReadKey();
        }
    }
}
