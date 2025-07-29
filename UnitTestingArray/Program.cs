using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingArray
{
    public class Program
    {

        public static void Main(string[] args)
        {
            try
            {
                int[] test1 = { 3, 6, 9 };
                Console.WriteLine($"Result for test1: {ArrayUtils.IsAmazing3(test1)}");

                int[] test2 = { 2, 4, 7 };
                Console.WriteLine($"Result for test2: {ArrayUtils.IsAmazing3(test2)}");

                Console.WriteLine("Done.");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"Caught Exception: {ex.GetType().Name} - {ex.Message}");
            }
        }

    }
}
