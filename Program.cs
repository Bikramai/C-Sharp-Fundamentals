using System;

namespace Arrays
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of Int
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            // Array of boolean
            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            // array of string
            var nanes = new string[3] { "Ikram", "ayusha", "Mangi" };

        }
    }

}
