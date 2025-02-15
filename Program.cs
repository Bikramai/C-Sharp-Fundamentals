using System;

namespace Foreachloops 
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

    }

}
